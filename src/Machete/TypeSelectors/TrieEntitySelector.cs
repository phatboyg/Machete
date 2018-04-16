namespace Machete.TypeSelectors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Internals.Algorithms;


    public class TrieEntitySelector :
        IEntitySelector
    {
        readonly int _position;
        readonly Trie<EntityInfo> _entityKeys;
        readonly IDictionary<Type, EntityInfo> _entityTypes;

        public TrieEntitySelector(int position, Trie<EntityInfo> entityKeys)
        {
            _position = position;
            _entityKeys = entityKeys;

            _entityTypes = entityKeys.Match().GetMatches().ToDictionary(x => x.EntityType);
        }

        public bool SelectEntity(TextSlice slice, out EntityInfo entityInfo)
        {
            if (slice.TryGetSlice(_position, out var selectorSlice))
            {
                var matcher = _entityKeys.Match(selectorSlice.SourceText, selectorSlice.SourceSpan);
                if (matcher.IsExactMatch)
                {
                    entityInfo = matcher.ExactMatch;
                    return true;
                }
            }

            entityInfo = default;
            return false;
        }

        public bool SelectEntity<T>(T entity, out EntityInfo entityInfo)
        {
            return _entityTypes.TryGetValue(typeof(T), out entityInfo);
        }
    }
}