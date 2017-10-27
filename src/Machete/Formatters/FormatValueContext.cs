namespace Machete.Formatters
{
    public interface FormatValueContext<out TValue> :
        FormatContext
    {
        Value<TValue> Value { get; }
    }
}