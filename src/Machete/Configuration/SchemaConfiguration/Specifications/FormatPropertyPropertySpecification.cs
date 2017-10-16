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
        IPropertyConfigurator<TValue>
        where TEntity : TSchema
        where TSchema : Entity
    {
        IValueConverter<TValue> _valueConverter;
        IValueFormatter<TValue> _valueFormatter;

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
            Value<TValue> Factory(TextSlice slice) => new ConvertValue<TValue>(slice, 0, _valueConverter);

            var property = new ValueEntityProperty<TEntity, TValue>(builder.ImplementationType, Property.Name, Position, Factory);

            builder.Add(property);
        }

        public override void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder)
        {
            if (Formatting.HasFlag(FormatOptions.Exclude))
                return;

            var formatter = new ValueEntityPropertyFormatter<TEntity, TValue>(Property, _valueFormatter);

            builder.Add(Position, formatter);
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        public IValueConverter<TValue> Converter
        {
            set => _valueConverter = value;
        }

        public IValueFormatter<TValue> Formatter
        {
            set => _valueFormatter = value;
        }
    }
}