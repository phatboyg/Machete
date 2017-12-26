namespace Machete.Internals.Reflection
{
    public interface IReadProperty<in TEntity, out TProperty> :
        IReadProperty<TEntity>
    {
        TProperty Get(TEntity entity);
    }


    public interface IReadProperty<in TEntity>
    {
    }
}