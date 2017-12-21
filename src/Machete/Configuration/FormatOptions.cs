namespace Machete
{
    using System;


    /// <summary>
    /// Formatter options modify how the formatter treats the property when formatting the entity
    /// </summary>
    [Flags]
    public enum FormatOptions
    {
        /// <summary>
        /// Yeah, pretty obvious
        /// </summary>
        Default = 0,

        /// <summary>
        /// Do not format this property (typically used for internal calculated properties)
        /// </summary>
        Exclude = 1,
    }
}