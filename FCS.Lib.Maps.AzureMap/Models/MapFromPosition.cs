// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Maps.AzureMap
// // Filename         : MapFromPosition.cs
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
///     Represents a request model for retrieving information from a geographic position using the Azure Map service.
/// </summary>
/// <remarks>
///     This class is used to specify the latitude, longitude, and request type for reverse geocoding operations.
///     It extends the <see cref="Defaults" /> class, inheriting common properties for Azure Map service requests.
/// </remarks>
public class MapFromPosition : Defaults
{
    /// <summary>
    ///     Gets or sets the latitude coordinate of the position.
    /// </summary>
    /// <remarks>
    ///     This property represents the latitude value used in geographic coordinate systems.
    ///     It is typically used in conjunction with the <see cref="Longitude" /> property to define a specific location.
    /// </remarks>
    public double Latitude { get; set; }

    /// <summary>
    ///     Gets or sets the longitude coordinate of the position.
    /// </summary>
    /// <remarks>
    ///     This property represents the longitude value used in geographic coordinate systems.
    ///     It is typically used in conjunction with the <see cref="Latitude" /> property to define a specific location.
    /// </remarks>
    public double Longitude { get; set; }

    /// <summary>
    ///     Gets or sets the type of the map operation to be performed.
    /// </summary>
    /// <remarks>
    ///     This property specifies the type of operation, such as "reverse",
    ///     to be used in map-related requests. The default value is "reverse".
    /// </remarks>
    public string Type { get; set; } = "reverse";
}

/// <summary>
///     Represents the default configuration for Azure Map service requests.
/// </summary>
/// <remarks>
///     This class provides base properties such as <c>Action</c>, <c>Format</c>, and <c>Scope</c>,
///     which are commonly used in Azure Map service requests. It serves as a foundation for more
///     specific request models.
/// </remarks>
public class Defaults
{
    /// <summary>
    ///     Gets or sets the action to be performed in the Azure Maps API request.
    /// </summary>
    /// <remarks>
    ///     The default value is "search". This property determines the type of operation
    ///     to execute, such as searching for locations or performing reverse geocoding.
    /// </remarks>
    public string Action { get; set; } = "search";

    /// <summary>
    ///     Gets or sets the format of the response returned by the Azure Maps API.
    /// </summary>
    /// <value>
    ///     The format of the response, typically "json".
    /// </value>
    /// <remarks>
    ///     This property determines the format in which the Azure Maps API returns data.
    ///     Commonly used formats include "json".
    /// </remarks>
    public string Format { get; set; } = "json";

    /// <summary>
    ///     Gets or sets the scope of the search operation.
    /// </summary>
    /// <remarks>
    ///     The scope determines the specific area or type of data to be included in the search.
    ///     Common values include "address" for address-based searches.
    /// </remarks>
    public string Scope { get; set; } = "address";
}

/// <summary>
///     Represents a structured request model for mapping an address using the Azure Map service.
/// </summary>
/// <remarks>
///     This class extends the <see cref="Defaults" /> class, inheriting default properties such as
///     <c>Action</c>, <c>Format</c>, and <c>Scope</c>. It provides additional properties specific to
///     address-based mapping, such as country code, postal code, street name, and street number.
/// </remarks>
public class MapFromAddress : Defaults
{
    /// <summary>
    ///     Gets or sets the country code associated with the address.
    /// </summary>
    /// <remarks>
    ///     This property is used to specify the country code in ISO 3166-1 alpha-2 format.
    ///     It is utilized in geolocation requests to identify the country of the address.
    /// </remarks>
    public string CountryCode { get; set; } = "";

    /// <summary>
    ///     Gets or sets the postal code associated with the address.
    /// </summary>
    /// <remarks>
    ///     This property is used to specify the postal code for geolocation requests.
    ///     It is included as part of the structured address information sent to the mapping service.
    /// </remarks>
    public string PostalCode { get; set; } = "";

    /// <summary>
    ///     Gets or sets the name of the street in the address.
    /// </summary>
    /// <remarks>
    ///     This property represents the street name component of an address.
    ///     It is used alongside <see cref="StreetNumber" /> and other address details
    ///     to create a complete and structured address.
    /// </remarks>
    public string StreetName { get; set; } = "";

    /// <summary>
    ///     Gets or sets the street number of the address.
    /// </summary>
    /// <remarks>
    ///     This property represents the specific number assigned to a building or location on a street.
    ///     It is used in conjunction with <see cref="StreetName" /> and other address components
    ///     to form a complete and structured address.
    /// </remarks>
    public string StreetNumber { get; set; } = "";

    /// <summary>
    ///     Gets or sets the type of the address mapping request.
    /// </summary>
    /// <remarks>
    ///     This property specifies the type of the request for address mapping.
    ///     The default value is <c>"structured"</c>, which indicates that the request
    ///     uses structured address components such as country code, postal code, street name, and street number.
    /// </remarks>
    public string Type { get; set; } = "structured";
}