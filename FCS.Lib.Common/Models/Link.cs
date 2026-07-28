// ***********************************************************************
// Filename         : Link.cs
// Author           : Frede Hundewadt
// Created          : 2025 10 14 10:10
// 
// Last Modified By :
// Last Modified On : 2026 07 22 15:25
// ***********************************************************************
// <copyright company="FCS">
//     Copyright (C) 2025-2026 FCS Frede's Computer Service.
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

namespace FCS.Lib.Common.Models;

/// <summary>
/// Represents a hyperlink with a URL.
/// </summary>
/// <remarks>
/// This class is used to encapsulate a hyperlink, typically for navigation purposes.
/// It contains the URL of the link as its primary property.
/// </remarks>
public class Link
{
    /// <summary>
    /// Gets or sets the URL of the link.
    /// </summary>
    /// <value>
    /// A <see cref="string"/> representing the hyperlink reference (Href) of the link.
    /// </value>
    /// <remarks>
    /// This property typically contains the URL pointing to a resource or endpoint.
    /// </remarks>
    public string Href { get; set; } = string.Empty;
}