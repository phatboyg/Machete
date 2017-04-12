namespace Machete
{
    /// <summary>
    /// Format a value as text, if possible
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public interface IValueFormatter<in TValue>
    {
        /// <summary>
        /// Try to convert the value to a string
        /// </summary>
        /// <param name="value">The input value</param>
        /// <param name="text">The formatted text</param>
        /// <returns></returns>
        bool TryGetString(Value<TValue> value, out string text);
    }
}