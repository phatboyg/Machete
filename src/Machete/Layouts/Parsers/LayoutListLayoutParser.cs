namespace Machete.Layouts.Parsers
{
    using System.Collections.Generic;
    using Matches;


    public class LayoutListLayoutParser<TLayout, TSchema, T> :
        IParser<TSchema, LayoutMatch<TLayout>>
        where TSchema : Entity
        where T : Layout
        where TLayout : Layout
    {
        readonly IParser<TSchema, IReadOnlyList<T>> _parser;
        readonly ILayoutPropertyWriter<TLayout, LayoutList<T>> _property;

        public LayoutListLayoutParser(IParser<TSchema, IReadOnlyList<T>> parser, ILayoutPropertyWriter<TLayout, LayoutList<T>> property)
        {
            _parser = parser;
            _property = property;
        }

        public Result<Cursor<TSchema>, LayoutMatch<TLayout>> Parse(Cursor<TSchema> input)
        {
            Result<Cursor<TSchema>, IReadOnlyList<T>> result = _parser.Parse(input);
            if (result.HasResult)
            {
                return new Success<Cursor<TSchema>, LayoutMatch<TLayout>>(new LayoutListLayoutMatch<TLayout, T>(_property, result.Result),
                    result.Next);
            }

            return new Unmatched<Cursor<TSchema>, LayoutMatch<TLayout>>(input);
        }
    }
}