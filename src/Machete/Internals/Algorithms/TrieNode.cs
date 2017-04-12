namespace Machete.Internals.Algorithms
{
    using System.Collections.Generic;


    public class TrieNode<T>
    {
        public readonly char Key;
        public readonly TrieNode<T> Parent;


        readonly Dictionary<char, TrieNode<T>> _children;
        bool _hasValue;
        T _value;

        public TrieNode(TrieNode<T> parent, char key)
        {
            Parent = parent;
            Key = key;

            _hasValue = false;
            _children = new Dictionary<char, TrieNode<T>>();
        }

        public T Value
        {
            get { return _value; }
            set
            {
                _value = value;
                _hasValue = true;
            }
        }

        public int ChildCount => _children.Count;

        public bool IsLeaf => _children.Count == 0;

        public bool IsTerminal => _hasValue;

        public TrieNode<T> this[char key]
        {
            get
            {
                TrieNode<T> child;
                if (_children.TryGetValue(key, out child))
                    return child;

                child = new TrieNode<T>(this, key);
                _children.Add(key, child);
                return child;
            }
        }

        public void RemoveValue()
        {
            _hasValue = false;
            _value = default(T);
        }

        public bool TryGetChild(char key, out TrieNode<T> child)
        {
            return _children.TryGetValue(key, out child);
        }

        public void Remove(char key)
        {
            _children.Remove(key);
        }

        public IList<T> PrefixMatches()
        {
            var values = new List<T>();

            PrefixMatches(values);

            return values;
        }

        void PrefixMatches(List<T> values)
        {
            if (IsLeaf)
            {
                if (IsTerminal)
                {
                    values.Add(Value);
                    return;
                }

                return;
            }

            foreach (var child in _children.Values)
                child.PrefixMatches(values);

            if (IsTerminal)
                values.Add(Value);
        }
    }
}