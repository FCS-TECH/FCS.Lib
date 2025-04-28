using System.Collections.Generic;
using Newtonsoft.Json;

namespace FCS.Lib.BrReg.Models;

/// <summary>
///     Represents a collection of entities retrieved from the Brønnøysund Register Center (Brønnøysundregistrene).
///     This class encapsulates a list of companies or other entities that match specific search criteria.
/// </summary>
/// <remarks>
///     The <see cref="EntityList" /> class is part of the domain model for interacting with
///     data from the Brønnøysund Register Center. It is used to encapsulate a collection of entities
///     returned as part of a search response.
/// </remarks>
public class EntityList
{
    /// <summary>
    ///     Gets or sets the list of companies retrieved from the Brønnøysund Register Center.
    /// </summary>
    /// <value>
    ///     A collection of <see cref="BrRegCompany" /> objects representing the companies.
    /// </value>
    /// <remarks>
    ///     This property corresponds to the "enheter" field in the JSON response from the Brønnøysund Register Center API.
    /// </remarks>
    [JsonProperty("enheter")]
    public IList<BrRegCompany> Entities { get; set; }
}