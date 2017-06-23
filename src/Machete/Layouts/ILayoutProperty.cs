namespace Machete.Layouts
{
    using Matches;


    /// <summary>
    /// Write the property to the entity
    /// </summary>
    /// <typeparam name="TLayout">The entity type</typeparam>
    /// <typeparam name="TSchema">The schema type</typeparam>
    public interface ILayoutProperty<in TLayout, TSchema>
        where TLayout : Layout
        where TSchema : Entity
    {
        Parser<TSchema, LayoutMatch<TLayout>> CreateQuery(LayoutParserOptions options, IQueryBuilder<TSchema> queryBuilder);
    }
}