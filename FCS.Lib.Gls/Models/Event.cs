// ***********************************************************************
//  Solution         : Inno.Api.v2
//  Assembly         : FCS.Lib.Gls.Track
//  Filename         : Event.cs
//  Created          : 2025-01-25 10:01
//  Last Modified By : dev
//  Last Modified On : 2025-01-25 10:01
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

namespace FCS.Lib.Gls.Track.Models
{
    /// <summary>
    ///     Represents an event in the GLS tracking system, providing details such as timestamp, description, location,
    ///     country, and code.
    /// </summary>
    public class Event
    {
        /// <summary>
        ///     Gets or sets the timestamp of the event.
        /// </summary>
        /// <value>
        ///     A string representing the timestamp of the event in a specific format.
        /// </value>
        public string Timestamp { get; set; } = "";

        /// <summary>
        ///     Gets or sets the description of the event.
        /// </summary>
        /// <value>
        ///     A string representing the details or summary of the event.
        /// </value>
        public string Description { get; set; } = "";

        /// <summary>
        ///     Gets or sets the location associated with the event.
        /// </summary>
        /// <value>
        ///     A <see cref="string" /> representing the location where the event occurred.
        /// </value>
        public string Location { get; set; } = "";

        /// <summary>
        ///     Gets or sets the country associated with the event.
        /// </summary>
        /// <value>
        ///     A string representing the country where the event occurred.
        /// </value>
        public string Country { get; set; } = "";

        /// <summary>
        ///     Gets or sets the unique code associated with the event.
        /// </summary>
        /// <value>
        ///     A <see cref="string" /> representing the event code.
        /// </value>
        public string Code { get; set; } = "";
    }
}