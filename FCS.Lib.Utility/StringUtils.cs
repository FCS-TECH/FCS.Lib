// ***********************************************************************
// Assembly         : Inno.Common
// Filename         : StringUtils.cs
// Author           : Frede Hundewadt
// Created          : 2025 03 05 08:03
// 
// Last Modified By :
// Last Modified On : 2025 03 05 12:03
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

using System;
using System.Globalization;

namespace FCS.Lib.Utility;

/// <summary>
/// 
/// </summary>
public class StringUtils
{
    /// <summary>
    /// Sanitizes the input string by normalizing it, removing specific unwanted characters, 
    /// and trimming whitespace. If the input string is <c>null</c>, an empty string is returned.
    /// </summary>
    /// <param name="fixString">The input string to sanitize.</param>
    /// <returns>A sanitized version of the input string, or an empty string if the input is <c>null</c>.</returns>
    public static string SafeString(string fixString)
    {
        return fixString?
            .Normalize()
            .Replace(Convert.ToString((char)2, CultureInfo.InvariantCulture), "")
            .Replace("\"", "")
            .Replace("'", "")
            .Trim() ?? "";
    }

    /// <summary>
    /// Converts the specified text into a URL-safe format by removing or replacing
    /// certain characters and converting the text to lowercase.
    /// </summary>
    /// <param name="text">The input string to be converted into a URL-safe format.</param>
    /// <returns>A URL-safe string where specific characters are removed or replaced, 
    /// and spaces are replaced with hyphens.</returns>
    public static string SafeUrl(string text)
    {
        return SafeString(text)
            .Replace("&", "")
            .Replace("!", "")
            .Replace("\"", "")
            .Replace(".", "")
            .Replace("'", "")
            .Replace("`", "")
            .Replace("´", "")
            .Replace("'", "")
            .Replace("*", " ")
            .Replace(" ", "-")
            .ToLowerInvariant();
    }
}