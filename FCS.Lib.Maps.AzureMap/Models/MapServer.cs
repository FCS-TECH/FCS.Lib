// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Maps.AzureMap
// // Filename         : MapServer.cs
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
///     Represents a server configuration for interacting with the Azure Maps API.
/// </summary>
/// <remarks>
///     This class encapsulates the necessary details for making requests to the Azure Maps API,
///     including the API host URL, API key, and version. It is used in conjunction with services
///     like <see cref="FCS.Lib.Maps.AzureMap.IAtlasRequestService" /> to perform geolocation operations.
/// </remarks>
public class MapServer
{
    /// <summary>
    ///     Gets or sets the base URL of the Azure Maps API host.
    /// </summary>
    /// <remarks>
    ///     This property defines the root endpoint for Azure Maps API requests.
    ///     By default, it is set to "https://atlas.microsoft.com".
    /// </remarks>
    public string Host { get; set; } = "https://atlas.microsoft.com";

    /// <summary>
    ///     Gets or sets the API key used for authenticating requests to the Azure Map service.
    /// </summary>
    /// <remarks>
    ///     This property is required to authorize and interact with the Azure Map API.
    ///     Ensure that a valid subscription key is provided before making requests.
    /// </remarks>
    public string ApiKey { get; set; }

    /// <summary>
    ///     Gets or sets the version of the Azure Maps API to be used in requests.
    /// </summary>
    /// <remarks>
    ///     This property specifies the API version that will be appended as a query parameter
    ///     in requests to the Azure Maps API. The default value is "1.0".
    /// </remarks>
    public string ApiVersion { get; set; } = "1.0";
}