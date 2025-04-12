// ***********************************************************************
// Assembly         : FCS.Lib.PepPol
// Filename         : PepPolResponse.cs
// Author           : Frede Hundewadt
// Created          : 2025 04 09 12:04
// 
// Last Modified By :
// Last Modified On : 2025 04 09 13:04
// ***********************************************************************
// <copyright company="FCS">
//     Copyright (C) 2025-2025 FCS Frede's Computer Service.
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU Affero General Public License as
//     published by the Free Software Foundation, either version 3 of the
//     License, or (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU Affero General Public License for more details.
// 
//     You should have received a copy of the GNU Affero General Public License
//     along with this program.  If not, see [https://www.gnu.org/licenses]
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using Newtonsoft.Json;

namespace FCS.Lib.PepPol.Models;

public class PepPolResponse
{
    public string Version { get; set; } = "";

    [JsonProperty("total-result-count")] public int TotalResultCount { get; set; }

    [JsonProperty("used-result-count")] public int UsedResultCount { get; set; }

    [JsonProperty("result-page-index")] public int ResultPageIndex { get; set; }

    [JsonProperty("result-page-count")] public int ResultPageCount { get; set; }

    [JsonProperty("first-result-index")] public int FirstResultIndex { get; set; }

    [JsonProperty("last-result-index")] public int LastResultIndex { get; set; }

    [JsonProperty("query-terms")] public string QueryTerms { get; set; } = "";

    [JsonProperty("creation-dt")] public string CreationDt { get; set; } = "";

    [JsonProperty("matches")] public List<PepPolMatch> Matches { get; set; } = [];
}