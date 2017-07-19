namespace Machete
{
    public interface SchemaInfo<TSchema>
        where TSchema : Entity
    {
        ISchema<TSchema> Schema { get; }
    }
}