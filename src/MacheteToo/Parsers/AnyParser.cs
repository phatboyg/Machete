namespace MacheteToo.Parsers;

public class AnyParser<T> :
    IParser<T, T>
{
    public CursorResult<T, T> Parse(Cursor<T> input)
    {
        if (input.TryGetNext(out var next) && next.Current != null)
            return new CursorResult<T, T>(next.Current, next);

        return new CursorResult<T, T>(input);
    }
}