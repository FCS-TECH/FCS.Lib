// ***********************************************************************
// Filename         : Periode.cs
// Author           : Frede Hundewadt
// Created          : 2025 10 14 10:10
// 
// Last Modified By :
// Last Modified On : 2026 07 22 15:25
// ***********************************************************************
// <copyright company="FCS">
//     Copyright (C) 2025-2026 FCS Frede's Computer Service.
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

namespace FCS.Lib.Virk.Models;

/// <summary>
///     Represents a period with a start and end date.
/// </summary>
/// <remarks>
///     This class is part of the <c>FCS.Lib.Virk</c> namespace and is used to define a time period
///     with properties indicating the start and end of the validity.
/// </remarks>
/// <seealso cref="LivsforloebModel" />
/// <seealso cref="VirksomhedsStatus" />
public class Periode
{
    /// <summary>
    ///     Gets or sets the start date of the validity period.
    /// </summary>
    /// <value>
    ///     A string representing the start date of the period in a specific format.
    /// </value>
    public string GyldigFra { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the end date of the period's validity.
    /// </summary>
    /// <remarks>
    ///     This property represents the date until which the period is considered valid.
    ///     If the value is empty or null, it indicates that the period has no defined end date.
    /// </remarks>
    public string GyldigTil { get; set; } = string.Empty;
}