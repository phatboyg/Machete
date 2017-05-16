namespace Machete.StructureConfiguration.Specifications
{
    public class EntityLayoutParser<TLayout, TSchema, TEntity> :
        Parser<TSchema, LayoutMatch<TLayout, TSchema>>
        where TSchema : Entity
        where TEntity : TSchema
        where TLayout : Layout
    {
        readonly Parser<TSchema, TEntity> _parser;
        readonly ILayoutProperty<TLayout, TSchema, Entity<TEntity>> _property;

        public EntityLayoutParser(Parser<TSchema, TEntity> parser, ILayoutProperty<TLayout, TSchema, Entity<TEntity>> property)
        {
            _parser = parser;
            _property = property;
        }

        public Result<Cursor<TSchema>, LayoutMatch<TLayout, TSchema>> Parse(Cursor<TSchema> input)
        {
            Result<Cursor<TSchema>, TEntity> result = _parser.Parse(input);
            if (result.HasValue)
            {
                return new Success<Cursor<TSchema>, LayoutMatch<TLayout, TSchema>>(new EntityLayoutMatch<TLayout, TSchema, TEntity>(_property, result.Value),
                    result.Next);
            }

            return new Unmatched<Cursor<TSchema>, LayoutMatch<TLayout, TSchema>>(input);
        }
    }
}