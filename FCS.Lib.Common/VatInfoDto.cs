// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Common
// // Filename         : VatInfoDto.cs
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

using System.Collections.Generic;

namespace FCS.Lib.Common;

/// <summary>
///     Represents VAT-related information for a company, including its VAT number,
///     name, address, and associated states and life cycles.
/// </summary>
/// <remarks>
///     This data transfer object (DTO) is used to encapsulate VAT-specific details
///     such as the company's VAT number, name, address, city, zip code, and other
///     related information. It also includes collections of VAT states and life cycles
///     to provide a comprehensive representation of the company's VAT status over time.
/// </remarks>
public class VatInfoDto
{
    /// <summary>
    ///     Gets or sets the VAT (Value Added Tax) number associated with the entity.
    /// </summary>
    /// <remarks>
    ///     The VAT number is used for tax identification purposes.
    /// </remarks>
    public string VatNumber { get; set; } = "";

    /// <summary>
    ///     Gets or sets the name of the entity associated with the VAT information.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the name of the entity.
    /// </value>
    public string Name { get; set; } = "";

    /// <summary>
    ///     Gets or sets the care-of name (CoName) associated with the company's address.
    /// </summary>
    /// <remarks>
    ///     This property represents the care-of name, which is typically used to specify
    ///     an additional name or entity associated with the company's address for mailing
    ///     or identification purposes.
    /// </remarks>
    public string CoName { get; set; } = "";

    /// <summary>
    ///     Gets or sets the address associated with the VAT information.
    /// </summary>
    /// <value>
    ///     A string representing the address. Defaults to an empty string if not set.
    /// </value>
    public string Address { get; set; } = "";

    /// <summary>
    ///     Gets or sets the name of the city associated with the VAT information.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the city name. Defaults to an empty string.
    /// </value>
    public string City { get; set; } = "";

    /// <summary>
    ///     Gets or sets the postal code associated with the VAT information.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the postal code.
    /// </value>
    public string ZipCode { get; set; } = "";

    /// <summary>
    ///     Gets or sets the collection of VAT states associated with the entity.
    /// </summary>
    /// <remarks>
    ///     Each <see cref="VatState" /> in the collection represents a specific state of VAT information,
    ///     including details such as the state type and the last update timestamp.
    /// </remarks>
    public List<VatState> States { get; set; } = [];

    /// <summary>
    ///     Gets or sets the collection of life cycles associated with the VAT information.
    /// </summary>
    /// <value>
    ///     A list of <see cref="LifeCycle" /> objects representing the life cycles.
    /// </value>
    public List<LifeCycle> LifeCycles { get; set; } = [];

    /// <summary>
    ///     Gets or sets the date when the request was made.
    /// </summary>
    /// <remarks>
    ///     The format of the date is typically "yyyy-MM-dd" or "yyyy-MM-dd HH:mm",
    ///     depending on the context in which it is used.
    /// </remarks>
    public string RequestDate { get; set; }
}