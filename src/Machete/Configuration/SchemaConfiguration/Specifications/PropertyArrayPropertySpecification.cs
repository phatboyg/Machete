namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using PropertyMappers;
    using Slices;
    using Slices.Providers;
    using Values;


    public class PropertyArrayPropertySpecification<TEntity, TSchema, TValue> :
        PropertySpecification<TEntity, TSchema>,
        IPropertyArrayConfigurator<TValue>
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly IValueConverter<TValue> _valueConverter;
        readonly IValueFormatter<TValue> _valueFormatter;
        readonly ValueSliceFactory _sliceFactory;

        public PropertyArrayPropertySpecification(PropertyInfo property, int position, IValueConverter<TValue> valueConverter, IValueFormatter<TValue> valueFormatter)
            : base(property, position)
        {
            _valueConverter = valueConverter;
            _valueFormatter = valueFormatter;
            _sliceFactory = Multiple;
        }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield break;
        }

        public override void Apply(IEntityMapBuilder<TEntity, TSchema> builder)
        {
            var mapper = new ValueArrayEntityProperty<TEntity, TValue>(builder.ImplementationType, Property.Name, Position, GetValue, _sliceFactory);

            ITextSliceProvider<TEntity> provider = new ValueArraySliceProvider<TEntity, TValue>(Property, _valueFormatter);

            builder.AddValue(mapper, provider);
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        ValueArray<TValue> GetValue(TextSlice slice)
        {
            return new EntityValueArray<TValue>(slice, _valueConverter);
        }

        TextSlice Multiple(TextSlice slice, int position)
        {
            return new RangeTextSlice(slice, position);
        }
    }
}