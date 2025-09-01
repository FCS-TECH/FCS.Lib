namespace FCS.Lib.Maps.AzureMap.Models;

/// <summary>
///     Represents a structured request model for mapping an address using the Azure Map service.
/// </summary>
/// <remarks>
///     This class extends the <see cref="MapDefaults" /> class, inheriting default properties such as
///     <c>Action</c>, <c>Format</c>, and <c>Scope</c>. It provides additional properties specific to
///     address-based mapping, such as country code, postal code, street name, and street number.
/// </remarks>
public class MapFromAddress : MapDefaults
{
    /// <summary>
    ///     Gets or sets the country code associated with the address.
    /// </summary>
    /// <remarks>
    ///     This property is used to specify the country code in ISO 3166-1 alpha-2 format.
    ///     It is utilized in geolocation requests to identify the country of the address.
    /// </remarks>
    public string CountryCode { get; set; } = "";

    /// <summary>
    ///     Gets or sets the postal code associated with the address.
    /// </summary>
    /// <remarks>
    ///     This property is used to specify the postal code for geolocation requests.
    ///     It is included as part of the structured address information sent to the mapping service.
    /// </remarks>
    public string PostalCode { get; set; } = "";

    /// <summary>
    ///     Gets or sets the name of the street in the address.
    /// </summary>
    /// <remarks>
    ///     This property represents the street name component of an address.
    ///     It is used alongside <see cref="HouseNumber" /> and other address details
    ///     to create a complete and structured address.
    /// </remarks>
    public string StreetName { get; set; } = "";

    /// <summary>
    ///     Gets or sets the street number of the address.
    /// </summary>
    /// <remarks>
    ///     This property represents the specific number assigned to a building or location on a street.
    ///     It is used in conjunction with <see cref="StreetName" /> and other address components
    ///     to form a complete and structured address.
    /// </remarks>
    public string HouseNumber { get; set; } = "";

    /// <summary>
    ///     Gets or sets the type of the address mapping request.
    /// </summary>
    /// <remarks>
    ///     This property specifies the type of the request for address mapping.
    ///     The default value is <c>"structured"</c>, which indicates that the request
    ///     uses structured address components such as country code, postal code, street name, and street number.
    /// </remarks>
    public string Type { get; set; } = "structured";
}