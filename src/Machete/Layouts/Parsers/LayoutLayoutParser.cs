namespace Machete.Layouts.Parsers
{
    using Matches;


    public class LayoutLayoutParser<TLayout, TSchema, T> :
        Parser<TSchema, LayoutMatch<TLayout>>
        where TSchema : Entity
        where T : Layout
        where TLayout : Layout
    {
        readonly Parser<TSchema, T> _parser;
        readonly ILayoutPropertyWriter<TLayout, Layout<T>> _property;

        public LayoutLayoutParser(Parser<TSchema, T> parser, ILayoutPropertyWriter<TLayout, Layout<T>> property)
        {
            _parser = parser;
            _property = property;
        }

        public Result<Cursor<TSchema>, LayoutMatch<TLayout>> Parse(Cursor<TSchema> input)
        {
            Result<Cursor<TSchema>, T> result = _parser.Parse(input);
            if (result.HasValue)
            {
                return new Success<Cursor<TSchema>, LayoutMatch<TLayout>>(new LayoutLayoutMatch<TLayout, TSchema, T>(_property, result.Value),
                    result.Next);
            }

            return new Unmatched<Cursor<TSchema>, LayoutMatch<TLayout>>(input);
        }
    }
}