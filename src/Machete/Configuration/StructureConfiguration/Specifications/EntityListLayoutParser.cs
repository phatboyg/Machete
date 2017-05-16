namespace Machete.StructureConfiguration.Specifications
{
    using System.Collections.Generic;


    public class EntityListLayoutParser<TLayout, TSchema, TEntity> :
        Parser<TSchema, LayoutMatch<TLayout, TSchema>>
        where TSchema : Entity
        where TEntity : TSchema
        where TLayout : Layout
    {
        readonly Parser<TSchema, IReadOnlyList<TEntity>> _parser;
        readonly ILayoutProperty<TLayout, TSchema, EntityList<TEntity>> _property;

        public EntityListLayoutParser(Parser<TSchema, TEntity> parser, ILayoutProperty<TLayout, TSchema, EntityList<TEntity>> property)
        {
            _parser = parser.OneOrMore();
            _property = property;
        }

        public Result<Cursor<TSchema>, LayoutMatch<TLayout, TSchema>> Parse(Cursor<TSchema> input)
        {
            Result<Cursor<TSchema>, IReadOnlyList<TEntity>> result = _parser.Parse(input);
            if (result.HasValue)
            {
                return new Success<Cursor<TSchema>, LayoutMatch<TLayout, TSchema>>(new EntityListLayoutMatch<TLayout, TSchema, TEntity>(_property, result.Value),
                    result.Next);
            }

            return new Unmatched<Cursor<TSchema>, LayoutMatch<TLayout, TSchema>>(input);
        }
    }
}