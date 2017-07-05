namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Entities.EntityProperties;
    using Slices.Providers;
    using Values;


    public class PropertyListPropertySpecification<TEntity, TSchema, TValue> :
        PropertySpecification<TEntity, TSchema, TValue>,
        IPropertyListConfigurator<TValue>
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly IValueConverter<TValue> _valueConverter;
        readonly IValueFormatter<TValue> _valueFormatter;

        public PropertyListPropertySpecification(PropertyInfo property, int position, IValueConverter<TValue> valueConverter, IValueFormatter<TValue> valueFormatter)
            : base(property, position)
        {
            _valueConverter = valueConverter;
            _valueFormatter = valueFormatter;

            SetList();
        }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield break;
        }

        public override void Apply(IEntityConverterBuilder<TEntity, TSchema> builder)
        {
            var property = new ValueListEntityProperty<TEntity, TValue>(builder.ImplementationType, Property.Name, Position, GetValue, SliceFactory);

            builder.Add(property);
        }

        public override void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder)
        {
            ITextSliceProvider<TEntity> provider = new ValueListSliceProvider<TEntity, TValue>(Property, _valueFormatter);

            builder.Add(provider);
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        ValueList<TValue> GetValue(TextSlice slice)
        {
            return new EntityValueList<TValue>(slice, _valueConverter);
        }
    }
}