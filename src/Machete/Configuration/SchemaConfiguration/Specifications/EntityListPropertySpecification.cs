namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Entities.EntityProperties;
    using Formatters;
    using Internals.Extensions;
    using Values;


    public class EntityListPropertySpecification<TEntity, TSchema, TEntityValue> :
        PropertySpecification<TEntity, TSchema, TEntityValue>,
        IPropertyListConfigurator
        where TSchema : Entity
        where TEntity : TSchema
        where TEntityValue : TSchema
    {
        public EntityListPropertySpecification(PropertyInfo property, int position)
            : base(property, position)
        {
            SetList();
        }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield return typeof(TEntityValue);
        }

        public override void Apply(IEntityConverterBuilder<TEntity, TSchema> builder)
        {
            IEntityConverter<TEntityValue> entityConverter = builder.GetEntityConverter<TEntityValue>();

            var property = new ValueListEntityPropertyConverter<TEntity, TEntityValue>(Property.Name, Position,
                x => new EntityValueList<TEntityValue>(x, entityConverter), SliceProvider);

            builder.Add(Property.Name, GetValueInfo(), property);
        }

        public override void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder)
        {
            if (Formatting.HasFlag(FormatOptions.Exclude))
                return;

            var entityFormatter = builder.GetEntityFormatter<TEntityValue>();

            var formatter = new ValueListEntityPropertyFormatter<TEntity, TEntityValue>(Property, new EntityValueFormatter<TEntityValue, TSchema>(entityFormatter));

            builder.Add(Position, formatter);
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            if (!typeof(TEntityValue).GetTypeInfo().IsInterface)
                yield return this.Error("Entity values must be interfaces", "EntityType", TypeCache<TEntityValue>.ShortName);
            
            if (SliceProvider == null)
                yield return this.Error("Must be specified", nameof(SliceProvider));
        }
    }
}