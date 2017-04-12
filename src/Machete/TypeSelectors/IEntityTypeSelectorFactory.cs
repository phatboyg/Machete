namespace Machete.TypeSelectors
{
    public interface IEntityTypeSelectorFactory
    {
        /// <summary>
        /// Adds a key to the entity type selector
        /// </summary>
        /// <param name="entityType"></param>
        void Add(EntityType entityType);

        /// <summary>
        /// Build the entity type selector
        /// </summary>
        /// <returns></returns>
        IEntityTypeSelector Build();
    }
}