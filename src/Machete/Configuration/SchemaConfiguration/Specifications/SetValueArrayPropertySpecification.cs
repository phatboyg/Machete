namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using PropertyMappers;
    using Slices.Providers;
    using Values.Formatters;


    public class SetValueArrayPropertySpecification<TEntity, TSchema, TValue> :
        PropertySpecification<TEntity, TSchema, TValue>,
        IValueArrayConfigurator<TValue>
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly Func<TextSlice, ValueArray<TValue>> _valueProvider;
        readonly ValueSliceFactory _sliceFactory;

        public SetValueArrayPropertySpecification(PropertyInfo property, Func<TextSlice, ValueArray<TValue>> valueProvider)
            : base(property, 0)
        {
            _valueProvider = valueProvider;
            _sliceFactory = Single;
        }

        public override void Apply(IEntityMapBuilder<TEntity, TSchema> builder)
        {
            var mapper = new ValueArrayPropertyMapper<TEntity, TValue>(builder.ImplementationType, Property.Name, Position, GetValue, _sliceFactory);

            // TODO will need formatter eventually cached,shared

            IValueFormatter<TValue> formatter = new ToStringValueFormatter<TValue>();

            ITextSliceProvider<TEntity> provider = new ValueArraySliceProvider<TEntity, TValue>(Property, formatter);

            builder.AddValue(mapper, provider);
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

        ValueArray<TValue> GetValue(TextSlice slice)
        {
            return _valueProvider(slice);
        }
    }
}