// ***********************************************************************
// Assembly         : Inno.Business
// Filename         : AzureAuthStore.cs
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

namespace Inno.Business.Azure;

public class AzureAuthStore(
    string azureLoginUrl,
    string azureOAuthEndpoint,
    string azureTenantId,
    string azureClientId,
    string azureGrantType,
    string azureSecret,
    string azureLoginScope)
{
    protected string AzureLoginUrl { get; set; } = azureLoginUrl;
    protected string AzureOAuthEndpoint { get; set; } = azureOAuthEndpoint;
    protected string AzureTenantId { get; } = azureTenantId;
    public string AzureClientId { get; } = azureClientId;
    public string AzureGrantType { get; } = azureGrantType;
    public string AzureSecret { get; } = azureSecret;
    public string AzureLoginScope { get; } = azureLoginScope;


    public string AzureTokenEndpoint()
    {
        return $"{AzureLoginUrl}/{AzureTenantId}/{AzureOAuthEndpoint}";
    }
}