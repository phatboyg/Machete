namespace Machete.Internals.Algorithms
{
    using System.Collections.Generic;


    public class PrefixMatcher<T>
    {
        readonly TrieNode<T> _root;
        TrieNode<T> _current;
        string _prefix;

        public PrefixMatcher(TrieNode<T> root)
        {
            _root = root;
            _current = root;
        }

        void Reset()
        {
            _current = _root;
            _prefix = null;
        }


        public char LastMatch => _current.Key;

        public bool Next(char key)
        {
            TrieNode<T> child;
            if (_current.TryGetChild(key, out child))
            {
                _current = child;
                _prefix += key;
                return true;
            }

            return false;
        }

        public void Previous()
        {
            if (_current != _root)
            {
                _current = _current.Parent;
                _prefix = _prefix.Substring(0, _prefix.Length - 1);
            }
        }

        public IList<T> GetMatches()
        {
            return _current.PrefixMatches();
        }

        public bool IsExactMatch => _current.IsTerminal;

        public T ExactMatch => _current.IsTerminal ? _current.Value : default(T);
    }
}