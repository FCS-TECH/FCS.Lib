// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Maps.AzureMap
// // Filename         : MapResultFromPosition.cs
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
///     Represents the result of a reverse geocoding operation performed using the Azure Map service.
/// </summary>
/// <remarks>
///     This class contains the summary of the reverse geocoding query and a list of addresses
///     corresponding to the specified geographic position.
/// </remarks>
public class MapResultFromPosition
{
    /// <summary>
    ///     Gets or sets the summary of the reverse geocoding operation.
    /// </summary>
    /// <remarks>
    ///     This property provides details about the reverse geocoding query,
    ///     such as the query execution time and the number of results returned.
    /// </remarks>
    public ReverseSummary Summary { get; set; }

    /// <summary>
    ///     Gets or sets the list of addresses corresponding to the specified geographic position.
    /// </summary>
    /// <remarks>
    ///     Each address in the list provides detailed information about a specific location,
    ///     including street details, postal code, and other geographic data.
    /// </remarks>
    public List<ReverseAddress> Addresses { get; set; }
}