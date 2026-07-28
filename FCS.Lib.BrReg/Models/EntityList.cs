// ***********************************************************************
// Filename         : EntityList.cs
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

using System.Collections.Generic;
using Newtonsoft.Json;

namespace FCS.Lib.BrReg.Models;

/// <summary>
///     Represents a collection of entities retrieved from the Brønnøysund Register Center (Brønnøysundregistrene).
///     This class encapsulates a list of companies or other entities that match specific search criteria.
/// </summary>
/// <remarks>
///     The <see cref="EntityList" /> class is part of the domain model for interacting with
///     data from the Brønnøysund Register Center. It is used to encapsulate a collection of entities
///     returned as part of a search response.
/// </remarks>
public class EntityList
{
    /// <summary>
    ///     Gets or sets the list of companies retrieved from the Brønnøysund Register Center.
    /// </summary>
    /// <value>
    ///     A collection of <see cref="BrRegCompany" /> objects representing the companies.
    /// </value>
    /// <remarks>
    ///     This property corresponds to the "enheter" field in the JSON response from the Brønnøysund Register Center API.
    /// </remarks>
    [JsonProperty("enheter")]
    public IList<BrRegCompany> Entities { get; set; }
}