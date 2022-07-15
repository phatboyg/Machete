namespace MacheteToo;

public static class CursorExtensions
{
    public static CursorResult<T, TResult> Execute<T, TResult>(this IParser<T, TResult> parser, ReadOnlyMemory<T> memory)
    {
        var cursor = new Cursor<T>(memory.Span);

        return parser.Parse(cursor);
    }
}