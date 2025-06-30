// ***********************************************************************
//  Solution         : Inno.Api.v2
//  Assembly         : FCS.Lib.Common
//  Filename         : BasicAuth.cs
//  Created          : 2025-01-28 07:01
//  Last Modified By : dev
//  Last Modified On : 2025-02-07 08:02
//  ***********************************************************************
//  <copyright company="Frede Hundewadt">
//      Copyright (C) 2010-2025 Frede Hundewadt
//      This program is free software: you can redistribute it and/or modify
//      it under the terms of the GNU Affero General Public License as
//      published by the Free Software Foundation, either version 3 of the
//      License, or (at your option) any later version.
// 
//      This program is distributed in the hope that it will be useful,
//      but WITHOUT ANY WARRANTY; without even the implied warranty of
//      MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//      GNU Affero General Public License for more details.
// 
//      You should have received a copy of the GNU Affero General Public License
//      along with this program.  If not, see [https://www.gnu.org/licenses]
//  </copyright>
//  <summary></summary>
//  ***********************************************************************

using System;
using System.Text;

namespace FCS.Lib.Common.Models;

/// <summary>
///     Represents a utility class for handling basic authentication credentials.
/// </summary>
/// <remarks>
///     This class provides functionality to generate a Base64-encoded string
///     for use in HTTP Basic Authentication headers. It ensures that both the
///     username and password are provided during initialization.
/// </remarks>
public class BasicAuth(string username, string password)
{
    private readonly string _username = username ?? throw new ArgumentNullException(nameof(username));
    private readonly string _password = password ?? throw new ArgumentNullException(nameof(password));

    /// <summary>
    ///     Generates a Base64-encoded string for basic authentication credentials.
    /// </summary>
    /// <returns>
    ///     A Base64-encoded string in the format "username:password".
    /// </returns>
    /// <exception cref="ArgumentNullException">
    ///     Thrown if the username or password is null during the initialization of the <see cref="BasicAuth" /> class.
    /// </exception>
    public string GetBasicAuth()
    {
        var plainTextBytes = Encoding.UTF8.GetBytes($"{_username}:{_password}");
        return Convert.ToBase64String(plainTextBytes);
    }
}