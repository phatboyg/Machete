namespace Machete
{
    using System;


    public interface IValue
    {
        /// <summary>
        /// The value type
        /// </summary>
        Type ValueType { get; }

        /// <summary>
        /// True if the value was present in the source, false if it was missing
        /// </summary>
        bool IsPresent { get; }

        /// <summary>
        /// True if there is a value, false if it is logical NULL
        /// </summary>
        bool HasValue { get; }

        /// <summary>
        /// The slice from which this value was extracted
        /// </summary>
        TextSlice Slice { get; }
    }
}