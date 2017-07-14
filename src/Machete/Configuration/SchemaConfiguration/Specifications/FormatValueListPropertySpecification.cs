namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Entities;
    using Entities.EntityProperties;
    using Slices.Providers;
    using Values;


    public class FormatValueListPropertySpecification<TEntity, TSchema, TValue> :
        PropertySpecification<TEntity, TSchema, TValue>,
        IDateTimePropertyConfigurator<TValue>
        where TEntity : TSchema
        where TSchema : Entity
    {
        IValueConverter<TValue> _valueConverter;
        readonly IValueFormatter<TValue> _valueFormatter;

        public FormatValueListPropertySpecification(PropertyInfo property, int position, IValueConverter<TValue> valueConverter,
            IValueFormatter<TValue> valueFormatter)
            : base(property, position)
        {
            _valueConverter = valueConverter;
            _valueFormatter = valueFormatter;

            SetList();
        }

        public string Format { get; set; }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield break;
        }

        public override void Apply(IEntityConverterBuilder<TEntity, TSchema> builder)
        {
            ValueListFactory<TValue> factory = fragment => new EntityValueList<TValue>(fragment, _valueConverter);

            var mapper = new ValueListEntityProperty<TEntity, TValue>(builder.ImplementationType, Property.Name, Position, factory, SliceFactory);

            builder.Add(mapper);
        }

        public override void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder)
        {
            ITextSliceProvider<TEntity> provider = new ValueListSliceProvider<TEntity, TValue>(Property, _valueFormatter);

            builder.Add(provider);
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            if (SliceFactory == null)
                yield return this.Error("Must be specified", nameof(SliceFactory));
        }

        public IValueConverter<TValue> Converter
        {
            set { _valueConverter = value; }
        }
    }
}