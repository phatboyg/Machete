namespace Machete
{
    public interface FormatValueContext<out TValue> :
        FormatContext
    {
        Value<TValue> Value { get; }
    }
}