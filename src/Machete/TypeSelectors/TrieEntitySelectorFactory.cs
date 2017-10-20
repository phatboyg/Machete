namespace Machete.TypeSelectors
{
    using System;
    using Internals.Algorithms;


    public class TrieEntitySelectorFactory :
        IEntitySelectorFactory
    {
        readonly Trie<EntityInfo> _entityTypes;
        readonly int _position;

        public TrieEntitySelectorFactory(int position)
        {
            _position = position;
            _entityTypes = new Trie<EntityInfo>();
        }

        public void Add(EntityInfo entityInfo)
        {
            if (entityInfo.EntitySelector is ITrieValueEntitySelector trieSelector && trieSelector.Position == _position)
            {
                _entityTypes.Add(trieSelector.Key, entityInfo);
            }
            else if (entityInfo.EntitySelector != null)
            {
                throw new NotImplementedException("Need to add subsequent selectors to a not found list");
            }
        }

        public IEntitySelector Build()
        {
            return new TrieEntitySelector(_position, _entityTypes);
        }
    }
}