namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Builders;
    using Configuration;


    public class EntitySpecification<TEntity, TSchema> :
        IEntityConfigurator<TEntity, TSchema>,
        ISchemaSpecification<TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly IDictionary<string, IEntityMapSpecification<TEntity, TSchema>> _specifications;

        public EntitySpecification()
        {
            _specifications = new Dictionary<string, IEntityMapSpecification<TEntity, TSchema>>(StringComparer.OrdinalIgnoreCase);
        }

        public string Name { get; set; }

        public void Add(string propertyName, IEntityMapSpecification<TEntity, TSchema> specification)
        {
            _specifications[propertyName] = specification;
        }

        public IEntityTypeSelector EntityTypeSelector { private get; set; }

        public Type EntityType => typeof(TEntity);

        public IEnumerable<Type> GetReferencedEntityTypes()
        {
            return _specifications.Values.SelectMany(x => x.GetReferencedEntityTypes());
        }

        public void Apply(ISchemaBuilder<TSchema> builder)
        {
            var entityMapBuilder = new DynamicEntityMapBuilder<TEntity, TSchema>(builder, EntityTypeSelector);

            foreach (var specification in _specifications.Values)
            {
                specification.Apply(entityMapBuilder);
            }

            var map = entityMapBuilder.Build();

            builder.Add(map);
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _specifications.Values.SelectMany(x => x.Validate());
        }
    }
}