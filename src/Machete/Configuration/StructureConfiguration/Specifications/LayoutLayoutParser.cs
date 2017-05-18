namespace Machete.StructureConfiguration.Specifications
{
    public class LayoutLayoutParser<TLayout, TSchema, T> :
        Parser<TSchema, LayoutMatch<TLayout, TSchema>>
        where TSchema : Entity
        where T : Layout
        where TLayout : Layout
    {
        readonly Parser<TSchema, T> _parser;
        readonly ILayoutProperty<TLayout, TSchema, Layout<T>> _property;

        public LayoutLayoutParser(Parser<TSchema, T> parser, ILayoutProperty<TLayout, TSchema, Layout<T>> property)
        {
            _parser = parser;
            _property = property;
        }

        public Result<Cursor<TSchema>, LayoutMatch<TLayout, TSchema>> Parse(Cursor<TSchema> input)
        {
            Result<Cursor<TSchema>, T> result = _parser.Parse(input);
            if (result.HasValue)
            {
                return new Success<Cursor<TSchema>, LayoutMatch<TLayout, TSchema>>(new LayoutLayoutMatch<TLayout, TSchema, T>(_property, result.Value),
                    result.Next);
            }

            return new Unmatched<Cursor<TSchema>, LayoutMatch<TLayout, TSchema>>(input);
        }
    }
}