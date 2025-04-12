// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Maps.AzureMap
// // Filename         : MapBoundingBox.cs
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
///     Represents a bounding box on a map, defined by its northeast and southwest coordinates.
/// </summary>
/// <remarks>
///     This class is used to define a rectangular area on a map, typically for geospatial operations.
///     It includes properties for specifying the northeast and southwest corners of the bounding box,
///     as well as an optional entity associated with the bounding box.
/// </remarks>
public class MapBoundingBox
{
    /// <summary>
    ///     Gets or sets the northeast corner of the bounding box.
    /// </summary>
    /// <value>
    ///     A string representing the coordinates of the northeast corner, typically in latitude and longitude format.
    /// </value>
    /// <remarks>
    ///     The northeast corner defines the upper-right boundary of the bounding box on the map.
    /// </remarks>
    public string NorthEast { get; set; }

    /// <summary>
    ///     Gets or sets the southwest coordinate of the bounding box.
    /// </summary>
    /// <value>
    ///     A string representing the southwest corner of the bounding box, typically in a coordinate format such as latitude
    ///     and longitude.
    /// </value>
    /// <remarks>
    ///     This property defines one of the two corners that specify the boundaries of the map's bounding box.
    /// </remarks>
    public string SouthWest { get; set; }

    /// <summary>
    ///     Gets or sets the entity associated with the bounding box.
    /// </summary>
    /// <value>
    ///     A string representing the entity linked to this bounding box. This could be used to associate
    ///     metadata or additional context with the bounding box.
    /// </value>
    public string Entity { get; set; }
}