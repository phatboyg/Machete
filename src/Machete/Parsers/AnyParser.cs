namespace Machete.Parsers
{
    public class AnyParser<T> :
        IParser<T, T>
    {
        public Result<Cursor<T>, T> Parse(Cursor<T> input)
        {
            if (input.HasNext)
            {
                var next = input.Next();
                if (next.HasCurrent)
                {
                    return new Success<Cursor<T>, T>(next.Current, next);
                }
            }

            return new Unmatched<Cursor<T>, T>(input);
        }
    }
}