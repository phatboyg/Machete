namespace Machete.Testing
{
    public interface IMacheteTestHarness<TSchema>
        where TSchema : Entity
    {
        ISchema<TSchema> Schema { get; }
        IEntityParser<TSchema> Parser { get; }
    }
}