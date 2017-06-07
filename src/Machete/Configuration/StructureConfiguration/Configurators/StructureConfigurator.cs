namespace Machete.StructureConfiguration.Configurators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Builders;
    using Configuration;
    using Internals.Algorithms;
    using Internals.Extensions;


    public abstract class StructureConfigurator<TSchema> :
        IStructureConfigurator<TSchema>,
        ISpecification
        where TSchema : Entity
    {
        readonly IDictionary<Type, ILayoutSpecification<TSchema>> _specifications;
        ISchema<TSchema> _schema;

        protected StructureConfigurator(ISchema<TSchema> schema)
        {
            _schema = schema;
            _specifications = new Dictionary<Type, ILayoutSpecification<TSchema>>();
        }

        public void Add(ILayoutSpecification<TSchema> specification)
        {
            if (specification == null)
                throw new ArgumentNullException(nameof(specification));

            _specifications.Add(specification.TemplateType, specification);
        }

        public void AddFromNamespaceContaining<T>()
        {
            string ns = typeof(T).Namespace;
            if (ns == null)
                throw new ArgumentException("The specified type does not have a valid namespace", nameof(T));

            var types = typeof(T).Assembly.GetTypes()
                .Where(x => x.Namespace != null && x.Namespace.StartsWith(ns))
                .Where(x => x.HasInterface<ILayoutSpecification<TSchema>>())
                .Where(x => x.IsConcrete());

            foreach (var type in types)
            {
                var specification = (ILayoutSpecification<TSchema>)Activator.CreateInstance(type);

                _specifications.Add(specification.TemplateType, specification);
            }
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _specifications.Values.SelectMany(x => x.Validate());
        }

        public IStructure<TSchema> Build()
        {
            var builder = new StructureBuilder<TSchema>(_schema);

            var graph = new DependencyGraph<Type>();
            foreach (var specification in _specifications)
            {
                foreach (var layoutType in specification.Value.GetReferencedLayoutTypes())
                {
                    graph.Add(specification.Key, layoutType);
                }
            }

            var orderedSpecifications = graph.GetItemsInDependencyOrder()
                .Concat(_specifications.Keys)
                .Distinct()
                .Select(type => _specifications[type]);

            foreach (var specification in orderedSpecifications)
            {
                specification.Apply(builder);
            }

            return builder.Build();
        }
    }
}