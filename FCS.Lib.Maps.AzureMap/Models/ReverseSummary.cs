// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Maps.AzureMap
// // Filename         : ReverseSummary.cs
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

public class ReverseSummary
{
    /// <summary>
    ///     Gets or sets the time taken to execute the query, measured in milliseconds.
    /// </summary>
    public int QueryTime { get; set; }

    /// <summary>
    ///     Gets or sets the number of results returned by the reverse geocoding operation.
    /// </summary>
    /// <value>
    ///     The total count of results obtained from the reverse geocoding query.
    /// </value>
    public int NumResults { get; set; }
}