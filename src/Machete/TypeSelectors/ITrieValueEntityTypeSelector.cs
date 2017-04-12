namespace Machete.TypeSelectors
{
    public interface ITrieValueEntityTypeSelector :
        IEntityTypeSelector
    {
        int Position { get; }
        string Key { get; }
    }
}