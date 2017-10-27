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


    public class EntityPropertySpecification<TEntity, TSchema, TEntityValue> :
        PropertySpecification<TEntity, TSchema, TEntityValue>
        where TSchema : Entity
        where TEntity : TSchema
        where TEntityValue : TSchema
    {
        public EntityPropertySpecification(PropertyInfo property, int position)
            : base(property, position)
        {
        }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield return typeof(TEntityValue);
        }

        public override void Apply(IEntityConverterBuilder<TEntity, TSchema> builder)
        {
            IEntityConverter<TEntityValue> entityConverter = builder.GetEntityConverter<TEntityValue>();

            Value<TEntityValue> Factory(TextSlice slice)
            {
                return new ConvertValue<TEntityValue>(slice, entityConverter);
            }

            var mapper = new ValueEntityProperty<TEntity, TEntityValue>(builder.ImplementationType, Property.Name, Position, Factory);

            builder.Add(mapper);
        }

        public override void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder)
        {
            if (Formatting.HasFlag(FormatOptions.Exclude))
                return;

            var entityFormatter = builder.GetEntityFormatter<TEntityValue>();

            var formatter = new EntityValueEntityPropertyFormatter<TEntity, TSchema, TEntityValue>(Property, entityFormatter);

            builder.Add(Position, formatter);
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            if (!typeof(TEntityValue).GetTypeInfo().IsInterface)
                yield return this.Error("Entity values must be interfaces", "EntityType", TypeCache<TEntityValue>.ShortName);
        }
    }
}