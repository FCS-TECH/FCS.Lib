// ***********************************************************************
// Assembly         : FCS.Lib.Gls.Track
// Filename         : IGlsTrackRequestService.cs
// Author           : Frede Hundewadt
// Created          : 2025 01 25 10:01
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
using System.Threading.Tasks;
using FCS.Lib.Gls.Track.Models;

namespace FCS.Lib.Gls.Track;

public interface IGlsTrackRequestService
{
    /// <summary>
    ///     Retrieves tracking information for a specified parcel from the GLS tracking system.
    /// </summary>
    /// <param name="url">
    ///     The URL of the GLS tracking service endpoint.
    /// </param>
    /// <param name="authentication"></param>
    /// <param name="reference"></param>
    /// <param name="language">
    ///     The language code specifying the preferred language for the tracking information.
    /// </param>
    /// <returns>
    ///     A <see cref="Parcel" /> object containing detailed tracking information for the specified parcel.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    ///     Thrown if any of the required parameters are null.
    /// </exception>
    /// <exception cref="HttpRequestException">
    ///     Thrown if there is an issue with the HTTP request to the GLS tracking service.
    /// </exception>
    /// <exception cref="InvalidOperationException">
    ///     Thrown if the response from the GLS tracking service is invalid or cannot be processed.
    /// </exception>
    Task<Parcel> GetTrackingInfoAsync(string url, string authentication, string reference, string language);
}