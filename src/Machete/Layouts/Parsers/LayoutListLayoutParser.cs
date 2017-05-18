namespace Machete.Layouts.Parsers
{
    using System.Collections.Generic;
    using Matches;


    public class LayoutListLayoutParser<TLayout, TSchema, T> :
        Parser<TSchema, LayoutMatch<TLayout>>
        where TSchema : Entity
        where T : Layout
        where TLayout : Layout
    {
        readonly Parser<TSchema, IReadOnlyList<T>> _parser;
        readonly ILayoutPropertyWriter<TLayout, LayoutList<T>> _property;

        public LayoutListLayoutParser(Parser<TSchema, IReadOnlyList<T>> parser, ILayoutPropertyWriter<TLayout, LayoutList<T>> property)
        {
            _parser = parser;
            _property = property;
        }

        public Result<Cursor<TSchema>, LayoutMatch<TLayout>> Parse(Cursor<TSchema> input)
        {
            Result<Cursor<TSchema>, IReadOnlyList<T>> result = _parser.Parse(input);
            if (result.HasValue)
            {
                return new Success<Cursor<TSchema>, LayoutMatch<TLayout>>(new LayoutListLayoutMatch<TLayout, T>(_property, result.Value),
                    result.Next);
            }

            return new Unmatched<Cursor<TSchema>, LayoutMatch<TLayout>>(input);
        }
    }
}