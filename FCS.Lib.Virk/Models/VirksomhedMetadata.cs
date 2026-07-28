// ***********************************************************************
// Filename         : VirksomhedMetadata.cs
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
///     Represents metadata associated with a business, including its latest name and address information.
/// </summary>
/// <remarks>
///     This class is part of the <c>FCS.Lib.Virk</c> namespace and serves as a container for metadata
///     related to a business. It provides access to the most recent name and address details of the business.
/// </remarks>
/// <seealso cref="NyesteNavn" />
/// <seealso cref="NyesteBeliggenhedsadresse" />
public class VirksomhedMetadata
{
    /// <summary>
    ///     Gets or sets the most recent name associated with the business.
    /// </summary>
    /// <remarks>
    ///     This property provides access to the current name of the business, represented by an instance of the
    ///     <see cref="NyesteNavn" /> class.
    /// </remarks>
    public NyesteNavn NyesteNavn { get; set; } = new();

    /// <summary>
    ///     Gets or sets the most recent address of the business location.
    /// </summary>
    /// <remarks>
    ///     This property provides access to the latest address details, including street name, house number range,
    ///     postal code, care-of name, and postal district.
    /// </remarks>
    public NyesteBeliggenhedsadresse NyesteBeliggenhedsadresse { get; set; } = new();
}