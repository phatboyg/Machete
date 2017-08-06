namespace Machete.SchemaConfiguration
{
    /// <summary>
    /// An entity value is a property of an entity that contains another entity
    /// </summary>
    /// <typeparam name="TEntityValue">The entity value type</typeparam>
    public interface IEntityListPropertyConfigurator<out TEntityValue> :
        IPropertyListConfigurator<TEntityValue>
    {
    }
}