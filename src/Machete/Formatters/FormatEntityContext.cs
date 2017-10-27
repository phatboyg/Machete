namespace Machete.Formatters
{
    public interface FormatEntityContext<out TEntity> :
        FormatContext
        where TEntity : Entity
    {
        TEntity Entity { get; }
    }
}