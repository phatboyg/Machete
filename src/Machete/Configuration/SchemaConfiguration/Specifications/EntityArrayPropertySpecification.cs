namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Internals.Extensions;
    using PropertyMappers;
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

        public override void Apply(IEntityMapBuilder<TEntity, TSchema> builder)
        {
            IEntityMap<TEntityValue> entityMap = builder.GetEntityMap<TEntityValue>();

            var converter = new Converter(entityMap);

            var property = new ValueArrayEntityProperty<TEntity, TEntityValue>(builder.ImplementationType, Property.Name, Position,
                x => new EntityValueArray<TEntityValue>(x, converter), _sliceFactory);

            ITextSliceProvider<TEntity> provider = new EntityValueSliceProvider<TEntity, TEntityValue>(Property, entityMap);

            builder.Add(property, provider);
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


        class Converter :
            IValueConverter<TEntityValue>
        {
            readonly IEntityMap<TEntityValue> _entityMap;

            public Converter(IEntityMap<TEntityValue> entityMap)
            {
                _entityMap = entityMap;
            }

            public bool TryConvert(TextSlice slice, out Value<TEntityValue> convertedValue)
            {
                var value = _entityMap.GetEntity(slice);

                convertedValue = new ConvertedValue<TEntityValue>(slice, value);
                return true;
            }
        }
    }
}