// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Maps.AzureMap
// // Filename         : MapViewPort.cs
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
///     Represents a viewport on a map, defined by its top-left and bottom-right coordinates.
/// </summary>
/// <remarks>
///     The <see cref="MapViewPort" /> class is used to specify a rectangular area on a map.
///     It includes the top-left point (<see cref="TopLefPoint" />) and the bottom-right point (
///     <see cref="BtmRightPoint" />),
///     both represented as instances of <see cref="MapCoords" />.
/// </remarks>
public class MapViewPort
{
    /// <summary>
    ///     Gets or sets the top-left point of the map viewport.
    /// </summary>
    /// <value>
    ///     An instance of <see cref="MapCoords" /> representing the geographical coordinates
    ///     of the top-left corner of the viewport.
    /// </value>
    /// <remarks>
    ///     This property is used to define the upper-left boundary of the rectangular area
    ///     represented by the <see cref="MapViewPort" />.
    /// </remarks>
    public MapCoords TopLefPoint { get; set; }

    /// <summary>
    ///     Gets or sets the bottom-right point of the map viewport.
    /// </summary>
    /// <value>
    ///     An instance of <see cref="MapCoords" /> representing the geographical coordinates
    ///     of the bottom-right corner of the viewport.
    /// </value>
    /// <remarks>
    ///     This property, along with <see cref="TopLefPoint" />, defines the rectangular area
    ///     of the map viewport.
    /// </remarks>
    public MapCoords BtmRightPoint { get; set; }
}