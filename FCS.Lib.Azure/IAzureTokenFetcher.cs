// ***********************************************************************
// Assembly         : Inno.Business
// Filename         : IAzureTokenFetcher.cs
// Author           : Frede Hundewadt
// Created          : 2025 03 27 13:03
// 
// Last Modified By :
// Last Modified On : 2025 04 08 08:04
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

namespace Inno.Business.Azure;

/// <summary>
///     Defines a contract for fetching Azure authentication tokens.
/// </summary>
/// <remarks>
///     Implementations of this interface are responsible for retrieving Azure tokens
///     that include details such as the token type, access token, and expiration information.
/// </remarks>
public interface IAzureTokenFetcher
{
    /// <summary>
    ///     Fetches an Azure authentication token asynchronously.
    /// </summary>
    /// <remarks>
    ///     This method retrieves an <see cref="AzureToken" /> object, which contains
    ///     details such as the token type, access token, and expiration information.
    /// </remarks>
    /// <returns>
    ///     A task that represents the asynchronous operation. The task result contains
    ///     an <see cref="AzureToken" /> object with the fetched token details.
    /// </returns>
    Task<AzureToken> FetchAzureToken();
}