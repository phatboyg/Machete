namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Entities.EntityProperties;
    using Formatters;
    using Values;
    using Values.Converters;
    using Values.Formatters;


    public class SetValuePropertySpecification<TEntity, TSchema, TValue> :
        PropertySpecification<TEntity, TSchema, TValue>
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly SetValueProvider<TValue> _valueProvider;
        readonly IValueConverter<TValue> _valueConverter;

        public SetValuePropertySpecification(PropertyInfo property, SetValueProvider<TValue> valueProvider)
            : base(property, 0)
        {
            _valueProvider = valueProvider;
            _valueConverter = new SetValueConverter<TValue>(valueProvider);

            SetParent();
        }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield break;
        }

        public override void Apply(IEntityConverterBuilder<TEntity, TSchema> builder)
        {
            var mapper = new ValueEntityPropertyConverter<TEntity, TValue>(builder.ImplementationType, Property.Name, GetValue);

            builder.Add(mapper);
        }

        public override void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder)
        {
            if (Formatting.HasFlag(FormatOptions.Exclude))
                return;

            IValueFormatter<TValue> valueFormatter = new ToStringValueFormatter<TValue>();

            var propertyFormatter = new ValueEntityPropertyFormatter<TEntity, TValue>(Property, valueFormatter);

            builder.Add(Position, propertyFormatter);
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            if (_valueProvider == null)
                yield return this.Null("ValueProvider");
            if (SliceProvider == null)
                yield return this.Error("Must be specified", nameof(SliceProvider));
        }

        Value<TValue> GetValue(TextSlice slice)
        {
            TextSlice textSlice = SliceProvider(slice, Position);

            return new ConvertValue<TValue>(textSlice, _valueConverter);
        }
    }
}