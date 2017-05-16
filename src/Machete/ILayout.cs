namespace Machete
{
    using System;


    public interface ILayout<out TLayout, TSchema> :
        ILayout<TSchema>
        where TLayout : Layout
        where TSchema : Entity
    {
        /// <summary>
        /// Create a query parser which can be used to query a parsed document to match the template
        /// </summary>
        /// <param name="options"></param>
        /// <param name="queryBuilder"></param>
        /// <returns></returns>
        Parser<TSchema, TLayout> CreateQuery(TemplateQueryOptions options, IQueryBuilder<TSchema> queryBuilder);
    }


    public interface ILayout<out TSchema> :
        ILayout
        where TSchema : Entity
    {
        Type LayoutType { get; }

        Type ImplementationType { get; }
    }


    public interface ILayout
    {
    }
}