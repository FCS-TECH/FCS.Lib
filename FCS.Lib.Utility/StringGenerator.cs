// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Utility
// // Filename         : StringGenerator.cs
// // Created          : 2025-01-03 14:01
// // Last Modified By : dev
// // Last Modified On : 2025-01-04 11:01
// // ***********************************************************************
// // <copyright company="Frede Hundewadt">
// //     Copyright (C) 2010-2025 Frede Hundewadt
// //     This program is free software: you can redistribute it and/or modify
// //     it under the terms of the GNU Affero General Public License as
// //     published by the Free Software Foundation, either version 3 of the
// //     License, or (at your option) any later version.
// //
// //     This program is distributed in the hope that it will be useful,
// //     but WITHOUT ANY WARRANTY; without even the implied warranty of
// //     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// //     GNU Affero General Public License for more details.
// //
// //     You should have received a copy of the GNU Affero General Public License
// //     along with this program.  If not, see [https://www.gnu.org/licenses]
// // </copyright>
// // <summary></summary>
// // ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace FCS.Lib.Utility;

/// <summary>
///     Provides utility methods for generating various types of random strings, numbers, and other data.
/// </summary>
public static class StringGenerator
{
    /// <summary>
    ///     Generates a short URL string with a default length of 8 characters.
    /// </summary>
    /// <returns>A randomly generated short URL string.</returns>
    public static string GenerateShortUrl()
    {
        return GenerateShortUrl(8);
    }


    /// <summary>
    /// Generates a random short URL string with the specified length.
    /// </summary>
    /// <param name="length">
    /// The desired length of the generated short URL. Must be a positive integer.
    /// </param>
    /// <returns>
    /// A randomly generated short URL string containing a mix of uppercase letters, lowercase letters, and numeric characters.
    /// </returns>
    /// <remarks>
    /// This method ensures that the generated short URL contains characters from different groups 
    /// (uppercase letters, lowercase letters, and numeric characters) to enhance randomness and uniqueness.
    /// </remarks>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown if the <paramref name="length"/> parameter is less than or equal to zero.
    /// </exception>
    public static string GenerateShortUrl(int length)
    {
        // <remarks>derived from https://sourceforge.net/projects/shorturl-dotnet/</remarks>
        const string charsLower = "abcdefghijklmnopqrstuvwxyz";
        const string charsUpper = "ABCDFEGHJKLMNPQRSTUVWXYZ";
        const string charsNumeric = "123456789";

        // Create a local array containing supported short-url characters
        // grouped by types.
        var charGroups = new[]
        {
            charsLower.ToCharArray(),
            charsUpper.ToCharArray(),
            charsNumeric.ToCharArray()
        };

        // Use this array to track the number of unused characters in each
        // character group.
        var charsLeftInGroup = new int[charGroups.Length];

        // Initially, all characters in each group are not used.
        for (var i = 0; i < charsLeftInGroup.Length; i++)
            charsLeftInGroup[i] = charGroups[i].Length;

        // Use this array to track (iterate through) unused character groups.
        var leftGroupsOrder = new int[charGroups.Length];

        // Initially, all character groups are not used.
        for (var i = 0; i < leftGroupsOrder.Length; i++)
            leftGroupsOrder[i] = i;

        // Using our private random number generator
        var random = RandomFromRngCrypto();

        // This array will hold short-url characters.
        // Allocate appropriate memory for the short-url.
        var shortUrl = new char[random.Next(length, length)];

        // Index of the last non-processed group.
        var lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;

        // Generate short-url characters one at a time.
        for (var i = 0; i < shortUrl.Length; i++)
        {
            // If only one character group remained unprocessed, process it;
            // otherwise, pick a random character group from the unprocessed
            // group list. To allow a special character to appear in the
            // first position, increment the second parameter of the Next
            // function call by one, i.e. lastLeftGroupsOrderIdx + 1.
            int nextLeftGroupsOrderIdx;
            if (lastLeftGroupsOrderIdx == 0)
                nextLeftGroupsOrderIdx = 0;
            else
                nextLeftGroupsOrderIdx = random.Next(0,
                    lastLeftGroupsOrderIdx);

            // Get the actual index of the character group, from which we will
            // pick the next character.
            var nextGroupIdx = leftGroupsOrder[nextLeftGroupsOrderIdx];

            // Get the index of the last unprocessed characters in this group.
            var lastCharIdx = charsLeftInGroup[nextGroupIdx] - 1;

            // If only one unprocessed character is left, pick it; otherwise,
            // get a random character from the unused character list.
            var nextCharIdx = lastCharIdx == 0 ? 0 : random.Next(0, lastCharIdx + 1);

            // Add this character to the short-url.
            shortUrl[i] = charGroups[nextGroupIdx][nextCharIdx];

            // If we processed the last character in this group, start over.
            if (lastCharIdx == 0)
            {
                charsLeftInGroup[nextGroupIdx] =
                    charGroups[nextGroupIdx].Length;
            }
            // There are more unprocessed characters left.
            else
            {
                // Swap processed character with the last unprocessed character
                // so that we don't pick it until we process all characters in
                // this group.
                if (lastCharIdx != nextCharIdx)
                    (charGroups[nextGroupIdx][lastCharIdx], charGroups[nextGroupIdx][nextCharIdx]) = (
                        charGroups[nextGroupIdx][nextCharIdx], charGroups[nextGroupIdx][lastCharIdx]);

                // Decrement the number of unprocessed characters in
                // this group.
                charsLeftInGroup[nextGroupIdx]--;
            }

            // If we processed the last group, start all over.
            if (lastLeftGroupsOrderIdx == 0)
            {
                lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;
            }
            // There are more unprocessed groups left.
            else
            {
                // Swap processed group with the last unprocessed group
                // so that we don't pick it until we process all groups.
                if (lastLeftGroupsOrderIdx != nextLeftGroupsOrderIdx)
                    (leftGroupsOrder[lastLeftGroupsOrderIdx], leftGroupsOrder[nextLeftGroupsOrderIdx]) = (
                        leftGroupsOrder[nextLeftGroupsOrderIdx], leftGroupsOrder[lastLeftGroupsOrderIdx]);

                // Decrement the number of unprocessed groups.
                lastLeftGroupsOrderIdx--;
            }
        }

        // Convert password characters into a string and return the result.
        return new string(shortUrl);
    }


    /// <summary>
    ///     Generates a username based on the specified strOptions or default settings.
    /// </summary>
    /// <param name="strOptions">
    ///     An instance of <see cref="StringGeneratorOptions" /> specifying the rules for generating the username.
    ///     If <c>null</c>, default strOptions will be used, requiring a length of 16 characters,
    ///     at least one digit, one lowercase letter, one uppercase letter, and four unique characters.
    /// </param>
    /// <returns>A randomly generated username string that adheres to the specified or default strOptions.</returns>
    public static string GenerateUsername(StringGeneratorOptions strOptions = null)
    {
        strOptions ??= new StringGeneratorOptions
        {
            RequiredLength = 16,
            RequireDigit = true,
            RequireLowercase = true,
            RequireUppercase = true,
            RequiredUniqueChars = 4,
            RequireNonLetterOrDigit = false,
            RequireNonAlphanumeric = false
        };
        return GenerateRandomString(strOptions);
    }


    /// <summary>
    ///     Generates a random password based on the specified strOptions or default settings.
    /// </summary>
    /// <param name="strOptions">
    ///     An instance of <see cref="StringGeneratorOptions" /> that specifies the password requirements.
    ///     If <c>null</c>, default strOptions will be used, which include:
    ///     <list type="bullet">
    ///         <item>RequiredLength: 16</item>
    ///         <item>RequireDigit: true</item>
    ///         <item>RequireLowercase: true</item>
    ///         <item>RequireUppercase: true</item>
    ///         <item>RequiredUniqueChars: 8</item>
    ///         <item>RequireNonLetterOrDigit: false</item>
    ///         <item>RequireNonAlphanumeric: false</item>
    ///     </list>
    /// </param>
    /// <returns>
    ///     A randomly generated password that satisfies the provided or default requirements.
    /// </returns>
    public static string GeneratePassword(StringGeneratorOptions strOptions = null)
    {
        strOptions ??= new StringGeneratorOptions
        {
            RequiredLength = 16,
            RequireDigit = true,
            RequireLowercase = true,
            RequireUppercase = true,
            RequiredUniqueChars = 8,
            RequireNonLetterOrDigit = false,
            RequireNonAlphanumeric = false
        };
        return GenerateRandomString(strOptions);
    }


    /// <summary>
    ///     Generates a random text string of the specified length, alternating between consonants and vowels.
    /// </summary>
    /// <param name="length">The desired length of the generated text.</param>
    /// <returns>A randomly generated string of the specified length.</returns>
    public static string GenerateRandomText(int length)
    {
        const string consonants = "bcdfghjklmnprstvxzBDFGHJKLMNPRSTVXZ";
        const string vowels = "aeiouyAEIOUY";

        var rndString = "";
        var randomNum = RandomFromRngCrypto();

        while (rndString.Length < length)
        {
            rndString += consonants[randomNum.Next(consonants.Length)];
            if (rndString.Length < length)
                rndString += vowels[randomNum.Next(vowels.Length)];
        }

        return rndString;
    }

    /// <summary>
    ///     Generates a random number of the specified length using cryptographic randomness.
    /// </summary>
    /// <param name="length">The length of the random number to generate.</param>
    /// <returns>A random integer of the specified length.</returns>
    public static int GenerateRandomNumber(int length)
    {
        const string digits = "123456789";
        var rndString = "";
        var randomNum = RandomFromRngCrypto();
        while (rndString.Length < length) rndString += digits[randomNum.Next(digits.Length)];
        return Convert.ToInt32(rndString);
    }


    /// <summary>
    ///     Generates a random string based on the specified strOptions.
    /// </summary>
    /// <param name="strOptions">
    ///     The <see cref="StringGeneratorOptions" /> object that specifies the requirements for the generated string.
    ///     If not provided, default strOptions will be used.
    /// </param>
    /// <returns>
    ///     A randomly generated string that meets the specified criteria.
    /// </returns>
    /// <remarks>
    ///     The generated string can include uppercase letters, lowercase letters, digits, and non-alphanumeric characters,
    ///     depending on the provided strOptions.
    /// </remarks>
    public static string GenerateRandomString(StringGeneratorOptions strOptions = null)
    {
        strOptions ??= new StringGeneratorOptions
        {
            RequiredLength = 16,
            RequireDigit = true,
            RequireLowercase = true,
            RequireUppercase = true,
            RequiredUniqueChars = 4,
            RequireNonLetterOrDigit = true,
            RequireNonAlphanumeric = true
        };

        var randomChars = new[]
        {
            "ABCDEFGHJKLMNOPQRSTUVWXYZ", // uppercase 
            "abcdefghijkmnopqrstuvwxyz", // lowercase
            "0123456789", // digits
            "!@$?_-" // non-alphanumeric
        };

        // Using our private random number generator
        var rand = RandomFromRngCrypto();

        var chars = new List<char>();

        if (strOptions.RequireUppercase)
            chars.Insert(rand.Next(0, chars.Count),
                randomChars[0][rand.Next(0, randomChars[0].Length)]);

        if (strOptions.RequireLowercase)
            chars.Insert(rand.Next(0, chars.Count),
                randomChars[1][rand.Next(0, randomChars[1].Length)]);

        if (strOptions.RequireDigit)
            chars.Insert(rand.Next(0, chars.Count),
                randomChars[2][rand.Next(0, randomChars[2].Length)]);

        if (strOptions.RequireNonAlphanumeric)
            chars.Insert(rand.Next(0, chars.Count),
                randomChars[3][rand.Next(0, randomChars[3].Length)]);

        var rcs = randomChars[rand.Next(0, randomChars.Length)];
        for (var i = chars.Count;
             i < strOptions.RequiredLength
             || chars.Distinct().Count() < strOptions.RequiredUniqueChars;
             i++)
            chars.Insert(rand.Next(0, chars.Count),
                rcs[rand.Next(0, rcs.Length)]);

        return new string(chars.ToArray());
    }

    /// <summary>
    ///     Generates a new instance of <see cref="System.Random" /> seeded with a cryptographically secure random value.
    /// </summary>
    /// <remarks>
    ///     This method uses <see cref="System.Security.Cryptography.RNGCryptoServiceProvider" /> to generate a secure seed
    ///     value,
    ///     ensuring that the resulting random number generator produces less predictable sequences compared to the default
    ///     implementation.
    /// </remarks>
    /// <returns>
    ///     A new instance of <see cref="System.Random" /> seeded with a cryptographically secure random value.
    /// </returns>
    public static Random RandomFromRngCrypto()
    {
        // As the default Random is based on the current time
        // so it produces the same "random" number within a second
        // Use a crypto service to create the seed value

        // 4-byte array to fill with random bytes
        var randomBytes = new byte[4];

        // Generate 4 random bytes.
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(randomBytes);
        }

        // Convert 4 bytes into a 32-bit integer value.
        var seed = ((randomBytes[0] & 0x7f) << 24) |
                   (randomBytes[1] << 16) |
                   (randomBytes[2] << 8) |
                   randomBytes[3];

        // Return a truly randomized random generator
        return new Random(seed);
    }
}