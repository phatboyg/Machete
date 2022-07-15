namespace MacheteToo;

public class SelectParser<TInput, T, TResult> :
    IParser<TInput, TResult>
{
    readonly IParser<TInput, T> _parser;
    readonly Func<T, TResult> _projector;

    public SelectParser(IParser<TInput, T> parser, Func<T, TResult> projector)
    {
        _parser = parser ?? throw new ArgumentNullException(nameof(parser));
        _projector = projector ?? throw new ArgumentNullException(nameof(projector));
    }

    public CursorResult<TInput, TResult> Parse(Cursor<TInput> input)
    {
        return _parser.Parse(input).Select(x => _projector(x));
    }
}