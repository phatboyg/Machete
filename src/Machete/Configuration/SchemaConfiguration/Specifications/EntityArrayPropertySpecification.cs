namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Entities.EntityProperties;
    using Internals.Extensions;
    using Slices;
    using Slices.Providers;
    using Values;

    public class EntityArrayPropertySpecification<TEntity, TSchema, TEntityValue> :
        PropertySpecification<TEntity, TSchema>,
        IEntityArrayPropertyConfigurator<TEntityValue>
        where TSchema : Entity
        where TEntity : TSchema
        where TEntityValue : TSchema
    {
        readonly ValueSliceFactory _sliceFactory;

        public EntityArrayPropertySpecification(PropertyInfo property, int position)
            : base(property, position)
        {
            _sliceFactory = Multiple;
        }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield return typeof(TEntityValue);
        }

        public override void Apply(IEntityConverterBuilder<TEntity, TSchema> builder)
        {
            var entityConverter = builder.GetEntityMap<TEntityValue>();

            var property = new ValueArrayEntityProperty<TEntity, TEntityValue>(builder.ImplementationType, Property.Name, Position,
                x => new EntityValueArray<TEntityValue>(x, entityConverter), _sliceFactory);

            builder.Add(property);
        }

        public override void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder)
        {
            var formatter = builder.GetEntityFormatter<TEntityValue>();

            ITextSliceProvider<TEntity> provider =
                new ValueArraySliceProvider<TEntity, TEntityValue>(Property, new EntityValueFormatter<TEntityValue, TSchema>(formatter));

            builder.Add(provider);
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            if (!typeof(TEntityValue).IsInterface)
                yield return this.Error("Entity values must be interfaces", "EntityType", TypeCache<TEntityValue>.ShortName);
        }

        TextSlice Multiple(TextSlice slice, int position)
        {
            return new RangeTextSlice(slice, position);
        }
    }
}