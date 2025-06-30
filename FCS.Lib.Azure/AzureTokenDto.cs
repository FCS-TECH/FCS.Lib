// ***********************************************************************
// Assembly         : Inno.Business
// Filename         : AzureTokenDto.cs
// Author           : Frede Hundewadt
// Created          : 2023 12 05 09:34
// 
// Last Modified By : root
// Last Modified On : 2024 04 11 12:59
// ***********************************************************************
// <copyright company="FCS">
//     Copyright (C) 2023-2024 FCS Frede's Computer Service.
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

using System.Text.Json.Serialization;

namespace Inno.Business.Azure
{
    public class AzureTokenDto
    {
        [JsonPropertyName("token_type")] public string TokenType { get; set; }
        [JsonPropertyName("expires_in")] public long ExpiresIn { get; set; }
        [JsonPropertyName("ext_expires_in")] public long ExtExpiresIn { get; set; }
        [JsonPropertyName("access_token")] public string AccessToken { get; set; }
    }
}