namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Configuration;
    using Entities.EntityProperties;


    public class InitializeValuePropertySpecification<TEntity, TSchema, TValue> :
        IEntityPropertySpecification<TEntity, TSchema>
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly string _propertyName;
        readonly TValue _value;

        public InitializeValuePropertySpecification(string propertyName, TValue value)
        {
            _value = value;
            _propertyName = propertyName;
        }

        public IEnumerable<Type> GetReferencedEntityTypes()
        {
            return Enumerable.Empty<Type>();
        }

        public void Apply(IEntityConverterBuilder<TEntity, TSchema> builder)
        {
            var initializer = new PropertyEntityInitializer<TEntity, TValue>(_propertyName, _value);

            builder.Add(initializer);
        }

        public void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder)
        {
        }

        public IEnumerable<ValidateResult> Validate()
        {
            if (string.IsNullOrWhiteSpace(_propertyName))
                yield return this.Error("must not be null", "PropertyName");
        }
    }
}