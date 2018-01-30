namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Entities.EntityProperties;
    using Formatters;
    using Values;


    public class ValuePropertySpecification<TEntity, TSchema, TValue> :
        PropertySpecification<TEntity, TSchema, TValue>,
        IPropertyConfigurator<TValue>
        where TEntity : TSchema
        where TSchema : Entity
    {
        IValueConverter<TValue> _valueConverter;
        IValueFormatter<TValue> _valueFormatter;

        public ValuePropertySpecification(PropertyInfo property, int position, IValueConverter<TValue> valueConverter, IValueFormatter<TValue> valueFormatter)
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
            var converter = new ValueEntityPropertyConverter<TEntity, TValue>(Property.Name, Factory);

            builder.Add(Property.Name, GetValueInfo(), converter);
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
            if (_valueConverter == null)
                yield return this.Error("must not be null", nameof(Converter));
            
            if (_valueFormatter == null)
                yield return this.Error("must not be null", nameof(Formatter));
        }

        Value<TValue> Factory(TextSlice slice)
        {
            if (SliceProvider == null)
                return new ConvertValue<TValue>(slice, Position, _valueConverter);
            
            var valueSlice = SliceProvider(slice, Position);

            return new ConvertValue<TValue>(valueSlice, _valueConverter);
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