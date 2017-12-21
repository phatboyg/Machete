namespace Machete
{
    using System;


    public interface ValueInfo
    {
        /// <summary>
        /// The value type
        /// </summary>
        Type ValueType { get; }

        /// <summary>
        /// True if the value is required
        /// </summary>
        bool IsRequired { get; }

        /// <summary>
        /// The position of the value in the entity's text representation
        /// </summary>
        int Position { get; }

        /// <summary>
        /// The minimum length of the value's text representation
        /// </summary>
        int MinLength { get; }

        /// <summary>
        /// The maximum length of the value's text representation
        /// </summary>
        int MaxLength { get; }

        /// <summary>
        /// The value formatting options
        /// </summary>
        FormatOptions Formatting { get; }
    }
}