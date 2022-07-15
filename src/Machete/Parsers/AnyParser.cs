namespace Machete.Parsers
{
    /// <summary>
    /// Returns the next element.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AnyParser<T> :
        IParser<T, T>
    {
        public Result<Cursor<T>, T> Parse(Cursor<T> input)
        {
            if (!input.HasNext)
                return new Unmatched<Cursor<T>, T>(input);

            var next = input.Next();
            if (next.HasCurrent)
                return new Success<Cursor<T>, T>(next.Current, next);

            return new Unmatched<Cursor<T>, T>(input);
        }
    }


    public class AnyParserV2<T> :
        IParserV2<T, T>
    {
        public ValueResult<T, T> Parse(ValueCursor<T> input)
        {
            if (input.TryGetNext(out var next))
            {
                if (next.HasCurrent)
                    return new ValueResult<T, T>(next.Current, next);
            }

            return new ValueResult<T, T>(input);
        }
    }
}