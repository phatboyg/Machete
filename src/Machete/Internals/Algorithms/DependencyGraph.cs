namespace Machete.Internals.Algorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    class DependencyGraph<T>
    {
        readonly AdjacencyList<T, DependencyGraphNode<T>> _adjacencyList;

        public DependencyGraph()
        {
            _adjacencyList = new AdjacencyList<T, DependencyGraphNode<T>>(DefaultNodeFactory);
        }

        static DependencyGraphNode<T> DefaultNodeFactory(int index, T value)
        {
            return new DependencyGraphNode<T>(index, value);
        }

        public void Add(T source)
        {
            _adjacencyList.GetNode(source);
        }

        public void Add(T source, T target)
        {
            _adjacencyList.AddEdge(source, target, 0);
        }

        public void Add(T source, IEnumerable<T> targets)
        {
            foreach (var target in targets)
                _adjacencyList.AddEdge(source, target, 0);
        }

        public IEnumerable<T> GetItemsInDependencyOrder()
        {
            EnsureGraphIsAcyclic();

            var sort = new TopologicalSort<T, DependencyGraphNode<T>>(_adjacencyList.Clone());

            return sort.Result.Select(x => x.Value);
        }

        public IEnumerable<T> GetItemsInDependencyOrder(T source)
        {
            EnsureGraphIsAcyclic();

            var sort = new TopologicalSort<T, DependencyGraphNode<T>>(_adjacencyList.Clone(), source);

            return sort.Result.Select(x => x.Value);
        }

        void EnsureGraphIsAcyclic()
        {
            var tarjan = new Tarjan<T, DependencyGraphNode<T>>(_adjacencyList);

            if (tarjan.Result.Count == 0)
                return;

            var message = new StringBuilder();
            foreach (var cycle in tarjan.Result)
            {
                message.Append("(");
                for (int i = 0; i < cycle.Count; i++)
                {
                    if (i > 0)
                        message.Append(",");

                    message.Append(cycle[i].Value);
                }
                message.Append(")");
            }

            throw new InvalidOperationException("The dependency graph contains cycles: " + message);
        }
    }
}