// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Maps.AzureMap
// // Filename         : StructuredResult.cs
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
///     Represents a structured result from Azure Map services, containing detailed information
///     about a specific location, including its type, identifier, score, address, geographical
///     coordinates, viewport, and entry points.
/// </summary>
/// <remarks>
///     This class is part of the Azure Map models and is used to encapsulate the result of
///     mapping or geolocation queries. It provides a comprehensive representation of a location,
///     combining address details, positional data, and additional metadata.
/// </remarks>
public class StructuredResult
{
    /// <summary>
    ///     Gets or sets the type of the structured result, representing the category or classification
    ///     of the location (e.g., "Point of Interest", "Address", etc.).
    /// </summary>
    /// <remarks>
    ///     This property provides a textual description of the type of location represented by the
    ///     structured result. It is useful for distinguishing between different kinds of results
    ///     returned by Azure Map services.
    /// </remarks>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the unique identifier for the structured result.
    /// </summary>
    /// <remarks>
    ///     This property represents a unique string identifier associated with the specific
    ///     result from Azure Map services. It can be used to reference or distinguish
    ///     this result from others in a collection or dataset.
    /// </remarks>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the relevance score of the result, indicating the confidence level
    ///     or accuracy of the match for the location query.
    /// </summary>
    /// <value>
    ///     A <see cref="double" /> representing the score, where higher values indicate
    ///     greater relevance or confidence in the result.
    /// </value>
    /// <remarks>
    ///     The score is typically used to rank or prioritize results in mapping or geolocation
    ///     queries, helping to determine the most relevant match.
    /// </remarks>
    public double Score { get; set; }

    /// <summary>
    ///     Gets or sets the detailed address information associated with the structured result.
    /// </summary>
    /// <remarks>
    ///     This property provides a comprehensive representation of the address, including components
    ///     such as country, subdivision, municipality, postal code, and street details. It is used
    ///     to describe the location in a structured and human-readable format.
    /// </remarks>
    public MapAddress Address { get; set; } = new();

    /// <summary>
    ///     Gets or sets the geographical coordinates of the location represented by this result.
    /// </summary>
    /// <remarks>
    ///     The <see cref="Position" /> property provides the latitude and longitude values
    ///     that define the precise geographical location of the result. This information
    ///     is essential for mapping and geolocation operations.
    /// </remarks>
    public MapCoords Position { get; set; } = new();

    /// <summary>
    ///     Gets or sets the viewport that defines the rectangular area on the map
    ///     encompassing the location represented by this structured result.
    /// </summary>
    /// <remarks>
    ///     The viewport is represented by the <see cref="MapViewPort" /> class, which specifies
    ///     the top-left and bottom-right coordinates of the area. This property is useful for
    ///     determining the visible region of the map that includes the location.
    /// </remarks>
    public MapViewPort ViewPort { get; set; } = new();

    /// <summary>
    ///     Gets or sets the list of entry points associated with the location.
    /// </summary>
    /// <remarks>
    ///     Entry points represent specific access points or locations related to the structured result.
    ///     Each entry point is described by its type and geographical position, providing detailed
    ///     information about how to access or interact with the location.
    /// </remarks>
    public List<MapEntryPoint> EntryPoints { get; set; } = [];
}