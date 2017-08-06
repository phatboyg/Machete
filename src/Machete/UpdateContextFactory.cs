namespace Machete
{
    public delegate TPayload UpdateContextFactory<TPayload>(TPayload existing)
        where TPayload : class;
}