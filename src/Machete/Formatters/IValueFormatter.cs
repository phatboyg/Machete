namespace Machete.Formatters
{
    /// <summary>
    /// Format a value as text, if possible
    /// </summary>
    /// <typeparam name="TValue">The value type</typeparam>
    public interface IValueFormatter<in TValue>
    {
        void Format(FormatValueContext<TValue> context);
    }
}