// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Maps.AzureMap
// // Filename         : ReverseAddress.cs
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

using System.Collections.Generic;

namespace FCS.Lib.Maps.AzureMap.Models;

/// <summary>
///     Represents a reverse geocoded address with detailed components.
/// </summary>
/// <remarks>
///     This class extends <see cref="MapAddress" /> to include additional properties
///     specific to reverse geocoding results, such as building number, street details,
///     route numbers, and a bounding box for the address location.
/// </remarks>
public class ReverseAddress : MapAddress
{
    /// <summary>
    ///     Gets or sets the building number associated with the address.
    /// </summary>
    /// <remarks>
    ///     This property represents the specific building number within the address,
    ///     typically used to identify individual buildings in a street or complex.
    /// </remarks>
    public string BuildingNumber { get; set; }

    /// <summary>
    ///     Gets or sets the name of the country subdivision, such as a state, province, or region.
    /// </summary>
    /// <remarks>
    ///     This property provides detailed information about the administrative division
    ///     within a country, which is part of the reverse geocoding result.
    /// </remarks>
    public string CountrySubdivision { get; set; }

    /// <summary>
    ///     Gets or sets the unique identifier for the reverse geocoded address.
    /// </summary>
    /// <remarks>
    ///     This property represents a unique identifier that can be used to
    ///     distinguish this reverse geocoded address from others.
    /// </remarks>
    public string Id { get; set; }

    /// <summary>
    ///     Gets or sets the name of the street associated with the reverse geocoded address.
    /// </summary>
    /// <remarks>
    ///     This property provides the street information derived from the reverse geocoding process.
    ///     It may include the street name without additional details such as building numbers or route numbers.
    /// </remarks>
    public string Street { get; set; }

    /// <summary>
    ///     Gets or sets the full street address, including both the street name and number.
    /// </summary>
    /// <remarks>
    ///     This property combines the street name and building number into a single string,
    ///     providing a complete representation of the street address.
    ///     It is useful for display purposes or when a single field is required for the address.
    /// </remarks>
    public string StreetNameAndNumber { get; set; }

    /// <summary>
    ///     Gets or sets the street number of the address.
    /// </summary>
    /// <remarks>
    ///     This property represents the numeric component of the street address,
    ///     typically used to identify a specific building or location on the street.
    /// </remarks>
    public string StreetNumber { get; set; }

    /// <summary>
    ///     Gets or sets the list of route numbers associated with the address.
    /// </summary>
    /// <remarks>
    ///     This property contains a collection of route numbers that are relevant to the reverse geocoded address.
    ///     It is particularly useful for identifying specific routes or highways near the address.
    /// </remarks>
    public List<string> RouteNumbers { get; set; }

    /// <summary>
    ///     Gets or sets the geographical position associated with the reverse geocoded address.
    /// </summary>
    /// <remarks>
    ///     The position is typically represented as a string containing latitude and longitude
    ///     coordinates, separated by a comma (e.g., "47.6062,-122.3321").
    /// </remarks>
    public string Position { get; set; }

    /// <summary>
    ///     Gets or sets the bounding box that defines the geographical area associated with the address.
    /// </summary>
    /// <remarks>
    ///     The bounding box is represented by a <see cref="MapBoundingBox" /> object, which specifies
    ///     the northeast and southwest corners of the rectangular area. This property is useful for
    ///     geospatial operations, such as determining the coverage area of the address.
    /// </remarks>
    public MapBoundingBox BoundingBox { get; set; }
}