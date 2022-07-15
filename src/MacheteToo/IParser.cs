namespace MacheteToo;

public interface IParser<TInput, TResult>
{
    CursorResult<TInput, TResult> Parse(Cursor<TInput> input);
}