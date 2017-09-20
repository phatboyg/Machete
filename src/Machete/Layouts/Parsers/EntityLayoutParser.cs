namespace Machete.Layouts.Parsers
{
    using Matches;


    public class EntityLayoutParser<TLayout, TSchema, TEntity> :
        Parser<TSchema, LayoutMatch<TLayout>>
        where TSchema : Entity
        where TEntity : TSchema
        where TLayout : Layout
    {
        readonly Parser<TSchema, TEntity> _parser;
        readonly ILayoutPropertyWriter<TLayout, Entity<TEntity>> _property;

        public EntityLayoutParser(Parser<TSchema, TEntity> parser, ILayoutPropertyWriter<TLayout, Entity<TEntity>> property)
        {
            _parser = parser;
            _property = property;
        }

        public Result<Cursor<TSchema>, LayoutMatch<TLayout>> Parse(Cursor<TSchema> input)
        {
            Result<Cursor<TSchema>, TEntity> result = _parser.Parse(input);
            if (result.HasResult)
            {
                return new Success<Cursor<TSchema>, LayoutMatch<TLayout>>(new EntityLayoutMatch<TLayout, TEntity>(_property, result.Result),
                    result.Next);
            }

            return new Unmatched<Cursor<TSchema>, LayoutMatch<TLayout>>(input);
        }
    }
}