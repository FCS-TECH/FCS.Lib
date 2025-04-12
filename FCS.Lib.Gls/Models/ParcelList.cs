// ***********************************************************************
//  Solution         : Gls.Track
//  Assembly         : FCS.Lib.Gls.Track
//  Filename         : ParcelList.cs
//  Created          : 2025-01-26 12:01
//  Last Modified By : dev
//  Last Modified On : 2025-01-26 12:01
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

using System.Collections.Generic;

namespace FCS.Lib.Gls.Track.Models;

public class ParcelList
{
    public List<Parcel> Parcels { get; set; } = [];
}