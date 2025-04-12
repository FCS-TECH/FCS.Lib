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
        return JsonConvert.DeserializeObject<BrRegCompany>(responseData);
    }

    /// <summary>
    ///     Parses the response data from a search request to the Brønnøysund Register Center (Brønnøysundregistrene)
    ///     and converts it into a list of <see cref="BrRegCompany" /> objects.
    /// </summary>
    /// <param name="responseData">
    ///     The JSON response data from the Brønnøysund Register Center search request.
    /// </param>
    /// <returns>
    ///     A list of <see cref="BrRegCompany" /> objects representing the companies that match the search criteria.
    /// </returns>
    /// <remarks>
    ///     The method deserializes the JSON response into a <see cref="BrRegSearchResponse" /> object and extracts
    ///     the list of entities from it.
    /// </remarks>
    /// <exception cref="JsonException">
    ///     Thrown if the JSON response data cannot be deserialized into the expected format.
    /// </exception>
    public IList<BrRegCompany> ParseSearchRequestContent(string responseData)
    {
        var result = JsonConvert.DeserializeObject<BrRegSearchResponse>(responseData);
        return result.Embedded.Entities;
    }
}