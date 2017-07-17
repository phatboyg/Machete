namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Builders;
    using Configuration;
    using Internals.Extensions;


    public class EntitySpecification<TEntity, TSchema> :
        IEntityConfigurator<TEntity, TSchema>,
        ISchemaSpecification<TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly IDictionary<string, IEntityPropertySpecification<TEntity, TSchema>> _specifications;

        public EntitySpecification()
        {
            _specifications = new Dictionary<string, IEntityPropertySpecification<TEntity, TSchema>>(StringComparer.OrdinalIgnoreCase);
        }

        public string Name { get; set; }

        public void Add(string propertyName, IEntityPropertySpecification<TEntity, TSchema> specification)
        {
            _specifications[propertyName] = specification;
        }

        public IEntitySelector EntitySelector { private get; set; }

        public Type EntityType => typeof(TEntity);

        public IEnumerable<Type> GetReferencedEntityTypes()
        {
            return _specifications.Values.SelectMany(x => x.GetReferencedEntityTypes());
        }

        public void Apply(ISchemaBuilder<TSchema> builder)
        {
            BuildConverter(builder);

            BuildFormatter(builder);
        }

        void BuildFormatter(ISchemaBuilder<TSchema> builder)
        {
            try
            {
                var formatterBuilder = new DynamicEntityFormatterBuilder<TEntity, TSchema>(builder);

                foreach (var specification in _specifications.Values)
                {
                    specification.Apply(formatterBuilder);
                }

                var formatter = formatterBuilder.Build();

                builder.Add(formatter);
            }
            catch (Exception exception)
            {
                throw new SchemaConfigurationException($"Failed to build entity formatter: {TypeCache<TEntity>.ShortName}", exception);
            }
        }

        void BuildConverter(ISchemaBuilder<TSchema> builder)
        {
            try
            {
                var converterBuilder = new DynamicEntityConverterBuilder<TEntity, TSchema>(builder, EntitySelector);

                foreach (var specification in _specifications.Values)
                {
                    specification.Apply(converterBuilder);
                }

                var converter = converterBuilder.Build();

                builder.Add(converter);
            }
            catch (Exception exception)
            {
                throw new SchemaConfigurationException($"Failed to build entity map: {TypeCache<TEntity>.ShortName}", exception);
            }
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _specifications.Values.SelectMany(x => x.Validate()).Select(x => x.WithParentKey(TypeCache<TEntity>.ShortName));
        }
    }
}