namespace Machete.SchemaConfiguration.Configurators
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using Builders;
    using Configuration;
    using Internals.Algorithms;
    using Internals.Extensions;
    using TypeSelectors;


    public class SchemaConfigurator<TSchema> :
        ISchemaConfigurator<TSchema>,
        ISchemaLayoutConfigurator<TSchema>,
        ISpecification
        where TSchema : Entity
    {
        readonly IDictionary<Type, ISchemaSpecification<TSchema>> _schemaSpecifications;
        readonly IDictionary<Type, ILayoutSpecification<TSchema>> _structureSpecifications;
        readonly IEntitySelectorFactory _entitySelectorFactory;

        protected IEntitySelectorFactory EntitySelectorFactory => _entitySelectorFactory;

        protected SchemaConfigurator(IEntitySelectorFactory entitySelectorFactory)
        {
            _entitySelectorFactory = entitySelectorFactory;

            _schemaSpecifications = new Dictionary<Type, ISchemaSpecification<TSchema>>();
            _structureSpecifications = new Dictionary<Type, ILayoutSpecification<TSchema>>();
        }

        public void Add(ISchemaSpecification<TSchema> specification)
        {
            if (specification == null)
                throw new ArgumentNullException(nameof(specification));

            _schemaSpecifications.Add(specification.EntityType, specification);
        }

        public void Add(ILayoutSpecification<TSchema> specification)
        {
            if (specification == null)
                throw new ArgumentNullException(nameof(specification));

            _structureSpecifications.Add(specification.TemplateType, specification);
        }

        public void AddFromNamespaceContaining<T>()
        {
            string ns = typeof(T).Namespace;
            if (ns == null)
                throw new ArgumentException("The specified type does not have a valid namespace", nameof(T));

            var types = typeof(T).Assembly.GetTypes()
                .Where(x => x.Namespace != null && x.Namespace.StartsWith(ns))
                .ToList();

            AddSchemaSpecifications(types);
            AddLayoutSpecifications(types);
        }

        void AddSchemaSpecifications(IEnumerable<Type> namespaceTypes)
        {
            var specificationTypes = namespaceTypes
                .Where(x => x.HasInterface<ISchemaSpecification<TSchema>>())
                .Where(x => x.IsConcrete());

            foreach (var type in specificationTypes)
            {
                var specification = (ISchemaSpecification<TSchema>) Activator.CreateInstance(type);

                _schemaSpecifications.Add(specification.EntityType, specification);
            }
        }

        void AddLayoutSpecifications(IEnumerable<Type> namespaceTypes)
        {
            var types = namespaceTypes
                .Where(x => x.HasInterface<ILayoutSpecification<TSchema>>())
                .Where(x => x.IsConcrete());

            foreach (var type in types)
            {
                var specification = (ILayoutSpecification<TSchema>) Activator.CreateInstance(type);

                _structureSpecifications.Add(specification.TemplateType, specification);
            }
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _schemaSpecifications.Values.SelectMany(x => x.Validate())
                .Concat(_structureSpecifications.Values.SelectMany(x => x.Validate()));
        }

        public ISchema<TSchema> Build()
        {
            var builder = CreateSchemaBuilder();

            BuildSchema(builder);

            BuildLayouts(builder);

            return builder.Build();
        }

        protected virtual SchemaBuilder<TSchema> CreateSchemaBuilder()
        {
            return new SchemaBuilder<TSchema>(EntitySelectorFactory);
        }

        void BuildSchema(ISchemaBuilder<TSchema> builder)
        {
            var graph = new DependencyGraph<Type>();
            foreach (var specification in _schemaSpecifications)
            {
                foreach (var entityType in specification.Value.GetReferencedEntityTypes())
                {
                    graph.Add(specification.Key, entityType);
                }
            }

            var orderedSpecifications = graph.GetItemsInDependencyOrder()
                .Concat(_schemaSpecifications.Keys)
                .Distinct()
                .Select(type => _schemaSpecifications[type]);

            foreach (var specification in orderedSpecifications)
            {
                specification.Apply(builder);
            }
        }


        void BuildLayouts(ISchemaLayoutBuilder<TSchema> schemaBuilder)
        {
            var builder = new SchemaLayoutBuilder<TSchema>(schemaBuilder);

            var graph = new DependencyGraph<Type>();
            foreach (var specification in _structureSpecifications)
            {
                foreach (var layoutType in specification.Value.GetReferencedLayoutTypes())
                {
                    graph.Add(specification.Key, layoutType);
                }
            }

            var orderedSpecifications = graph.GetItemsInDependencyOrder()
                .Concat(_structureSpecifications.Keys)
                .Distinct()
                .Select(type => _structureSpecifications[type]);

            foreach (var specification in orderedSpecifications)
            {
                specification.Apply(builder);
            }
        }
    }
}