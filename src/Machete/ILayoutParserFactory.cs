namespace Machete
{
    using System;


    public interface ILayoutParserFactory<out TLayout, TSchema> :
        ILayoutParserFactory
        where TLayout : Layout
        where TSchema : Entity
    {
        /// <summary>
        /// Create a parser for the layout using the <paramref name="queryBuilder"/>.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="queryBuilder"></param>
        /// <returns></returns>
        IParser<TSchema, TLayout> CreateParser(LayoutParserOptions options, IQueryBuilder<TSchema> queryBuilder);
    }


    public interface ILayoutParserFactory
    {
        Type LayoutType { get; }
    }
}