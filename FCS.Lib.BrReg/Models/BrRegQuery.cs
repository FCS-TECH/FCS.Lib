// ***********************************************************************
// Assembly         : FCS.Lib.BrReg
// Filename         : BrRegQuery.cs
// Author           : Frede Hundewadt
// Created          : 2025 04 09 13:04
// 
// Last Modified By :
// Last Modified On : 2025 04 10 12:04
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

namespace FCS.Lib.BrReg.Models;

/// <summary>
///     Represents a query to the Brønnøysund Register Centre (Brønnøysundregistrene) for retrieving information related to
///     a specific VAT number.
/// </summary>
/// <remarks>
///     This class is part of the FCS.Lib.BrReg namespace and is designed to facilitate communication with the Brønnøysund
///     Register Centre.
/// </remarks>
public class BrRegQuery
{
    /// <summary>
    ///     Gets or sets the address associated with the query result.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the address of the entity retrieved from the Brønnøysund Register Centre.
    /// </value>
    /// <remarks>
    ///     This property contains the street address or other location-specific details of the entity.
    /// </remarks>
    public string Address { get; set; } = "";

    /// <summary>
    ///     Gets or sets the city associated with the query.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the name of the city.
    /// </value>
    /// <remarks>
    ///     This property is typically used in conjunction with <see cref="ZipCode" /> to specify the location
    ///     related to the query.
    /// </remarks>
    public string City { get; set; } = "";

    /// <summary>
    ///     Gets or sets the name associated with the query.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the name of the entity or individual related to the query.
    /// </value>
    /// <remarks>
    ///     This property is used to specify or retrieve the name associated with the VAT number being queried.
    /// </remarks>
    public string EntityName { get; set; } = "";

    /// <summary>
    ///     Gets or sets the organisation number associated with the query.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the VAT (Value Added Tax) number.
    /// </value>
    /// <remarks>
    ///     The VAT number is used to identify a specific entity in the Brønnøysund Register Centre.
    ///     Ensure the VAT number is valid and correctly formatted before setting this property.
    /// </remarks>
    public string VatNumber { get; set; } = "";

    /// <summary>
    ///     Gets or sets the postal code associated with the query.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the postal code.
    /// </value>
    /// <remarks>
    ///     The postal code is used to identify the geographical area related to the query.
    /// </remarks>
    public string ZipCode { get; set; } = "";
}