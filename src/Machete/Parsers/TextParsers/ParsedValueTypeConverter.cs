namespace Machete.Parsers.TextParsers
{
    public delegate bool ParsedValueTypeConverter<T>(ParseText text, TextSpan span, out T value)
        where T : struct;
}