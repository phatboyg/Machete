namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Entities.EntityProperties;
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

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield break;
        }

        public override void Apply(IEntityConverterBuilder<TEntity, TSchema> builder)
        {
            var mapper = new SingleSliceValueEntityProperty<TEntity, TValue>(builder.ImplementationType, Property.Name, Position, Factory);

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

        Value<TValue> Factory(TextSlice slice)
        {
            return new ConvertValue<TValue>(slice, _valueConverter);
        }
    }
}