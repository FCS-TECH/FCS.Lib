// ***********************************************************************
// Filename         : VatState.cs
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
///     Represents the state of VAT (Value Added Tax) information for an entity.
/// </summary>
/// <remarks>
///     This class encapsulates details about the VAT state, including the last update timestamp,
///     the current state, and the associated time frame. It is used to track and manage VAT-related
///     information for entities.
/// </remarks>
public class VatState
{
    /// <summary>
    ///     Gets or sets the date and time of the last update for the VAT state.
    /// </summary>
    /// <value>
    ///     A string representing the last update date and time in a specific format.
    /// </value>
    public string LastUpdate { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the VAT (Value Added Tax) state, representing the current status of VAT registration.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> indicating the VAT state, such as "NORMAL" or "LUKKET".
    /// </value>
    public string State { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the time frame associated with the VAT state.
    /// </summary>
    /// <remarks>
    ///     The <see cref="TimeFrame" /> defines the start and end dates for the validity of the VAT state.
    /// </remarks>
    public TimeFrame TimeFrame { get; set; } = new();
}