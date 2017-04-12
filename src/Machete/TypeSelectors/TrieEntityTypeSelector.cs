namespace Machete.TypeSelectors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Internals.Algorithms;


    public class TrieEntityTypeSelector :
        IEntityTypeSelector
    {
        readonly int _position;
        readonly Trie<EntityType> _entityKeys;
        readonly IDictionary<Type, EntityType> _entityTypes;

        public TrieEntityTypeSelector(int position, Trie<EntityType> entityKeys)
        {
            _position = position;
            _entityKeys = entityKeys;

            _entityTypes = entityKeys.Match().GetMatches().ToDictionary(x => x.EntityType);
        }

        public bool SelectEntityType(TextSlice slice, out EntityType entityType)
        {
            TextSlice selectorSlice;
            if (slice.TryGetSlice(_position, out selectorSlice))
            {
                string text = selectorSlice.Text.ToString();

                var matcher = _entityKeys.Match(text);
                if (matcher.IsExactMatch)
                {
                    entityType = matcher.ExactMatch;
                    return true;
                }
            }

            entityType = default(EntityType);
            return false;
        }

        public bool SelectEntityType<T>(T entity, out EntityType entityType)
        {
            return _entityTypes.TryGetValue(typeof(T), out entityType);
        }
    }
}