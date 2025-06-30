// ***********************************************************************
// Assembly         : FCS.Lib.Utility
// Filename         : Sanitizers.cs
// Author           : Frede Hundewadt
// Created          : 2025 05 24 10:05
// 
// Last Modified By :
// Last Modified On : 2025 05 24 10:20
// ***********************************************************************
// <copyright company="FCS">
//     Copyright (C) 2025-2025 FCS Frede's Computer Service.
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU Affero General Public License as
//     published by the Free Software Foundation, either version 3 of the
//     License, or (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU Affero General Public License for more details.
// 
//     You should have received a copy of the GNU Affero General Public License
//     along with this program.  If not, see [https://www.gnu.org/licenses]
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text.RegularExpressions;

namespace FCS.Lib.Utility;

/// <summary>
/// Provides utility methods for sanitizing input data such as phone numbers and zip codes.
/// </summary>
public static class Sanitizers
{
    /// <summary>
    ///     Determines whether the specified search phrase is valid.
    /// </summary>
    /// <param name="searchPhrase">The search phrase to validate.</param>
    /// <param name="length">The maximum allowed length for the search phrase. Defaults to 50.</param>
    /// <returns>
    ///     <c>true</c> if the search phrase is not null, not empty, not whitespace, and does not exceed the specified length;
    ///     otherwise, <c>false</c>.
    /// </returns>
    public static bool SearchPhraseIsValid(string searchPhrase, int length = 50)
    {
        return !string.IsNullOrWhiteSpace(searchPhrase) && searchPhrase.Length <= length;
    }
    
    /// <summary>
    ///     Sanitizes the provided phone number by removing specific country codes and non-numeric characters.
    /// </summary>
    /// <param name="phone">The phone number to sanitize.</param>
    /// <returns>
    ///     A sanitized phone number containing only numeric characters.
    ///     Returns an empty string if the input is null, empty, or consists solely of whitespace.
    /// </returns>
    public static string SanitizePhone(string phone)
    {
        if (string.IsNullOrWhiteSpace(phone))
            return "";
        phone = phone.Replace("+45", "").Replace("+46", "").Replace("+47", "");
        var regexObj = new Regex(@"[^\d]");
        return regexObj.Replace(phone, "");
    }

    /// <summary>
    ///     Sanitizes the provided zip code by removing all non-numeric characters.
    /// </summary>
    /// <param name="zipCode">The zip code to sanitize.</param>
    /// <returns>
    ///     A sanitized zip code containing only numeric characters. Returns an empty string if the input is null, empty,
    ///     or consists only of whitespace.
    /// </returns>
    public static string SanitizeZipCode(string zipCode)
    {
        if (string.IsNullOrWhiteSpace(zipCode))
            return "";
        var regexObj = new Regex(@"[^\d]");
        return regexObj.Replace(zipCode, "");
    }
}