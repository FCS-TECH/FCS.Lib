// ***********************************************************************
// Assembly         : Inno.Azure
// Filename         : AzureTokenFetcher.cs
// Author           : Frede Hundewadt
// Created          : 2025 03 05 08:03
// 
// Last Modified By :
// Last Modified On : 2025 03 06 10:03
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

using System.Threading.Tasks;
using Inno.Business.Abstractions;
using Inno.Business.Azure;
using Inno.Business.Models.Common;

namespace Inno.Api.Azure;

public class AzureTokenFetcher(AzureAuthStore config) : IAzureTokenFetcher
{
    public async Task<AzureToken> FetchAzureToken()
    {
        var result = await AzureTokenHttpRequest.RequestTokenAsync(config).ConfigureAwait(true);
        return !result.IsSuccessStatusCode
            ? new AzureToken { Expires = -1 }
            : new AzureTokenMapper().MapAzureToken(result.Message);
    }
}