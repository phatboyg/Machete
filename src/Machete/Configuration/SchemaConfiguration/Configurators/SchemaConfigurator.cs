namespace Machete.SchemaConfiguration.Configurators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Builders;
    using Configuration;
    using Internals.Algorithms;
    using Internals.Extensions;
    using TypeSelectors;


    public class SchemaConfigurator<TSchema> :
        ISchemaConfigurator<TSchema>,
        ISpecification
        where TSchema : Entity
    {
        readonly IDictionary<Type, ISchemaSpecification<TSchema>> _specifications;
        readonly IEntityTypeSelectorFactory _entityTypeSelectorFactory;

        protected SchemaConfigurator(IEntityTypeSelectorFactory entityTypeSelectorFactory)
        {
            _entityTypeSelectorFactory = entityTypeSelectorFactory;

            _specifications = new Dictionary<Type, ISchemaSpecification<TSchema>>();
        }

        public void Add(ISchemaSpecification<TSchema> specification)
        {
            if (specification == null)
                throw new ArgumentNullException(nameof(specification));

            _specifications.Add(specification.EntityType, specification);
        }

        public void AddFromNamespaceContaining<T>()
        {
            string ns = typeof(T).Namespace;
            if (ns == null)
                throw new ArgumentException("The specified type does not have a valid namespace", nameof(T));

            var types = typeof(T).Assembly.GetTypes()
                .Where(x => x.Namespace != null && x.Namespace.StartsWith(ns))
                .Where(x => x.HasInterface<ISchemaSpecification<TSchema>>())
                .Where(x => x.IsConcrete());

            foreach (var type in types)
            {
                var specification = (ISchemaSpecification<TSchema>)Activator.CreateInstance(type);

                _specifications.Add(specification.EntityType, specification);
            }
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _specifications.Values.SelectMany(x => x.Validate());
        }

        public ISchema<TSchema> Build()
        {
            var builder = new SchemaBuilder<TSchema>(_entityTypeSelectorFactory);

            var graph = new DependencyGraph<Type>();
            foreach (var specification in _specifications)
            {
                foreach (var entityType in specification.Value.GetReferencedEntityTypes())
                {
                    graph.Add(specification.Key, entityType);
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