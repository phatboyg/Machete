namespace Machete
{
    public delegate TContext UpdateContextFactory<TContext>(TContext existing)
        where TContext : class;
}