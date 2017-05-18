namespace Machete.StructureConfiguration.Specifications
{
    using System.Collections.Generic;


    public class LayoutListLayoutParser<TLayout, TSchema, T> :
        Parser<TSchema, LayoutMatch<TLayout, TSchema>>
        where TSchema : Entity
        where T : Layout
        where TLayout : Layout
    {
        readonly Parser<TSchema, IReadOnlyList<T>> _parser;
        readonly ILayoutProperty<TLayout, TSchema, LayoutList<T>> _property;

        public LayoutListLayoutParser(Parser<TSchema, IReadOnlyList<T>> parser, ILayoutProperty<TLayout, TSchema, LayoutList<T>> property)
        {
            _parser = parser;
            _property = property;
        }

        public Result<Cursor<TSchema>, LayoutMatch<TLayout, TSchema>> Parse(Cursor<TSchema> input)
        {
            Result<Cursor<TSchema>, IReadOnlyList<T>> result = _parser.Parse(input);
            if (result.HasValue)
            {
                return new Success<Cursor<TSchema>, LayoutMatch<TLayout, TSchema>>(new LayoutListLayoutMatch<TLayout, TSchema, T>(_property, result.Value),
                    result.Next);
            }

            return new Unmatched<Cursor<TSchema>, LayoutMatch<TLayout, TSchema>>(input);
        }
    }
}