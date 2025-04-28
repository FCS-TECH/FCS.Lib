// ***********************************************************************
// Assembly         : FCS.Lib.BrReg
// Filename         : BrLinks.cs
// Author           : Frede Hundewadt
// Created          : 2025 04 15 06:04
// 
// Last Modified By :
// Last Modified On : 2025 04 15 06:04
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

using FCS.Lib.Common.Models;

namespace FCS.Lib.BrReg.Models;

/// <summary>
/// Represents a collection of navigational links, typically used for pagination or resource navigation.
/// </summary>
/// <remarks>
/// This class is part of the FCS.Lib.BrReg.Models namespace and provides properties for accessing
/// various types of links, such as the first, self, next, and last links.
/// </remarks>
public class BrLinks
{
    /// <summary>
    /// Gets or sets the link to the first resource in a collection.
    /// </summary>
    /// <value>
    /// An instance of the <see cref="Link"/> class representing the first navigational link.
    /// </value>
    /// <remarks>
    /// This property is typically used in scenarios involving pagination or navigation
    /// within a collection of resources.
    /// </remarks>
    public Link First { get; set; }
    
    /// <summary>
    /// Gets or sets the link to the current resource.
    /// </summary>
    /// <value>
    /// A <see cref="Link"/> object representing the URL of the current resource.
    /// </value>
    /// <remarks>
    /// This property is typically used to provide a self-referential link in navigational structures.
    /// </remarks>
    public Link Self { get; set; }
    
    /// <summary>
    /// Gets or sets the hyperlink to the next resource in a sequence.
    /// </summary>
    /// <value>
    /// A <see cref="Link"/> object representing the URL of the next resource.
    /// </value>
    /// <remarks>
    /// This property is typically used for pagination or navigating to the next set of resources.
    /// </remarks>
    public Link Next { get; set; }
    
    /// <summary>
    /// Gets or sets the hyperlink representing the last navigational link in a collection.
    /// </summary>
    /// <value>
    /// A <see cref="Link"/> object that encapsulates the URL of the last link, typically used for pagination or navigation purposes.
    /// </value>
    /// <remarks>
    /// This property is part of the <see cref="BrLinks"/> class and provides access to the last link in a sequence of navigational links.
    /// </remarks>
    public Link Last { get; set; }
}