// ***********************************************************************
// Assembly         : FCS.Lib.PepPol
// Filename         : PepPolHttpRequest.cs
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

using System.Net.Http;
using System.Threading.Tasks;
using FCS.Lib.Common.Models;

namespace FCS.Lib.PepPol;

public class PepPolHttpRequest
{
    private const string PepPolRestApi = "https://directory.peppol.eu/search/1.0/json";

    public async Task<HttpResponseView> GetPepPolResponseJson(string countryCode, string searchFor)
    {
        var query = $"{PepPolRestApi}?country={countryCode}&q={searchFor}";
        using var client = new HttpClient();
        var response = await client.GetAsync(query).ConfigureAwait(true);

        return new HttpResponseView
        {
            Code = response.StatusCode,
            IsSuccessStatusCode = response.IsSuccessStatusCode,
            Message = await response.Content.ReadAsStringAsync()
        };
    }
}