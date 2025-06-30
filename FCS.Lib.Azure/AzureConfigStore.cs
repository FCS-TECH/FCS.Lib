// ***********************************************************************
// Assembly         : Inno.Business
// Filename         : AzureConfigStore.cs
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

namespace Inno.Business.Azure;

public class AzureConfigStore(
    string baseUrl,
    string tenantId,
    string environment,
    string apiPublisher,
    string apiGroup,
    string apiVersion,
    string ledgerId,
    string oDataVersion)
{
    protected string BaseUrl { get; set; } = baseUrl;
    protected string TenantId { get; } = tenantId;
    protected string Environment { get; set; } = environment;
    protected string ApiPublisher { get; set; } = apiPublisher;
    protected string ApiGroup { get; set; } = apiGroup;
    protected string ApiVersion { get; set; } = apiVersion;
    protected string LedgerId { get; set; } = ledgerId;
    protected string ODataVersion { get; set; } = oDataVersion;


    public string ClientApiEndpoint()
    {
        return $"{BaseUrl}/{TenantId}/{Environment}/api/{ApiPublisher}/{ApiGroup}/{ApiVersion}/companies({LedgerId})";
    }


    public string ClientOAuthEndpoint()
    {
        return $"{BaseUrl}/{TenantId}/{Environment}/{ODataVersion}/Company('{LedgerId}')";
    }
}