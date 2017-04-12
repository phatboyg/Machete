namespace Machete.SchemaConfiguration.Specifications
{
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using PropertyMappers;
    using Slices.Providers;
    using Values;


    public class ValuePropertySpecification<TEntity, TSchema, TValue> :
        PropertySpecification<TEntity, TSchema, TValue>
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly IValueConverter<TValue> _valueConverter;
        readonly IValueFormatter<TValue> _valueFormatter;

        public ValuePropertySpecification(PropertyInfo property, int position, IValueConverter<TValue> valueConverter, IValueFormatter<TValue> valueFormatter)
            : base(property, position)
        {
            _valueConverter = valueConverter;
            _valueFormatter = valueFormatter;
        }

        public override void Apply(IEntityMapBuilder<TEntity, TSchema> builder)
        {
            var mapper = new SingleSliceValuePropertyMapper<TEntity, TValue>(builder.ImplementationType, Property.Name, Position, Factory);

            ITextSliceProvider<TEntity> provider = new ValueSliceProvider<TEntity, TValue>(Property, _valueFormatter);

            builder.AddValue(mapper, provider);
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        Value<TValue> Factory(TextSlice slice)
        {
            return new ConvertValue<TValue>(slice, 0, _valueConverter);
        }
    }
}