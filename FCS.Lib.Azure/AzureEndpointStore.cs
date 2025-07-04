﻿// ***********************************************************************
// Assembly         : Inno.Business
// Filename         : AzureEndpointStore.cs
// Author           : Frede Hundewadt
// Created          : 2024 03 01 07:49
// 
// Last Modified By : root
// Last Modified On : 2024 04 11 12:59
// ***********************************************************************
// <copyright company="FCS">
//     Copyright (C) 2024-2024 FCS Frede's Computer Service.
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

namespace Inno.Business.Azure
{
    public class AzureEndpointStore
    {
        public string ApiCatalogItem { get; set; } = "";
        public string ApiCatalogPrice { get; set; } = "";
        public string ApiCompany { get; set; } = "";
        public string ApiCrMemoHead { get; set; } = "";
        public string ApiCrMemoLine { get; set; } = "";
        public string ApiInvoiceHead { get; set; } = "";
        public string ApiInvoiceLine { get; set; } = "";
        public string ApiSalesRep { get; set; } = "";
        public string ApiSalesHead { get; set; } = "";
        public string ApiSalesLine { get; set; } = "";
        public string OauthCustomer { get; set; } = "";
    }
}