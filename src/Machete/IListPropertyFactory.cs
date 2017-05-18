namespace Machete
{
    public interface IListPropertyFactory<in T, out TProperty>
    {
        TProperty CreateProperty();
        TProperty CreateProperty(T value);
    }
}