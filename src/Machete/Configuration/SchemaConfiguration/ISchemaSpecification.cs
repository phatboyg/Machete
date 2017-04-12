namespace Machete.SchemaConfiguration
{
    using Configuration;


    public interface ISchemaSpecification<out TEntity> :
        ISpecification
        where TEntity : Entity
    {
        /// <summary>
        /// Apply the specification to the builder
        /// </summary>
        /// <param name="builder"></param>
        void Apply(ISchemaBuilder<TEntity> builder);
    }
}