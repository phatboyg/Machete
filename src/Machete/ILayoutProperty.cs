namespace Machete
{
    /// <summary>
    /// Write the property to the entity
    /// </summary>
    /// <typeparam name="TLayout">The entity type</typeparam>
    /// <typeparam name="TSchema">The schema type</typeparam>
    public interface ILayoutProperty<in TLayout, TSchema>
        where TLayout : Layout
        where TSchema : Entity
    {
        Parser<TSchema, LayoutMatch<TLayout, TSchema>> CreateQuery(TemplateQueryOptions options, IQueryBuilder<TSchema> queryBuilder);
    }


    public interface ILayoutProperty<in TLayout, in TSchema, in TProperty>
        where TLayout : Layout
        where TSchema : Entity
    {
        void SetProperty(TLayout layout, TProperty value);
    }
}