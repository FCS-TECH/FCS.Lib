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
///     It extends the <see cref="MapDefaults" /> class, inheriting common properties for Azure Map service requests.
/// </remarks>
public class MapFromPosition : MapDefaults
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