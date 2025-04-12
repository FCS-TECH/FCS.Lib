// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Maps.AzureMap
// // Filename         : MapAddress.cs
// // Created          : 2025-01-03 14:01
// // Last Modified By : dev
// // Last Modified On : 2025-01-04 11:01
// // ***********************************************************************
// // <copyright company="Frede Hundewadt">
// //     Copyright (C) 2010-2025 Frede Hundewadt
// //     This program is free software: you can redistribute it and/or modify
// //     it under the terms of the GNU Affero General Public License as
// //     published by the Free Software Foundation, either version 3 of the
// //     License, or (at your option) any later version.
// //
// //     This program is distributed in the hope that it will be useful,
// //     but WITHOUT ANY WARRANTY; without even the implied warranty of
// //     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// //     GNU Affero General Public License for more details.
// //
// //     You should have received a copy of the GNU Affero General Public License
// //     along with this program.  If not, see [https://www.gnu.org/licenses]
// // </copyright>
// // <summary></summary>
// // ***********************************************************************

namespace FCS.Lib.Maps.AzureMap.Models;

/// <summary>
///     Represents a detailed address model used in mapping services.
/// </summary>
/// <remarks>
///     This class provides properties to describe various components of an address,
///     such as country, subdivision, municipality, postal code, and street information.
///     It is commonly used in mapping and geolocation applications.
/// </remarks>
public class MapAddress
{
    /// <summary>
    ///     Gets or sets the name of the country associated with the address.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the full name of the country.
    /// </value>
    /// <remarks>
    ///     This property is used to specify the country in a human-readable format.
    ///     It complements other properties such as <see cref="CountryCode" /> and <see cref="CountryCodeIso3" />
    ///     for more detailed country information.
    /// </remarks>
    public string Country { get; set; }

    /// <summary>
    ///     Gets or sets the two-letter country code associated with the address.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the ISO 3166-1 alpha-2 country code.
    /// </value>
    /// <remarks>
    ///     This property is used to specify the country in a standardized two-letter format.
    ///     It is particularly useful for integration with systems that require country codes
    ///     in compliance with ISO 3166-1 alpha-2 standards.
    /// </remarks>
    public string CountryCode { get; set; }

    /// <summary>
    ///     Gets or sets the ISO 3166-1 alpha-3 code of the country associated with the address.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the three-letter ISO code of the country.
    /// </value>
    /// <remarks>
    ///     This property provides a standardized representation of the country code,
    ///     which is useful for internationalization and integration with systems that
    ///     require ISO 3166-1 alpha-3 codes.
    /// </remarks>
    public string CountryCodeIso3 { get; set; }

    /// <summary>
    ///     Gets or sets the name of the country subdivision, such as a state, province, or region.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the name of the country subdivision.
    /// </value>
    /// <remarks>
    ///     This property is used to specify a more granular level of location within a country.
    ///     Examples include states in the United States, provinces in Canada, or regions in other countries.
    /// </remarks>
    public string CountrySubDivision { get; set; }

    /// <summary>
    ///     Gets or sets the code representing the country subdivision (e.g., state, province, or region).
    /// </summary>
    /// <remarks>
    ///     This property typically contains a standardized code for the subdivision of a country,
    ///     such as a state or province, and is used in geolocation and mapping services.
    /// </remarks>
    public string CountrySubdivisionCode { get; set; }

    /// <summary>
    ///     Gets or sets the name of the country subdivision (e.g., state, province, or region).
    /// </summary>
    /// <remarks>
    ///     This property represents the human-readable name of the administrative division
    ///     within a country, such as a state, province, or region. It is commonly used in
    ///     geolocation and mapping applications to provide detailed address information.
    /// </remarks>
    public string CountrySubdivisionName { get; set; }

    /// <summary>
    ///     Gets or sets the freeform address representation of the location.
    /// </summary>
    /// <remarks>
    ///     This property provides a single-line, human-readable representation of the address,
    ///     combining various address components such as street, city, and postal code.
    ///     It is typically used for display purposes or when a structured address format is not required.
    /// </remarks>
    public string FreeformAddress { get; set; }

    /// <summary>
    ///     Gets or sets the local name of the address.
    /// </summary>
    /// <remarks>
    ///     This property represents the localized name of the address,
    ///     which may vary depending on the region or language settings.
    /// </remarks>
    public string LocalName { get; set; }

    /// <summary>
    ///     Gets or sets the name of the municipality associated with the address.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the municipality, which is typically a city, town, or similar administrative
    ///     division.
    /// </value>
    /// <remarks>
    ///     This property is used to specify the municipality component of an address,
    ///     which can be useful for geolocation and mapping services.
    /// </remarks>
    public string Municipality { get; set; }

    /// <summary>
    ///     Gets or sets the subdivision of the municipality, such as a district or borough.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the specific subdivision within a municipality.
    /// </value>
    /// <remarks>
    ///     This property is used to provide more granular location details within a municipality.
    ///     It is particularly useful in mapping and geolocation services to identify smaller
    ///     administrative or geographical areas.
    /// </remarks>
    public string MunicipalitySubdivision { get; set; }

    /// <summary>
    ///     Gets or sets the name of the neighbourhood associated with the address.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the neighbourhood name, which provides
    ///     additional granularity to the address details.
    /// </value>
    /// <remarks>
    ///     This property is useful for identifying smaller geographic areas within a municipality
    ///     or subdivision, enhancing the precision of location-based services.
    /// </remarks>
    public string Neighbourhood { get; set; }

    /// <summary>
    ///     Gets or sets the postal code of the address.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the postal code associated with the address.
    /// </value>
    /// <remarks>
    ///     The postal code is a key component of the address used for geolocation and mapping purposes.
    /// </remarks>
    public string PostalCode { get; set; }

    /// <summary>
    ///     Gets or sets the name of the street associated with the address.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the street name.
    /// </value>
    /// <remarks>
    ///     This property is used to specify the street name component of the address.
    ///     It is commonly utilized in geolocation and mapping services to provide
    ///     detailed address information.
    /// </remarks>
    public string StreetName { get; set; }
}