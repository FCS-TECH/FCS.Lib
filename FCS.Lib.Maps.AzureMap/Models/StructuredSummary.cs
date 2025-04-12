// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Maps.AzureMap
// // Filename         : StructuredSummary.cs
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
///     Represents a summary of a structured query performed using Azure Map services.
/// </summary>
/// <remarks>
///     This class encapsulates metadata about a structured query, including details such as
///     the query string, query type, execution time, and the number of results.
///     It is used as part of the Azure Map models to provide insights into the query's
///     execution and its results.
/// </remarks>
public class StructuredSummary
{
    /// <summary>
    ///     Gets or sets the query string used in the structured summary.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the query.
    /// </value>
    public string Query { get; set; } = "";

    /// <summary>
    ///     Gets or sets the type of the query executed.
    /// </summary>
    /// <remarks>
    ///     This property represents the classification or category of the query,
    ///     which can be used to determine the nature or intent of the query.
    /// </remarks>
    public string QueryType { get; set; } = "";

    /// <summary>
    ///     Gets or sets the time taken to execute the query, measured in milliseconds.
    /// </summary>
    /// <value>
    ///     The time, in milliseconds, that the query took to complete.
    /// </value>
    public int QueryTime { get; set; }

    /// <summary>
    ///     Gets or sets the number of results returned by the query.
    /// </summary>
    /// <value>
    ///     The total count of results matching the query.
    /// </value>
    public int NumResults { get; set; }

    /// <summary>
    ///     Gets or sets the offset value used for paginated results.
    /// </summary>
    /// <remarks>
    ///     This property indicates the starting point for retrieving a subset of results
    ///     in a paginated query. It is typically used to skip a specified number of results.
    /// </remarks>
    public int Offset { get; set; }

    /// <summary>
    ///     Gets or sets the total number of results returned by the query.
    /// </summary>
    /// <value>
    ///     The total count of results matching the query criteria.
    /// </value>
    public int TotalResults { get; set; }

    /// <summary>
    ///     Gets or sets the level of fuzziness applied to the query.
    /// </summary>
    /// <remarks>
    ///     Fuzziness determines the degree of approximation allowed in the query matching process.
    ///     A higher value indicates a greater tolerance for variations or inaccuracies in the query.
    /// </remarks>
    public int FuzzyLevel { get; set; }
}