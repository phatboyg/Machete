namespace MacheteToo.Parsers;

public class WhereParser<TInput, TResult> :
    IParser<TInput, TResult>
{
    readonly Func<TResult, bool> _condition;
    readonly IParser<TInput, TResult> _parser;

    public WhereParser(IParser<TInput, TResult> parser, Func<TResult, bool> condition)
    {
        _parser = parser ?? throw new ArgumentNullException(nameof(parser));
        _condition = condition ?? throw new ArgumentNullException(nameof(condition));
    }

    public CursorResult<TInput, TResult> Parse(Cursor<TInput> input)
    {
        return _parser.Parse(input).Where(_condition);
    }
}