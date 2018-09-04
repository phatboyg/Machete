namespace Machete.SchemaConfiguration
{
    public delegate IParser<TSchema, TEntity> EntityLayoutCondition<TSchema, TEntity>(IQueryParser<TSchema, TEntity> parser)
        where TSchema : Entity
        where TEntity : TSchema;
}