// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Common
// // Filename         : TaxIdInfo.cs
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

using System;

namespace FCS.Lib.Common;

/// <summary>
///     Represents information about a tax identification entity, including its VAT number,
///     validity status, and other related details.
/// </summary>
/// <remarks>
///     This class is used to encapsulate tax-related information such as the entity's name,
///     VAT number, its validity, and whether the entity has ceased operations. It also tracks
///     the date when the information was requested.
/// </remarks>
public class TaxIdInfo
{
    /// <summary>
    ///     Gets or sets the name associated with the tax identification information.
    /// </summary>
    /// <value>
    ///     A <see cref="string" /> representing the name. Defaults to an empty string.
    /// </value>
    public string Name { get; set; } = "";

    /// <summary>
    ///     Gets or sets the VAT (Value Added Tax) number associated with the entity.
    /// </summary>
    /// <remarks>
    ///     The VAT number is used for tax identification purposes and may vary depending on the country.
    /// </remarks>
    public string VatNumber { get; set; } = "";

    /// <summary>
    ///     Gets or sets a value indicating whether the VAT number is valid.
    /// </summary>
    /// <value>
    ///     <c>true</c> if the VAT number is valid; otherwise, <c>false</c>.
    /// </value>
    public bool VatNumberValid { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether the entity associated with the tax identification
    ///     has ceased operations, such as being dissolved, under liquidation, or otherwise inactive.
    /// </summary>
    /// <remarks>
    ///     This property is used to determine the operational status of the entity. If set to <c>true</c>,
    ///     it indicates that the entity is no longer active.
    /// </remarks>
    public bool HasFolded { get; set; }

    /// <summary>
    ///     Gets or sets the date and time when the tax identification information was requested.
    /// </summary>
    /// <value>
    ///     A <see cref="DateTime" /> representing the timestamp of the request.
    /// </value>
    /// <remarks>
    ///     This property is used to track when the tax identification information was retrieved,
    ///     ensuring that the data is up-to-date and relevant.
    /// </remarks>
    public DateTime RequestDate { get; set; }
}