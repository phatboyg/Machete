namespace Machete.TypeSelectors
{
    public class TrieValueEntitySelector :
        ITrieValueEntitySelector
    {
        public int Position { get; }
        public string Key { get; }

        public TrieValueEntitySelector(int position, string key)
        {
            Position = position;
            Key = key;
        }

        public bool SelectEntity(TextSlice slice, out EntityInfo entityInfo)
        {
            entityInfo = default;
            return false;
        }

        public bool SelectEntity<T>(T entity, out EntityInfo entityInfo)
        {
            entityInfo = default;
            return false;
        }
    }
}