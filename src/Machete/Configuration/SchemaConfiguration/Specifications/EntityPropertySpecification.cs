namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Entities.EntityProperties;
    using Internals.Extensions;
    using Slices.Providers;
    using Values;


    public class EntityPropertySpecification<TEntity, TSchema, TEntityValue> :
        PropertySpecification<TEntity, TSchema, TEntityValue>,
        IEntityPropertyConfigurator<TEntityValue>
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

            var mapper = new SingleSliceValueEntityProperty<TEntity, TEntityValue>(builder.ImplementationType, Property.Name, Position, x => Factory(x, entityConverter));

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
            if (!typeof(TEntityValue).IsInterface)
                yield return this.Error("Entity values must be interfaces", "EntityType", TypeCache<TEntityValue>.ShortName);
        }

        static Value<TEntityValue> Factory(TextSlice slice, IEntityConverter<TEntityValue> entityConverter)
        {
            var value = entityConverter.GetEntity(slice);

            return new ConvertedValue<TEntityValue>(slice, value);
        }
    }
}