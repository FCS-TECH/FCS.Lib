// ***********************************************************************
// Assembly         : FCS.Lib.BrReg
// Filename         : BrPageInfo.cs
// Author           : Frede Hundewadt
// Created          : 2025 04 15 05:04
// 
// Last Modified By :
// Last Modified On : 2025 04 15 05:04
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

namespace FCS.Lib.BrReg.Models;

/// <summary>
/// Represents a page of data in the BrReg system, containing information about 
/// the size of the page, total elements, total pages, and the current page number.
/// </summary>
public class BrPageInfo
{
    /// <summary>
    /// Gets or sets the size of the page, indicating the number of elements contained in the page.
    /// </summary>
    /// <value>
    /// The size of the page.
    /// </value>
    public int Size { get; set; }
    
    /// <summary>
    /// Gets or sets the total number of elements available in the data set.
    /// </summary>
    /// <value>
    /// The total number of elements.
    /// </value>
    public int TotalElements { get; set; }
    
    /// <summary>
    /// Gets or sets the total number of pages available in the BrReg system.
    /// </summary>
    /// <value>
    /// The total number of pages, calculated based on the total elements and the size of each page.
    /// </value>
    public int TotalPages { get; set; }
    
    /// <summary>
    /// Gets or sets the current page number in the BrReg system.
    /// </summary>
    /// <value>
    /// The zero-based index of the current page.
    /// </value>
    public int Number { get; set; }
}