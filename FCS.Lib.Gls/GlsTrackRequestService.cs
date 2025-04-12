// ***********************************************************************
// Assembly         : FCS.Lib.Gls.Track
// Filename         : GlsTrackRequestService.cs
// Author           : Frede Hundewadt
// Created          : 2025 01 26 08:01
// 
// Last Modified By :
// Last Modified On : 2025 01 28 08:01
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
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FCS.Lib.Gls.Track.Models;
using Newtonsoft.Json;
using NLog;

namespace FCS.Lib.Gls.Track;

public class GlsTrackRequestService : IGlsTrackRequestService
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    public async Task<Parcel> GetTrackingInfoAsync(
        string url, string authentication, string reference, string language)
    {
        if (string.IsNullOrWhiteSpace(url)) throw new ArgumentNullException(nameof(url));
        if (string.IsNullOrWhiteSpace(authentication)) throw new ArgumentNullException(nameof(authentication));
        if (string.IsNullOrWhiteSpace(reference)) throw new ArgumentNullException(nameof(reference));
        if (string.IsNullOrWhiteSpace(language)) throw new ArgumentNullException(nameof(language));

        using var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Basic", authentication);
        httpClient.DefaultRequestHeaders.Add("Accept-Language", language);

        var requestUrl = $"{url}/{reference}";

        HttpResponseMessage response;
        try
        {
            response = await httpClient.GetAsync(requestUrl);
        }
        catch (HttpRequestException ex)
        {
            Logger.Warn($"{ex}");
            return new Parcel();
        }

        if (!response.IsSuccessStatusCode)
        {
            Logger.Warn($"Invalid response from GLS tracking service: {response.StatusCode}");
            return new Parcel();
        }

        var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(true);

        try
        {
            // data is returned as a list
            // parse the list
            var data = JsonConvert.DeserializeObject<ParcelList>(responseContent);
            // because every parcel is unique only return first element
            return data.Parcels[0];
        }
        catch (JsonException ex)
        {
            Logger.Warn("Error occurred while processing the response content.", ex);
        }

        return new Parcel();
    }
}