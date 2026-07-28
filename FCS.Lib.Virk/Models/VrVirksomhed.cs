// ***********************************************************************
// Filename         : VrVirksomhed.cs
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
///     Represents a company entity with its associated data, including CVR number, status, metadata, and lifecycle
///     information.
/// </summary>
/// <remarks>
///     This class is part of the <c>FCS.Lib.Virk</c> namespace and serves as a model for company-related information.
///     It includes details such as the company's unique CVR number, its current statuses, metadata, and lifecycle stages.
/// </remarks>
/// <seealso cref="VirksomhedsStatus" />
/// <seealso cref="VirksomhedMetadata" />
/// <seealso cref="LivsforloebModel" />
public class VrVirksomhed
{
    /// <summary>
    ///     Gets or sets the CVR number of the business.
    /// </summary>
    /// <remarks>
    ///     The CVR number is a unique identifier for businesses in Denmark.
    /// </remarks>
    public string CvrNummer { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the list of statuses associated with the business.
    /// </summary>
    /// <remarks>
    ///     Each status represents a specific state of the business over a defined period.
    /// </remarks>
    public List<VirksomhedsStatus> VirksomhedsStatus { get; set; } = new();

    /// <summary>
    ///     Gets or sets the metadata associated with the business.
    /// </summary>
    /// <remarks>
    ///     This property provides access to the latest name and address information
    ///     of the business, encapsulated within a <see cref="Models.VirksomhedMetadata" /> object.
    /// </remarks>
    public VirksomhedMetadata VirksomhedMetadata { get; set; } = new();

    /// <summary>
    ///     Represents the lifecycle stages of the company.
    /// </summary>
    /// <remarks>
    ///     This property contains a collection of lifecycle models (<see cref="LivsforloebModel" />)
    ///     that describe the various stages and periods in the company's lifecycle.
    /// </remarks>
    /// <seealso cref="LivsforloebModel" />
    public List<LivsforloebModel> Livsforloeb { get; set; } = new();
}