namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Entities.EntityProperties;
    using Slices.Providers;
    using Values.Formatters;


    public class SetPropertyListPropertySpecification<TEntity, TSchema, TValue> :
        PropertySpecification<TEntity, TSchema>,
        IPropertyListConfigurator<TValue>
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly Func<TextSlice, ValueList<TValue>> _valueProvider;
        readonly ValueSliceFactory _sliceFactory;

        public SetPropertyListPropertySpecification(PropertyInfo property, Func<TextSlice, ValueList<TValue>> valueProvider)
            : base(property, 0)
        {
            _valueProvider = valueProvider;
            _sliceFactory = Single;
        }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield break;
        }

        public override void Apply(IEntityConverterBuilder<TEntity, TSchema> builder)
        {
            var mapper = new ValueListEntityProperty<TEntity, TValue>(builder.ImplementationType, Property.Name, Position, GetValue, _sliceFactory);

            builder.Add(mapper);
        }

        public override void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder)
        {
            IValueFormatter<TValue> formatter = new ToStringValueFormatter<TValue>();
            ITextSliceProvider<TEntity> provider = new ValueListSliceProvider<TEntity, TValue>(Property, formatter);

            builder.Add(provider);
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            if (_valueProvider == null)
                yield return this.Null("ValueProvider");
        }

        TextSlice Single(TextSlice slice, int position)
        {
            TextSlice result;
            slice.TryGetSlice(position, out result);

            return result ?? Slice.Missing;
        }

        ValueList<TValue> GetValue(TextSlice slice)
        {
            return _valueProvider(slice);
        }
    }
}