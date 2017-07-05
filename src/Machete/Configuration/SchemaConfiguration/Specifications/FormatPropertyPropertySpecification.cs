namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Entities.EntityProperties;
    using Slices.Providers;
    using Values;


    public class FormatPropertySpecification<TEntity, TSchema, TValue> :
        PropertySpecification<TEntity, TSchema, TValue>,
        IDateTimePropertyConfigurator<TValue>
        where TEntity : TSchema
        where TSchema : Entity
    {
        IValueConverter<TValue> _valueConverter;
        readonly IValueFormatter<TValue> _valueFormatter;

        public FormatPropertySpecification(PropertyInfo property, int position, IValueConverter<TValue> valueConverter, IValueFormatter<TValue> valueFormatter)
            : base(property, position)
        {
            _valueConverter = valueConverter;
            _valueFormatter = valueFormatter;
        }

        public string Format { get; set; }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield break;
        }

        public override void Apply(IEntityConverterBuilder<TEntity, TSchema> builder)
        {
            ValueFactory<TValue> factory = fragment => new ConvertValue<TValue>(fragment, 0, _valueConverter);

            var mapper = new SingleSliceValueEntityProperty<TEntity, TValue>(builder.ImplementationType, Property.Name, Position, factory);

            builder.Add(mapper);
        }

        public override void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder)
        {
            ITextSliceProvider<TEntity> provider = new ValueSliceProvider<TEntity, TValue>(Property, _valueFormatter);

            builder.Add(provider);
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