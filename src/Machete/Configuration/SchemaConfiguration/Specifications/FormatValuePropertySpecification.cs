namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using PropertyMappers;
    using Slices.Providers;
    using Values;


    public class FormatValuePropertySpecification<TEntity, TSchema, TValue> :
        PropertySpecification<TEntity, TSchema, TValue>,
        IDateTimeValueConfigurator<TValue>
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly Func<string, IValueConverter<TValue>> _valueConverterFactory;
        readonly IValueFormatter<TValue> _valueFormatter;

        public FormatValuePropertySpecification(PropertyInfo property, int position, Func<string, IValueConverter<TValue>> valueConverterFactory, IValueFormatter<TValue> valueFormatter)
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

            ValueFactory<TValue> factory = fragment => new ConvertValue<TValue>(fragment, 0, valueConverter);
            
            var mapper = new SingleSliceValuePropertyMapper<TEntity, TValue>(builder.ImplementationType, Property.Name, Position, factory);

            ITextSliceProvider<TEntity> provider = new ValueSliceProvider<TEntity, TValue>(Property, _valueFormatter);

            builder.AddValue(mapper, provider);
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }
    }
}