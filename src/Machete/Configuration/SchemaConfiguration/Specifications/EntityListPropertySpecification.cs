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


    public class EntityListPropertySpecification<TEntity, TSchema, TEntityValue> :
        PropertySpecification<TEntity, TSchema>,
        IEntityListPropertyConfigurator<TEntityValue>
        where TSchema : Entity
        where TEntity : TSchema
        where TEntityValue : TSchema
    {
        readonly ValueSliceFactory _sliceFactory;

        public EntityListPropertySpecification(PropertyInfo property, int position)
            : base(property, position)
        {
            _sliceFactory = Single;
        }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield return typeof(TEntityValue);
        }

        public override void Apply(IEntityMapBuilder<TEntity, TSchema> builder)
        {
            IEntityMap<TEntityValue> entityMap = builder.GetEntityMap<TEntityValue>();

            var property = new ValueListEntityProperty<TEntity, TEntityValue>(builder.ImplementationType, Property.Name, Position,
                x => new EntityValueList<TEntityValue>(x, entityMap), _sliceFactory);

            ITextSliceProvider<TEntity> provider = new ValueListSliceProvider<TEntity, TEntityValue>(Property, new EntityValueFormatter<TEntityValue>(entityMap));

            builder.Add(property, provider);
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            if (!typeof(TEntityValue).IsInterface)
                yield return this.Error("Entity values must be interfaces", "EntityType", TypeCache<TEntityValue>.ShortName);
        }

        TextSlice Single(TextSlice slice, int position)
        {
            TextSlice result;
            slice.TryGetSlice(position, out result);

            return result ?? Slice.Missing;
        }
    }
}