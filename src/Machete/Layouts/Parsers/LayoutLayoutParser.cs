namespace Machete.Layouts.Parsers
{
    using Matches;


    public class LayoutLayoutParser<TLayout, TSchema, T> :
        IParser<TSchema, LayoutMatch<TLayout>>
        where TSchema : Entity
        where T : Layout
        where TLayout : Layout
    {
        readonly IParser<TSchema, T> _parser;
        readonly ILayoutPropertyWriter<TLayout, Layout<T>> _property;

        public LayoutLayoutParser(IParser<TSchema, T> parser, ILayoutPropertyWriter<TLayout, Layout<T>> property)
        {
            _parser = parser;
            _property = property;
        }

        public Result<Cursor<TSchema>, LayoutMatch<TLayout>> Parse(Cursor<TSchema> input)
        {
            Result<Cursor<TSchema>, T> result = _parser.Parse(input);
            if (result.HasResult)
            {
                return new Success<Cursor<TSchema>, LayoutMatch<TLayout>>(
                    new LayoutLayoutMatch<TLayout, TSchema, T>(_property, result.Result), result.Next);
            }

            return new Unmatched<Cursor<TSchema>, LayoutMatch<TLayout>>(input);
        }
    }
}