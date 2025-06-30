// ***********************************************************************
// Assembly         : FCS.Lib.BrReg
// Filename         : BrRegResponseParser.cs
// Author           : Frede Hundewadt
// Created          : 2025 01 03 14:01
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

using System;
using System.Collections.Generic;
using FCS.Lib.BrReg.Models;
using Newtonsoft.Json;

namespace FCS.Lib.BrReg;

/// <summary>
///     Provides functionality to parse responses from the Brønnøysund Register Center (BrReg) into domain-specific models.
/// </summary>
public class BrRegResponseParser
{
    /// <summary>
    ///     Parses a JSON response from the Brønnøysund Register Center (BrReg) and converts it into a
    ///     <see cref="BrRegCompany" /> object.
    /// </summary>
    /// <param name="responseData">The JSON response data as a string.</param>
    /// <returns>A <see cref="BrRegCompany" /> object representing the parsed data.</returns>
    /// <exception cref="JsonSerializationException">
    ///     Thrown if the JSON response cannot be deserialized into a
    ///     <see cref="BrRegCompany" /> object.
    /// </exception>
    public BrRegCompany ParseOrgNumberRequestContent(string responseData)
    {
        try
        {
            return JsonConvert.DeserializeObject<BrRegCompany>(responseData);
        }
        catch (JsonSerializationException)
        {
            return null;
        }
    }

    /// <summary>
    /// Extracts a list of companies from the provided Brønnøysund Register Center (BrReg) search response.
    /// </summary>
    /// <param name="content">
    /// The search response containing embedded entities representing companies registered in the Brønnøysund Register Center.
    /// </param>
    /// <returns>
    /// A list of <see cref="BrRegCompany"/> objects representing the companies extracted from the response.
    /// </returns>
    /// <remarks>
    /// This method retrieves the entities embedded within the <see cref="BrRegResponse"/> and returns them as a list of domain-specific models.
    /// </remarks>
    public IList<BrRegCompany> GetEntities(BrRegResponse content)
    {
        try
        {
            return content.PageInfo.TotalElements == 0 ? [] : content.Embedded.Entities;
        }
        catch (Exception)
        {
            return [];
        }
    }

    /// <summary>
    ///     Extracts pagination information from a <see cref="BrRegResponse" /> object.
    /// </summary>
    /// <param name="content">
    ///     The <see cref="BrRegResponse" /> object containing the pagination metadata.
    /// </param>
    /// <returns>
    ///     A <see cref="BrPageInfo" /> object representing the pagination details, such as page size,
    ///     total elements, total pages, and the current page number.
    /// </returns>
    /// <remarks>
    ///     This method retrieves the <see cref="BrPageInfo" /> property from the provided
    ///     <see cref="BrRegResponse" /> object, which contains metadata about the paginated results
    ///     of a search query.
    /// </remarks>
    public BrPageInfo GetPageInfo(BrRegResponse content)
    {
        try
        {
            return content.PageInfo;
        }
        catch (Exception)
        {
            return null;
        }
        
    }

    /// <summary>
    ///     Retrieves the navigational links from a <see cref="BrRegResponse" /> object.
    /// </summary>
    /// <param name="content">
    ///     The <see cref="BrRegResponse" /> object containing the links to be retrieved.
    /// </param>
    /// <returns>
    ///     A <see cref="BrLinks" /> object representing the navigational links, such as first, self, next, and last.
    /// </returns>
    /// <remarks>
    ///     This method extracts the <see cref="BrLinks" /> property from the provided <see cref="BrRegResponse" />.
    ///     The links are typically used for pagination or navigating through resources.
    /// </remarks>
    public BrLinks GetPageLinks(BrRegResponse content)
    {
        try
        {
            return content.Links;
        }
        catch (Exception)
        {
            return null;
        }
    }

}