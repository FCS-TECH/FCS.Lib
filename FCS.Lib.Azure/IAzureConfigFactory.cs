// ***********************************************************************
// Assembly         : Inno.Business
// Filename         : IAzureConfigFactory.cs
// Author           : Frede Hundewadt
// Created          : 2025 03 27 13:03
// 
// Last Modified By :
// Last Modified On : 2025 04 08 08:04
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

namespace Inno.Business.Azure;

public interface IAzureConfigFactory
{
    /// <summary>
    ///     Retrieves the Azure configuration store for a specific country.
    /// </summary>
    /// <param name="country">
    ///     The country code or name for which the Azure configuration store is to be retrieved.
    /// </param>
    /// <returns>
    ///     An instance of <see cref="AzureConfigStore" /> containing the Azure configuration details
    ///     specific to the provided country.
    /// </returns>
    /// <exception cref="System.IO.FileNotFoundException">
    ///     Thrown when the settings file required to retrieve the configuration is not found.
    /// </exception>
    AzureConfigStore GetAzureConfigStore(string country);

    /// <summary>
    ///     Retrieves the Azure authentication configuration store.
    /// </summary>
    /// <returns>
    ///     An instance of <see cref="AzureAuthStore" /> containing Azure authentication parameters.
    /// </returns>
    /// <exception cref="System.IO.FileNotFoundException">
    ///     Thrown when the settings file required to retrieve the configuration is not found.
    /// </exception>
    AzureAuthStore GetAzureAuthStore();
}