namespace Machete.Testing
{
    public interface MacheteTestContext<TSchema>
        where TSchema : Entity
    {
        string NormalizeLineEndings(string content);

        ISchema<TSchema> Schema { get; }
        IParser<TSchema> Parser { get; }
    }
}