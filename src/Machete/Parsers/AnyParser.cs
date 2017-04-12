namespace Machete.Parsers
{
    public class AnyParser<T> :
        Parser<T, T>
    {
        public Result<Cursor<T>, T> Parse(Cursor<T> input)
        {
            if (input.HasNext)
            {
                var next = input.Next();
                if (next.HasValue)
                {
                    return new Success<Cursor<T>, T>(next.Value, next);
                }
            }

            return new Unmatched<Cursor<T>, T>(input);
        }
    }
}