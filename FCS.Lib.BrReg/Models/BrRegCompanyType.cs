// ***********************************************************************
// Assembly         : FCS.Lib.BrReg
// Filename         : BrRegCompanyType.cs
// Author           : Frede Hundewadt
// Created          : 2025 04 09 13:04
// 
// Last Modified By :
// Last Modified On : 2025 04 10 12:04
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
///     Represents a company type in the Brønnøysund Register Center (Brønnøysundregistrene).
///     This class provides details about the type of organization, including its code, description,
///     and whether it is obsolete.
/// </summary>
/// <remarks>
///     https://data.brreg.no/enhetsregisteret/api/dokumentasjon/no/index.html#tag/Enheter
/// </remarks>
public class BrRegCompanyType
{
    /// <summary>
    ///     Gets or sets the code representing the company type.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> containing the code for the company type.
    /// </value>
    public string Kode { get; set; } = "";

    /// <summary>
    ///     Gets or sets the description of the company type.
    /// </summary>
    /// <value>
    ///     A string representing the description of the company type.
    /// </value>
    public string Beskrivelse { get; set; } = "";

    /// <summary>
    ///     Gets or sets a value indicating whether the company type is obsolete.
    /// </summary>
    /// <value>
    ///     A string representing the obsolescence status of the company type.
    ///     If the value is not empty or null, the company type is considered obsolete.
    /// </value>
    public string Utgaatt { get; set; } = "";
}