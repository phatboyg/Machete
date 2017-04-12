namespace Machete.TypeSelectors
{
    using System;
    using Internals.Algorithms;


    public class TrieEntityTypeSelectorFactory :
        IEntityTypeSelectorFactory
    {
        readonly Trie<EntityType> _entityTypes;
        readonly int _position;

        public TrieEntityTypeSelectorFactory(int position)
        {
            _position = position;
            _entityTypes = new Trie<EntityType>();
        }

        public void Add(EntityType entityType)
        {
            var trieSelector = entityType.EntityTypeSelector as ITrieValueEntityTypeSelector;
            if (trieSelector != null && trieSelector.Position == _position)
            {
                _entityTypes.Add(trieSelector.Key, entityType);
            }
            else if (entityType.EntityTypeSelector != null)
            {
                throw new NotImplementedException("Need to add subsequent selectors to a not found list");
            }
        }

        public IEntityTypeSelector Build()
        {
            return new TrieEntityTypeSelector(_position, _entityTypes);
        }
    }
}