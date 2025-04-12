// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Maps.AzureMap
// // Filename         : MapResultFromAddress.cs
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
///     Represents the result of a structured address search using the Azure Map service.
/// </summary>
/// <remarks>
///     This class encapsulates the summary and results of a structured address query.
///     The <see cref="Summary" /> property provides metadata about the query, such as the number of results and query
///     details.
///     The <see cref="Results" /> property contains a list of detailed results for the address search.
/// </remarks>
public class MapResultFromAddress
{
    /// <summary>
    ///     Gets or sets the summary of the structured address query.
    /// </summary>
    /// <remarks>
    ///     The summary provides metadata about the query, including details such as the query string,
    ///     query type, execution time, number of results, and other related information.
    /// </remarks>
    public StructuredSummary Summary { get; set; }

    /// <summary>
    ///     Gets or sets the list of detailed results for the structured address search.
    /// </summary>
    /// <remarks>
    ///     Each result in the list provides detailed information about a specific match found during the address query.
    ///     This includes properties such as the type, ID, score, address, geographical position, viewport, and entry points.
    /// </remarks>
    public List<StructuredResult> Results { get; set; }
}