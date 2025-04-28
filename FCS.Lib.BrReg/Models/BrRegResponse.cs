// ***********************************************************************
// Assembly         : FCS.Lib.BrReg
// Filename         : BrRegResponse.cs
// Author           : Frede Hundewadt
// Created          : 2025 04 10 13:04
// 
// Last Modified By :
// Last Modified On : 2025 04 10 13:04
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

using Newtonsoft.Json;

namespace FCS.Lib.BrReg.Models;

/// <summary>
///     Represents the response from a search query to the Brønnøysund Register Center (Brønnøysundregistrene).
///     This class encapsulates the search results, including metadata and a collection of entities
///     that match the search criteria.
/// </summary>
/// <remarks>
///     The <see cref="BrRegResponse" /> class is part of the domain model for interacting with
///     data from the Brønnøysund Register Center. It is used to encapsulate the results of a search query,
///     providing access to both metadata and the list of matching entities.
/// </remarks>
public class BrRegResponse
{
    /// <summary>
    ///     Gets or sets the embedded collection of entities retrieved from the Brønnøysund Register Center
    ///     (Brønnøysundregistrene).
    ///     This property represents the search results, encapsulated as an <see cref="EntityList" />.
    /// </summary>
    /// <remarks>
    ///     The <see cref="Embedded" /> property is populated with a collection of entities that match the search criteria.
    ///     It is deserialized from the "_embedded" JSON property in the response.
    /// </remarks>
    [JsonProperty("_embedded")]
    public EntityList Embedded { get; set; }

    /// <summary>
    /// Gets or sets the collection of navigational links associated with the search response.
    /// </summary>
    /// <remarks>
    /// The <see cref="Links" /> property provides access to various navigational links, such as links
    /// for pagination or resource navigation. These links are typically used to traverse through
    /// related resources or pages of data in the Brønnøysund Register Center's API.
    /// </remarks>
    [JsonProperty("_links")]
    public BrLinks Links { get; set; }
    
    /// <summary>
    /// Gets or sets the pagination details for the search response.
    /// </summary>
    /// <remarks>
    /// The <see cref="PageInfo" /> property provides metadata about the pagination of the search results,
    /// including the size of each page, the total number of elements, the total number of pages, 
    /// and the current page number.
    /// </remarks>
    [JsonProperty("page")]
    public BrPageInfo PageInfo { get; set; }
}