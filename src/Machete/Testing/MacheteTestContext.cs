namespace Machete.Testing
{
    public interface MacheteTestContext<TSchema>
        where TSchema : Entity
    {
        string NormalizeLineEndings(string content);

        IParser<TSchema> Parser { get; }
    }
}