namespace FCS.Lib.Common.Models;

/// <summary>
/// Represents a hyperlink with a URL.
/// </summary>
/// <remarks>
/// This class is used to encapsulate a hyperlink, typically for navigation purposes.
/// It contains the URL of the link as its primary property.
/// </remarks>
public class Link
{
    /// <summary>
    /// Gets or sets the URL of the link.
    /// </summary>
    /// <value>
    /// A <see cref="string"/> representing the hyperlink reference (Href) of the link.
    /// </value>
    /// <remarks>
    /// This property typically contains the URL pointing to a resource or endpoint.
    /// </remarks>
    public string Href { get; set; } = "";
}