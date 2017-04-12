namespace Machete.TypeSelectors
{
    public class TrieValueEntityTypeSelector :
        ITrieValueEntityTypeSelector
    {
        public int Position { get; }
        public string Key { get; }

        public TrieValueEntityTypeSelector(int position, string key)
        {
            Position = position;
            Key = key;
        }

        public bool SelectEntityType(TextSlice slice, out EntityType entityType)
        {
            throw new System.NotImplementedException();
        }

        public bool SelectEntityType<T>(T entity, out EntityType entityType)
        {
            throw new System.NotImplementedException();
        }
    }
}