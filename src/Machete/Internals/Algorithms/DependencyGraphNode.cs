namespace Machete.Internals.Algorithms
{
    using System;


    class DependencyGraphNode<T> :
        Node<T>,
        TopologicalSortNodeProperties,
        TarjanNodeProperties,
        IComparable<DependencyGraphNode<T>>
    {
        public int Index;
        public int LowLink;
        public bool Visited;

        public DependencyGraphNode(int index, T value)
            : base(index, value)
        {
            Visited = false;
            LowLink = -1;
            Index = -1;
        }

        int TarjanNodeProperties.Index
        {
            get => Index;
            set => Index = value;
        }

        int TarjanNodeProperties.LowLink
        {
            get => LowLink;
            set => LowLink = value;
        }

        bool TopologicalSortNodeProperties.Visited
        {
            get => Visited;
            set => Visited = value;
        }
    }
}