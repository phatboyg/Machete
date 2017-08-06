namespace Machete.Internals.Algorithms
{
    class Node<T>
    {
        readonly int _index;
        public readonly T Value;

        public Node(int index, T value)
        {
            _index = index;
            Value = value;
        }

        public int CompareTo(DependencyGraphNode<T> other)
        {
            return !Equals(other)
                ? 0
                : -1;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return _index;
        }
    }
}