namespace Machete
{
    public interface IQueryBuilder<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IQueryParser<TSchema, T> Select<T>()
            where T : TSchema;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TExcept"></typeparam>
        /// <returns></returns>
        IQueryParser<TSchema, T> Except<T, TExcept>()
            where T : TSchema
            where TExcept : T;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="except"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TExcept"></typeparam>
        /// <returns></returns>
        IQueryParser<TSchema, T> Except<T, TExcept>(IParser<TSchema, TExcept> except)
            where T : TSchema
            where TExcept : T;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IQueryParser<TSchema, T> Layout<T>(LayoutParserOptions options = LayoutParserOptions.None)
            where T : Layout;
    }
}