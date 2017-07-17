namespace Machete.TypeSelectors
{
    public interface IEntitySelectorFactory
    {
        /// <summary>
        /// Adds a key to the entity type selector
        /// </summary>
        /// <param name="entityInfo"></param>
        void Add(EntityInfo entityInfo);

        /// <summary>
        /// Build the entity type selector
        /// </summary>
        /// <returns></returns>
        IEntitySelector Build();
    }
}