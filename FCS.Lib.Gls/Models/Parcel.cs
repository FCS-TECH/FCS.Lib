// ***********************************************************************
//  Solution         : Inno.Api.v2
//  Assembly         : FCS.Lib.Gls.Track
//  Filename         : Parcel.cs
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

using System.Collections.Generic;

namespace FCS.Lib.Gls.Track.Models
{
    /// <summary>
    ///     Represents a parcel in the GLS tracking system, containing details such as timestamp, status, tracking ID,
    ///     associated references, and tracking events.
    /// </summary>
    public class Parcel
    {
        /// <summary>
        ///     Gets or sets the timestamp indicating when the parcel information was last updated.
        /// </summary>
        /// <remarks>
        ///     The timestamp is represented as a string and typically follows a standard date and time format.
        /// </remarks>
        public string Timestamp { get; set; } = "";

        /// <summary>
        ///     Gets or sets the current status of the parcel in the GLS tracking system.
        /// </summary>
        /// <remarks>
        ///     The status provides information about the parcel's current state or progress
        ///     within the tracking process, such as "In Transit," "Delivered," or "Pending."
        /// </remarks>
        public string Status { get; set; } = "";

        /// <summary>
        ///     Gets or sets the unique identifier for tracking a parcel in the GLS system.
        /// </summary>
        /// <remarks>
        ///     This property is used to uniquely identify and retrieve tracking information
        ///     for a specific parcel within the GLS tracking system.
        /// </remarks>
        public string TrackId { get; set; } = "";

        /// <summary>
        ///     Gets or sets the list of references associated with the parcel.
        ///     Each reference provides additional details, such as type, name, and value,
        ///     to help identify or categorize the parcel within the GLS tracking system.
        /// </summary>
        public List<Reference> References { get; set; } = new List<Reference>();

        /// <summary>
        ///     Gets or sets the list of events associated with the parcel.
        ///     Each event provides details such as timestamp, description, location, country, and code,
        ///     representing significant occurrences in the GLS tracking system.
        /// </summary>
        public List<Event> Events { get; set; } = new List<Event>();
    }
}