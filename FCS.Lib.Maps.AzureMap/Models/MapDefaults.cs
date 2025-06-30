namespace FCS.Lib.Maps.AzureMap.Models;

/// <summary>
///     Represents the default configuration for Azure Map service requests.
/// </summary>
/// <remarks>
///     This class provides base properties such as <c>Action</c>, <c>Format</c>, and <c>Scope</c>,
///     which are commonly used in Azure Map service requests. It serves as a foundation for more
///     specific request models.
/// </remarks>
public class MapDefaults
{
    /// <summary>
    ///     Gets or sets the action to be performed in the Azure Maps API request.
    /// </summary>
    /// <remarks>
    ///     The default value is "search". This property determines the type of operation
    ///     to execute, such as searching for locations or performing reverse geocoding.
    /// </remarks>
    public string Action { get; set; } = "search";

    /// <summary>
    ///     Gets or sets the format of the response returned by the Azure Maps API.
    /// </summary>
    /// <value>
    ///     The format of the response, typically "json".
    /// </value>
    /// <remarks>
    ///     This property determines the format in which the Azure Maps API returns data.
    ///     Commonly used formats include "json".
    /// </remarks>
    public string Format { get; set; } = "json";

    /// <summary>
    ///     Gets or sets the scope of the search operation.
    /// </summary>
    /// <remarks>
    ///     The scope determines the specific area or type of data to be included in the search.
    ///     Common values include "address" for address-based searches.
    /// </remarks>
    public string Scope { get; set; } = "address";
}