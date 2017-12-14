namespace Machete.QueryConfiguration.Builders
{
    using Internals.Extensions;
    using Parsers;


    public class QueryBuilder<TSchema> :
        IQueryBuilder<TSchema>
        where TSchema : Entity
    {
        readonly ISchema<TSchema> _schema;

        public QueryBuilder(ISchema<TSchema> schema)
        {
            _schema = schema;
        }

        public IQueryParser<TSchema, T> Select<T>()
            where T : TSchema
        {
            return new EntityQueryParser<TSchema, T>(new EntityParser<TSchema, T>(new AnyParser<TSchema>()));
        }

        IQueryParser<TSchema, T> IQueryBuilder<TSchema>.Except<T, TExcept>()
        {
            return new EntityQueryParser<TSchema, T>(new EntityParser<TSchema, T>(new AnyParser<TSchema>()).Except(new EntityParser<TSchema, TExcept>(new AnyParser<TSchema>())));
        }

        IQueryParser<TSchema, T> IQueryBuilder<TSchema>.Except<T, TExcept>(IParser<TSchema, TExcept> except)
        {
            return new EntityQueryParser<TSchema, T>(new EntityParser<TSchema, T>(new AnyParser<TSchema>()).Except(except));
        }

        public IQueryParser<TSchema, T> Layout<T>(LayoutParserOptions options = LayoutParserOptions.None)
            where T : Layout
        {
            if (_schema.TryGetLayout(out ILayoutParserFactory<T, TSchema> layout))
                return new EntityQueryParser<TSchema, T>(layout.CreateParser(options, this));

            throw new LayoutMissingException($"The layout was not found: {TypeCache<T>.ShortName}");
        }
    }
}