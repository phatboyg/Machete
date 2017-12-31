namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Builders;
    using Configuration;
    using Entities;
    using Formatters;
    using Internals.Extensions;


    public class EntitySpecification<TEntity, TSchema> :
        IEntityConfigurator<TEntity, TSchema>,
        ISchemaSpecification<TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly IList<IEntityPropertySpecification<TEntity, TSchema>> _specifications;

        public EntitySpecification()
        {
            _specifications = new List<IEntityPropertySpecification<TEntity, TSchema>>();
        }

        public string Name { get; set; }

        public void Add(string propertyName, IEntityPropertySpecification<TEntity, TSchema> specification)
        {
            _specifications.Add(specification);
        }

        public IEntitySelector EntitySelector { private get; set; }

        public EntityFormatterFactory<TEntity> FormatterFactory { get; set; }

        public Type EntityType => typeof(TEntity);

        public IEnumerable<Type> GetReferencedEntityTypes()
        {
            return _specifications.SelectMany(x => x.GetReferencedEntityTypes());
        }

        public void Apply(ISchemaBuilder<TSchema> builder)
        {
            BuildConverter(builder);

            BuildFormatter(builder);
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _specifications.SelectMany(x => x.Validate()).Select(x => x.WithParentKey(TypeCache<TEntity>.ShortName));
        }

        void BuildFormatter(ISchemaBuilder<TSchema> builder)
        {
            IEntityFormatter<TEntity> Factory()
            {
                try
                {
                    var formatterBuilder = new DynamicEntityFormatterBuilder<TEntity, TSchema>(builder);

                    if (FormatterFactory != null)
                        formatterBuilder.Factory = FormatterFactory;

                    foreach (var specification in _specifications)
                        specification.Apply(formatterBuilder);

                    return formatterBuilder.Build();
                }
                catch (Exception exception)
                {
                    throw new SchemaConfigurationException($"Failed to build entity formatter: {TypeCache<TEntity>.ShortName}", exception);
                }
            }

            builder.Add(new UnbuiltEntityFormatter<TEntity>(Factory));
        }

        void BuildConverter(ISchemaBuilder<TSchema> builder)
        {
            IEntityConverter<TEntity> ConverterFactory()
            {
                try
                {
                    var converterBuilder = new DynamicEntityConverterBuilder<TEntity, TSchema>(builder, EntitySelector);

                    foreach (var specification in _specifications)
                        specification.Apply(converterBuilder);

                    return converterBuilder.Build();
                }
                catch (Exception exception)
                {
                    throw new SchemaConfigurationException($"Failed to build entity map: {TypeCache<TEntity>.ShortName}", exception);
                }
            }

            builder.Add(new UnbuiltEntityConverter<TEntity>(ConverterFactory, EntitySelector));
        }
    }
}