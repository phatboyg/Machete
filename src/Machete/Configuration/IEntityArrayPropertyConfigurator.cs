namespace Machete
{
    /// <summary>
    /// An entity value is a property of an entity that contains another entity
    /// </summary>
    /// <typeparam name="TEntityValue">The entity value type</typeparam>
    public interface IEntityArrayPropertyConfigurator<out TEntityValue> :
        IPropertyArrayConfigurator<TEntityValue>
    {
    }
}