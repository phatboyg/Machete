namespace Machete.TypeSelectors
{
    public interface ITrieValueEntitySelector :
        IEntitySelector
    {
        int Position { get; }
        string Key { get; }
    }
}