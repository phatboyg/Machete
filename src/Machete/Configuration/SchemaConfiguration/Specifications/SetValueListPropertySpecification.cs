namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Entities.EntityProperties;
    using Formatters;
    using Values.Formatters;


    public class SetValueListPropertySpecification<TEntity, TSchema, TValue> :
        PropertySpecification<TEntity, TSchema, TValue>,
        IPropertyListConfigurator
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly SetValueListProvider<TValue> _valueProvider;

        public SetValueListPropertySpecification(PropertyInfo property, SetValueListProvider<TValue> valueProvider)
            : base(property, 0)
        {
            _valueProvider = valueProvider;

            SetParent();
        }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield break;
        }

        public override void Apply(IEntityConverterBuilder<TEntity, TSchema> builder)
        {
            var converter = new ValueListEntityPropertyConverter<TEntity, TValue>(builder.ImplementationType, Property.Name, Position, GetValue, SliceProvider);

            builder.Add(Property.Name, GetValueInfo(), converter);
        }

        public override void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder)
        {
            if (Formatting.HasFlag(FormatOptions.Exclude))
                return;

            IValueFormatter<TValue> valueFormatter = new ToStringValueFormatter<TValue>();
            var propertyFormatter = new ValueListEntityPropertyFormatter<TEntity, TValue>(Property, valueFormatter);

            builder.Add(Position, propertyFormatter);
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            if (_valueProvider == null)
                yield return this.Null("ValueProvider");
            if (SliceProvider == null)
                yield return this.Error("Must be specified", nameof(SliceProvider));
        }

        ValueList<TValue> GetValue(TextSlice slice)
        {
            return _valueProvider(slice);
        }
    }
}