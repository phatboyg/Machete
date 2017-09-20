namespace Machete.Layouts.Parsers
{
    using System.Collections.Generic;
    using Matches;


    public class EntityListLayoutParser<TLayout, TSchema, TEntity> :
        Parser<TSchema, LayoutMatch<TLayout>>
        where TSchema : Entity
        where TEntity : TSchema
        where TLayout : Layout
    {
        readonly Parser<TSchema, IReadOnlyList<TEntity>> _parser;
        readonly ILayoutPropertyWriter<TLayout, EntityList<TEntity>> _property;

        public EntityListLayoutParser(Parser<TSchema, IReadOnlyList<TEntity>> parser, ILayoutPropertyWriter<TLayout, EntityList<TEntity>> property)
        {
            _parser = parser;
            _property = property;
        }

        public Result<Cursor<TSchema>, LayoutMatch<TLayout>> Parse(Cursor<TSchema> input)
        {
            Result<Cursor<TSchema>, IReadOnlyList<TEntity>> result = _parser.Parse(input);
            if (result.HasResult)
            {
                return new Success<Cursor<TSchema>, LayoutMatch<TLayout>>(new EntityListLayoutMatch<TLayout, TEntity>(_property, result.Result),
                    result.Next);
            }

            return new Unmatched<Cursor<TSchema>, LayoutMatch<TLayout>>(input);
        }
    }
}