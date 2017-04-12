namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;


    public abstract class PropertySpecification<TEntity, TSchema, TValue> :
        IPropertySpecification<TEntity, TSchema>,
        IValueConfigurator<TValue>
        where TEntity : TSchema
        where TSchema : Entity
    {
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

        public IEnumerable<Type> GetReferencedEntityTypes()
        {
            throw new NotImplementedException();
        }

        public virtual void Apply(IEntityMapBuilder<TEntity, TSchema> builder)
        {
            throw new NotImplementedException();
        }

        protected abstract IEnumerable<ValidateResult> Validate();

        protected PropertyInfo Property { get; }

        public int Position { get; set; }
        public bool Required { get; set; }
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
    }
}