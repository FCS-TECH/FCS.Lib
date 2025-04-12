namespace FCS.Lib.Gls.Track.Models
{
    /// <summary>
    /// Represents a reference associated with a GLS tracking entity, containing details such as type, name, and value.
    /// </summary>
    public class Reference
    {
        /// <summary>
        /// Gets or sets the type of the reference.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> representing the type of the reference.
        /// </value>
        public string Type { get; set; } = "";
        /// <summary>
        /// Gets or sets the name of the reference.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> representing the name associated with the reference.
        /// </value>
        public string Name { get; set; } = "";
        /// <summary>
        /// Gets or sets the value associated with the reference.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> representing the value of the reference.
        /// </value>
        public string Value { get; set; } = "";
    }
}