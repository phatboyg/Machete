namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Entities.EntityProperties;
    using Internals.Extensions;
    using Slices;


    /// <summary>
    /// The base property specification
    /// </summary>
    /// <typeparam name="TEntity">The entity type being configured</typeparam>
    /// <typeparam name="TSchema">The schema type</typeparam>
    /// <typeparam name="TValue"></typeparam>
    public abstract class PropertySpecification<TEntity, TSchema, TValue> :
        IEntityPropertySpecification<TEntity, TSchema>,
        IPropertyConfigurator
        where TEntity : TSchema
        where TSchema : Entity
    {
        ValueSliceProvider _sliceProvider;

        protected PropertySpecification(PropertyInfo property, int position)
        {
            Property = property;
            Position = position;
        }

        IEnumerable<ValidateResult> ISpecification.Validate()
        {
            if (Property == null)
                yield return this.Null(nameof(Property));
            if (Position < 0)
                yield return this.Error("Must be >= 0", nameof(Position));
            if (MinLength < 0 || MinLength > MaxLength)
                yield return this.Error("Must be >= 0 and <= MaxLength", nameof(MinLength));
            if (MaxLength < 0 || MaxLength < MinLength)
                yield return this.Error("Must be >= 0 and >= MinLength", nameof(MaxLength));

            foreach (var result in Validate())
            {
                yield return result;
            }
        }

        public void SetParent()
        {
            _sliceProvider = Parent;
        }

        public void SetSingle()
        {
            _sliceProvider = Single;
        }

        public void SetList()
        {
            _sliceProvider = List;
        }

        public void SetRange()
        {
            _sliceProvider = Range;
        }

        public abstract IEnumerable<Type> GetReferencedEntityTypes();

        public abstract void Apply(IEntityConverterBuilder<TEntity, TSchema> builder);

        public abstract void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder);

        protected abstract IEnumerable<ValidateResult> Validate();

        protected PropertyInfo Property { get; }
        protected ValueSliceProvider SliceProvider => _sliceProvider;

        public int Position { get; set; }
        public bool Required { get; set; }
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public FormatOptions Formatting { get; set; }

        TextSlice Single(TextSlice slice, int position)
        {
            slice.TryGetSlice(position, out var result);

            return result ?? Slice.Missing;
        }

        TextSlice Parent(TextSlice slice, int position)
        {
            return slice ?? Slice.Missing;
        }

        TextSlice List(TextSlice slice, int position)
        {
            if (slice.TryGetSlice(position, out var result))
            {
                if (result is ListTextSlice list && list.TryGetListSlice(out result))
                    return result;

                throw new MacheteParserException($"The slice is not a list: {TypeCache<TEntity>.ShortName}.ValueList<{TypeCache<TValue>.ShortName}> {Property.Name}");
            }

            return Slice.Missing;
        }

        TextSlice Range(TextSlice slice, int position)
        {
            return new RangeTextSlice(slice, position);
        }
    }
}