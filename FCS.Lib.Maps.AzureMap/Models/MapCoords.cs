// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Maps.AzureMap
// // Filename         : MapCoords.cs
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
///     Represents geographical coordinates with latitude and longitude values.
/// </summary>
/// <remarks>
///     This class is used to define a specific location on a map by specifying
///     its latitude (<see cref="Lat" />) and longitude (<see cref="Lon" />).
///     It is commonly utilized in mapping-related operations and models.
/// </remarks>
public class MapCoords
{
    /// <summary>
    ///     Gets or sets the latitude of the geographical coordinate.
    /// </summary>
    /// <remarks>
    ///     This property represents the north-south position of a point on the Earth's surface,
    ///     measured in degrees. It is used in conjunction with <see cref="Lon" /> to define
    ///     a specific location on a map.
    /// </remarks>
    public double Lat { get; set; }

    /// <summary>
    ///     Gets or sets the longitude of the geographical coordinate.
    /// </summary>
    /// <remarks>
    ///     This property represents the east-west position of a point on the Earth's surface,
    ///     measured in degrees. It is used in conjunction with <see cref="Lat" /> to define
    ///     a specific location on a map.
    /// </remarks>
    public double Lon { get; set; }
}