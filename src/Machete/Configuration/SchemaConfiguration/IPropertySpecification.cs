namespace Machete.SchemaConfiguration
{
    public interface IPropertySpecification<in TEntity, out TSchema> :
        IEntityMapSpecification<TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        int Position { get; }

        bool Required { get; }

        int MinLength { get; }

        int MaxLength { get; }
    }
}