namespace Machete
{
    /// <summary>
    /// Convert an input value to the converter value type, if possible
    /// </summary>
    /// <typeparam name="TValue">The value type</typeparam>
    public interface IValueConverter<TValue>
    {
        /// <summary>
        /// Try to convert the value (if a conversion is possible)
        /// </summary>
        /// <param name="slice">The source fragment of the value</param>
        /// <param name="convertedValue">The converted value</param>
        /// <returns>True if the value was converted, otherwise false</returns>
        bool TryConvert(TextSlice slice, out Value<TValue> convertedValue);
    }
}