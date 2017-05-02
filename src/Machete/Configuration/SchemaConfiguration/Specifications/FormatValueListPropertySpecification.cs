namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using PropertyMappers;
    using Slices.Providers;
    using Values;


    public class FormatValueListPropertySpecification<TEntity, TSchema, TValue> :
        PropertySpecification<TEntity, TSchema, TValue>,
        IDateTimeValueConfigurator<TValue>
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly Func<string, IValueConverter<TValue>> _valueConverterFactory;
        readonly IValueFormatter<TValue> _valueFormatter;

        public FormatValueListPropertySpecification(PropertyInfo property, int position, Func<string, IValueConverter<TValue>> valueConverterFactory,
            IValueFormatter<TValue> valueFormatter)
            : base(property, position)
        {
            _valueConverterFactory = valueConverterFactory;
            _valueFormatter = valueFormatter;
        }

        public string Format { get; set; }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield break;
        }

        public override void Apply(IEntityMapBuilder<TEntity, TSchema> builder)
        {
            var valueConverter = _valueConverterFactory(Format);

            ValueListFactory<TValue> factory = fragment => new EntityValueList<TValue>(fragment, valueConverter);

            var mapper = new ValueListPropertyMapper<TEntity, TValue>(builder.ImplementationType, Property.Name, Position, factory, Single);

            ITextSliceProvider<TEntity> provider = new ValueListSliceProvider<TEntity, TValue>(Property, _valueFormatter);

            builder.AddValue(mapper, provider);
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
    }
}