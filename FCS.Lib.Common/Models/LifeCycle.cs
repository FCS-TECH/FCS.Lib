// ***********************************************************************
// Filename         : LifeCycle.cs
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

namespace FCS.Lib.Common.Models;

/// <summary>
///     Represents the life cycle of an entity, including its last update and associated time frame.
/// </summary>
/// <remarks>
///     This class is used to define the life cycle details, such as the last update timestamp and the time frame
///     during which the entity is active. It is utilized in various mappings and data transfer objects, such as
///     <see cref="VatInfo" />.
/// </remarks>
public class LifeCycle
{
    /// <summary>
    ///     Gets or sets the date and time of the last update for the lifecycle.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the last update timestamp.
    /// </value>
    public string LastUpdate { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the time frame associated with the lifecycle.
    /// </summary>
    /// <remarks>
    ///     This property represents a period with a defined start and end date,
    ///     which is used to describe the lifecycle's duration or validity.
    /// </remarks>
    public TimeFrame TimeFrame { get; set; } = new();
}