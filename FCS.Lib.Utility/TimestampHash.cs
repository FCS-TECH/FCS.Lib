// ***********************************************************************
// Assembly         : Inno.Common
// Filename         : TimestampHash.cs
// Author           : Frede Hundewadt
// Created          : 2024 03 01 07:49
// 
// Last Modified By : root
// Last Modified On : 2024 04 11 13:00
// ***********************************************************************
// <copyright company="FCS">
//     Copyright (C) 2024-2024 FCS Frede's Computer Service.
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

namespace FCS.Lib.Utility
{
    /// <summary>
    /// Provides utility methods for generating hash-based strings using timestamps.
    /// </summary>
    public static class TimestampHash
    {
        /// <summary>
        /// Generates a timestamp-based hash string with the specified prefix.
        /// </summary>
        /// <param name="prefix">The prefix to prepend to the generated hash.</param>
        /// <returns>A string combining the specified prefix and the generated hash in uppercase format.</returns>
        public static string Get(string prefix)
        {
            var eNumber = Get();
            return $"{prefix}-{eNumber.ToUpper()}";
        }

        /// <summary>
        /// Generates a unique hash based on the current UTC file time.
        /// </summary>
        /// <returns>A string representation of the hash in hexadecimal format.</returns>
        public static string Get()
        {
            var ftHash = DateTime.Now.ToFileTimeUtc().GetHashCode();
            return $"{ftHash:X8}";
        }
    }
}