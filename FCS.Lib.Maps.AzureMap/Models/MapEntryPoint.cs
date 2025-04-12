// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Maps.AzureMap
// // Filename         : MapEntryPoint.cs
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
///     Represents an entry point on a map, typically used to define specific access points or locations.
/// </summary>
/// <remarks>
///     This class is part of the Azure Map models and is utilized to describe entry points with a specific type
///     and geographical position. It is commonly used in conjunction with other mapping-related models, such as
///     <see cref="StructuredResult" />.
/// </remarks>
public class MapEntryPoint
{
    /// <summary>
    ///     Gets or sets the type of the map entry point.
    /// </summary>
    /// <remarks>
    ///     This property represents the classification or category of the entry point
    ///     on the map. It can be used to distinguish between different types of entry
    ///     points, such as entrances, exits, or other specific designations.
    /// </remarks>
    public string Type { get; set; }

    /// <summary>
    ///     Gets or sets the geographical coordinates of the map entry point.
    /// </summary>
    /// <value>
    ///     An instance of <see cref="MapCoords" /> representing the latitude and longitude
    ///     of the entry point on the map.
    /// </value>
    /// <remarks>
    ///     This property is used to define the specific location of the entry point
    ///     on a map, utilizing latitude and longitude values.
    /// </remarks>
    public MapCoords Position { get; set; }
}