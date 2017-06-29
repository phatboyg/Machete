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
        ValueSliceFactory _sliceFactory;

        public EntityListPropertySpecification(PropertyInfo property, int position)
            : base(property, position)
        {
            _sliceFactory = List;
        }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield return typeof(TEntityValue);
        }

        public override void Apply(IEntityConverterBuilder<TEntity, TSchema> builder)
        {
            IEntityConverter<TEntityValue> entityConverter = builder.GetEntityConverter<TEntityValue>();

            var property = new ValueListEntityProperty<TEntity, TEntityValue>(builder.ImplementationType, Property.Name, Position,
                x => new EntityValueList<TEntityValue>(x, entityConverter), _sliceFactory);

            builder.Add(property);
        }

        public override void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder)
        {
            var entityFormatter = builder.GetEntityFormatter<TEntityValue>();

            ITextSliceProvider<TEntity> provider = new ValueListSliceProvider<TEntity, TEntityValue>(Property, new EntityValueFormatter<TEntityValue, TSchema>(entityFormatter));

            builder.Add(provider);
        }

        public bool IsList
        {
            set
            {
                if (value)
                    _sliceFactory = List;
                else
                    _sliceFactory = Single;
            }
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

        TextSlice List(TextSlice slice, int position)
        {
            TextSlice result;
            if (slice.TryGetSlice(position, out result))
            {
                var listSlice = result as ListTextSlice;
                if (listSlice?.TryGetListSlice(out result) == true)
                {
                    return result;
                }

                throw new MacheteParserException($"The slice is not a list: {TypeCache<TEntity>.ShortName}.ValueList<{TypeCache<TEntityValue>.ShortName}> {Property.Name}");
            }

            return Slice.Missing;
        }
    }
}