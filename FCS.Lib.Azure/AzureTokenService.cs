// ***********************************************************************
// Assembly         : Inno.Api
// Filename         : AzureTokenFetcher.cs
// Author           : Frede Hundewadt
// Created          : 2023 12 05 09:34
// 
// Last Modified By : root
// Last Modified On : 2024 05 05 14:47
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

using System;
using System.Threading.Tasks;
using FCS.Lib.Utility;
using Inno.Business.Azure;
using Inno.Business.Models.Common;

namespace Inno.Api.Azure
{
    public class AzureTokenService : IAzureTokenService, IDisposable
    {
        private const string SettingsFilename = "appsettings.json";
        private static IAzureTokenFetcher _tokenFetcher;
        private static AzureToken _azureToken;
        private static AzureAuthStore _authStore;


        /// <summary>
        ///     Get access token
        /// </summary>
        /// <returns>access token as async task</returns>
        public async Task<string> GetAccessToken()
        {
            _azureToken = await _tokenFetcher.FetchAzureToken().ConfigureAwait(true);

            return _azureToken.AccessToken;
        }


        /// <summary>
        ///     Return if token is valid
        /// </summary>
        /// <param name="timestamp"></param>
        /// <returns>true/false</returns>
        public bool TokenHasExpired(long timestamp)
        {
            return _azureToken.HasExpired(timestamp);
        }


        public bool TokenIsValid()
        {
            return !string.IsNullOrWhiteSpace(_azureToken.AccessToken) &&
                   !_azureToken.HasExpired(Transform.CurrentDateTimeToTimeStamp());
        }


        /// <summary>
        ///     Dispose
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }


        /// <summary>
        ///     Create a new access token
        /// </summary>
        /// <returns></returns>
        public static AzureTokenService Create()
        {
            _azureToken = new AzureToken
            {
                AccessToken = "", Expires = -1, TokenType = "Bearer"
            };

            var azureConfig = new AzureConfigFactory(SettingsFilename);

            _authStore = azureConfig.GetAzureAuthStore();

            _tokenFetcher = new AzureTokenFetcher(_authStore);

            return new AzureTokenService();
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
                // No unmanaged resources to clean up
                return;
            // Dispose managed resources
            _tokenFetcher = null;
            _azureToken = null;
            _authStore = null;
            
        }
    }
}