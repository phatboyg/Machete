namespace Machete
{
    public interface IQueryBuilder<TSchema>
        where TSchema : Entity
    {
        IQueryParser<TSchema, T> Select<T>()
            where T : TSchema;

        IQueryParser<TSchema, T> Except<T, TExcept>()
            where T : TSchema
            where TExcept : T;

        IQueryParser<TSchema, T> Except<T, TExcept>(IParser<TSchema, TExcept> except)
            where T : TSchema
            where TExcept : T;

        IQueryParser<TSchema, T> Layout<T>(LayoutParserOptions options = LayoutParserOptions.None)
            where T : Layout;
    }
}