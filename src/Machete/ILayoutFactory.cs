namespace Machete
{
    public interface ILayoutFactory<out TLayout> :
        IEntityFactory
        where TLayout : Layout
    {
        /// <summary>
        /// Create an instance of the entity
        /// </summary>
        /// <returns></returns>
        TLayout Create();
    }
}