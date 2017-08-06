namespace Machete
{
    public delegate TContext ContextFactory<out TContext>()
        where TContext : class;
}