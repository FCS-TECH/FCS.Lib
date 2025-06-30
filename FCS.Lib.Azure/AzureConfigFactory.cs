// ***********************************************************************
// Assembly         : Inno.Api
// Filename         : AzureConfigFactory.cs
// Author           : Frede Hundewadt
// Created          : 2025 03 06 08:03
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

using System;
using System.IO;
using Inno.Api.Shared;
using Inno.Business.Abstractions;
using Inno.Business.Azure;
using Inno.Business.Models.Common;
using Inno.Business.Models.Settings;
using Newtonsoft.Json;

namespace Inno.Api.Azure;

public class AzureConfigFactory(string settingsFile) : IAzureConfigFactory
{
    private protected string SettingsFile = settingsFile;


    public AzureConfigStore GetAzureConfigStore(string country)
    {
        var jsonData = JsonDataReader.ReadFile(SettingsFile);
        var data = JsonConvert.DeserializeObject<AppSettings>(jsonData);
        switch (data)
        {
            case null:
                throw new FileNotFoundException(nameof(SettingsFile));
            default:
            {
                var ledgerId = country.ToLower().ToLowerInvariant() switch
                {
                    "dk" => data.AzureInnoLedgerDk,
                    "no" => data.AzureInnoLedgerNo,
                    "se" => data.AzureInnoLedgerSe,
                    _ => throw new ArgumentOutOfRangeException(nameof(country))
                };

                return new AzureConfigStore(
                    data.AzureBaseUrl,
                    data.AzureTenantId,
                    data.AzureInnoEnvironment,
                    data.AzureInnoPublisher,
                    data.AzureInnoGroup,
                    data.AzureInnoVersion,
                    ledgerId,
                    data.AzureODataVersion
                );
            }
        }
    }


    public AzureAuthStore GetAzureAuthStore()
    {
        var jsonData = JsonDataReader.ReadFile(SettingsFile);
        var data = JsonConvert.DeserializeObject<AppSettings>(jsonData);
        switch (data)
        {
            case null:
                throw new FileNotFoundException(nameof(SettingsFile));
            default:
            {
                var ac = new AzureAuthStore(
                    data.AzureLoginUrl, data.AzureOAuthEndpoint, data.AzureTenantId,
                    data.AzureClientId, data.AzureGrantType, data.AzureSecret, data.AzureLoginScope);

                return ac;
            }
        }
    }


    public AzureEndpointStore GetAzureEndpoints()
    {
        var jsonData = JsonDataReader.ReadFile(SettingsFile);
        var data = JsonConvert.DeserializeObject<AppSettings>(jsonData);

        return data switch
        {
            null => throw new FileNotFoundException(nameof(SettingsFile)),
            _ => new AzureEndpointStore
            {
                ApiCatalogItem = data.AzureApiEndpointCatalogItem,
                ApiCatalogPrice = data.AzureApiEndpointCatalogPrice,
                ApiCompany = data.AzureApiEndpointCompany,
                ApiCrMemoHead = data.AzureApiEndpointCrMemoHead,
                ApiCrMemoLine = data.AzureApiEndpointCrMemoLine,
                ApiInvoiceHead = data.AzureApiEndpointInvoiceHead,
                ApiInvoiceLine = data.AzureApiEndpointInvoiceLine,
                ApiSalesHead = data.AzureApiEndpointSalesHead,
                ApiSalesLine = data.AzureApiEndpointSalesLine,
                ApiSalesRep = data.AzureApiEndpointSalesRep,
                OauthCustomer = data.AzureOauthEndpointCustomer
            }
        };
    }
}