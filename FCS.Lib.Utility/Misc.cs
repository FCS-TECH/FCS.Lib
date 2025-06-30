// ***********************************************************************
// Assembly         : FCS.Lib.Utility
// Filename         : Misc.cs
// Author           : Frede Hundewadt
// Created          : 2025 05 24 10:05
// 
// Last Modified By :
// Last Modified On : 2025 05 24 10:23
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

namespace FCS.Lib.Utility
{
    /// <summary>
    /// Provides utility methods for working with Unix timestamps, time spans, and other miscellaneous operations.
    /// </summary>
    public static class Misc
    {
        /// <summary>
        ///     Extracts the month component from a given Unix timestamp.
        /// </summary>
        /// <param name="timeStamp">The Unix timestamp to extract the month from.</param>
        /// <returns>An integer representing the month (1 for January, 2 for February, etc.).</returns>
        public static int MonthFromTimestamp(long timeStamp)
        {
            return Transform.TimeStampToDateTime(timeStamp).Month;
        }

        /// <summary>
        ///     Determines whether the specified Unix timestamp falls within the specified month.
        /// </summary>
        /// <param name="timestamp">The Unix timestamp to evaluate.</param>
        /// <param name="month">The month to check against, represented as an integer (1 for January, 2 for February, etc.).</param>
        /// <returns>
        ///     <c>true</c> if the timestamp corresponds to the specified month; otherwise, <c>false</c>.
        /// </returns>
        public static bool TimestampInMonth(long timestamp, int month)
        {
            return Transform.TimeStampToDateTime(timestamp).Month == month;
        }

        /// <summary>
        ///     Converts a given <see cref="TimeSpan" /> to its equivalent total number of minutes.
        /// </summary>
        /// <param name="timespan">The <see cref="TimeSpan" /> to be converted.</param>
        /// <returns>The total number of minutes represented by the <paramref name="timespan" />.</returns>
        public static long TimespanToMinutes(TimeSpan timespan)
        {
            return Convert.ToUInt32(timespan.Ticks / 10000000L) / 60;
        }

    }
}