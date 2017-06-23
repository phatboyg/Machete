namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Entities;
    using Entities.EntityProperties;
    using Slices.Providers;
    using Values;


    public class FormatValueArrayPropertySpecification<TEntity, TSchema, TValue> :
        PropertySpecification<TEntity, TSchema>,
        IDateTimePropertyConfigurator<TValue>
        where TEntity : TSchema
        where TSchema : Entity
    {
        IValueConverter<TValue> _valueConverter;
        readonly IValueFormatter<TValue> _valueFormatter;

        public FormatValueArrayPropertySpecification(PropertyInfo property, int position, IValueConverter<TValue> valueConverter,
            IValueFormatter<TValue> valueFormatter)
            : base(property, position)
        {
            _valueConverter = valueConverter;
            _valueFormatter = valueFormatter;
        }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield break;
        }

        public override void Apply(IEntityConverterBuilder<TEntity, TSchema> builder)
        {
            ValueArrayFactory<TValue> factory = fragment => new EntityValueArray<TValue>(fragment, _valueConverter);

            var mapper = new ValueArrayEntityProperty<TEntity, TValue>(builder.ImplementationType, Property.Name, Position, factory, Single);

            builder.Add(mapper);
        }

        public override void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder)
        {
            ITextSliceProvider<TEntity> provider = new ValueArraySliceProvider<TEntity, TValue>(Property, _valueFormatter);

            builder.Add(provider);
        }

        TextSlice Single(TextSlice slice, int position)
        {
            TextSlice result;
            slice.TryGetSlice(position, out result);

            return result ?? Slice.Missing;
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        public IValueConverter<TValue> Converter
        {
            set { _valueConverter = value; }
        }
    }
}