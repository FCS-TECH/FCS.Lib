// ***********************************************************************
// Assembly         : FCS.Lib.PepPol
// Filename         : PepPolEntity.cs
// Author           : Frede Hundewadt
// Created          : 2025 04 09 13:04
// 
// Last Modified By :
// Last Modified On : 2025 04 09 13:04
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

using System.Collections.Generic;

namespace FCS.Lib.PepPol.Models;

public class PepPolEntity
{
    public List<PepPolName> Name { get; set; } = [];
    public string CountryCode { get; set; } = "";
    public string RegDate { get; set; }
}