namespace Machete.Internals.Reflection
{
    public interface IWriteProperty<in TEntity, in TProperty> :
        IWriteProperty<TEntity>
    {
        void Set(TEntity entity, TProperty value);
    }


    public interface IWriteProperty<in TEntity>
    {
    }
}