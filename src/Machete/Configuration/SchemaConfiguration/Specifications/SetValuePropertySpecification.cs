namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using PropertyMappers;
    using Slices.Providers;
    using Values;
    using Values.Converters;
    using Values.Formatters;


    public class SetValuePropertySpecification<TEntity, TSchema, TValue> :
        PropertySpecification<TEntity, TSchema>
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly Func<TextSlice, TValue> _valueProvider;
        readonly IValueConverter<TValue> _valueConverter;

        public SetValuePropertySpecification(PropertyInfo property, Func<TextSlice, TValue> valueProvider)
            : base(property, 0)
        {
            _valueProvider = valueProvider;
            _valueConverter = new SetValueConverter<TValue>(valueProvider);
        }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield break;
        }

        public override void Apply(IEntityMapBuilder<TEntity, TSchema> builder)
        {
            var mapper = new SingleSliceValueEntityProperty<TEntity, TValue>(builder.ImplementationType, Property.Name, Position, GetValue);

            // TODO will need formatter eventually cached,shared

            IValueFormatter<TValue> formatter = new ToStringValueFormatter<TValue>();

            ITextSliceProvider<TEntity> provider = new ValueSliceProvider<TEntity, TValue>(Property, formatter);

            builder.Add(mapper, provider);
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            if (_valueProvider == null)
                yield return this.Null("ValueProvider");
        }

        Value<TValue> GetValue(TextSlice slice)
        {
            return new ConvertValue<TValue>(slice, _valueConverter);
        }
    }
}