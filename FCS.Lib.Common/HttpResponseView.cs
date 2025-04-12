// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Common
// // Filename         : HttpResponseView.cs
// // Created          : 2025-01-03 14:01
// // Last Modified By : dev
// // Last Modified On : 2025-01-04 11:01
// // ***********************************************************************
// // <copyright company="Frede Hundewadt">
// //     Copyright (C) 2010-2025 Frede Hundewadt
// //     This program is free software: you can redistribute it and/or modify
// //     it under the terms of the GNU Affero General Public License as
// //     published by the Free Software Foundation, either version 3 of the
// //     License, or (at your option) any later version.
// //
// //     This program is distributed in the hope that it will be useful,
// //     but WITHOUT ANY WARRANTY; without even the implied warranty of
// //     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// //     GNU Affero General Public License for more details.
// //
// //     You should have received a copy of the GNU Affero General Public License
// //     along with this program.  If not, see [https://www.gnu.org/licenses]
// // </copyright>
// // <summary></summary>
// // ***********************************************************************

using System.Net;

namespace FCS.Lib.Common;

/// <summary>
///     Represents the details of an HTTP response, including the status code, success status, and response message.
/// </summary>
/// <remarks>
///     This class is commonly used to encapsulate the result of HTTP requests, providing a structured view of the
///     response.
/// </remarks>
public class HttpResponseView
{
    /// <summary>
    ///     Gets or sets the HTTP status code of the response.
    /// </summary>
    /// <value>
    ///     An <see cref="HttpStatusCode" /> representing the status code of the HTTP response.
    /// </value>
    public HttpStatusCode Code { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether the HTTP response was successful.
    /// </summary>
    /// <remarks>
    ///     This property reflects the success status of the HTTP response based on the HTTP status code.
    ///     A response is considered successful if its status code is in the range of 200-299.
    /// </remarks>
    public bool IsSuccessStatusCode { get; set; }

    /// <summary>
    ///     Gets or sets the message associated with the HTTP response.
    /// </summary>
    /// <remarks>
    ///     This property typically contains additional information or details about the HTTP response,
    ///     such as error messages or descriptive text.
    /// </remarks>
    public string Message { get; set; } = "";
}