// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Common
// // Filename         : TimeFrame.cs
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

namespace FCS.Lib.Common.Models;

/// <summary>
///     Represents a time frame with a start date and an end date.
/// </summary>
/// <remarks>
///     This class is used to define a period of time with specific start and end dates.
///     It is utilized in various contexts, such as VAT states and life cycles, to represent
///     the duration of a particular state or lifecycle.
/// </remarks>
public class TimeFrame
{
    /// <summary>
    ///     Gets or sets the start date of the time frame.
    /// </summary>
    /// <value>
    ///     A string representing the start date of the time frame.
    /// </value>
    public string StartDate { get; set; } = "";

    /// <summary>
    ///     Gets or sets the end date of the time frame.
    /// </summary>
    /// <remarks>
    ///     This property represents the concluding date of a specific time frame.
    ///     It is used in various contexts to define the end of a period.
    /// </remarks>
    public string EndDate { get; set; } = "";
}