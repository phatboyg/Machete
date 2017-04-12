namespace Machete.Internals.Algorithms
{
    public class Trie<T>
    {
        readonly TrieNode<T> _root;

        public Trie()
        {
            _root = new TrieNode<T>(null, '\0');
        }

        public void Add(string key, T value)
        {
            TrieNode<T> node = _root;
            foreach (char c in key)
                node = node[c];

            node.Value = value;
        }

        public void Remove(string key)
        {
            TrieNode<T> node = _root;
            foreach (char c in key)
                node = node[c];

            node.RemoveValue();

            while (node != _root && !node.IsTerminal && node.ChildCount == 0)
            {
                char previousKey = node.Key;
                node = node.Parent;
                node.Remove(previousKey);
            }
        }

        public PrefixMatcher<T> Match()
        {
            return new PrefixMatcher<T>(_root);
        }

        public PrefixMatcher<T> Match(string key)
        {
            var matcher = new PrefixMatcher<T>(_root);
            foreach (char c in key)
            {
                if (!matcher.Next(c))
                    break;
            }

            return matcher;
        }
    }
}