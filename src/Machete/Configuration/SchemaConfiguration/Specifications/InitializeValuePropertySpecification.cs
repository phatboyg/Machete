namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Configuration;
    using Entities.EntityProperties;


    public class InitializeValuePropertySpecification<TEntity, TSchema, TValue> :
        IEntityPropertySpecification<TEntity, TSchema>
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly PropertyInfo _property;
        readonly TValue _value;

        public InitializeValuePropertySpecification(PropertyInfo property, TValue value)
        {
            _property = property;
            _value = value;
        }

        public IEnumerable<Type> GetReferencedEntityTypes()
        {
            return Enumerable.Empty<Type>();
        }

        public void Apply(IEntityConverterBuilder<TEntity, TSchema> builder)
        {
            var initializer = new InitializeEntityProperty<TEntity, TValue>(builder.ImplementationType, _property.Name, _value);

            builder.Add(initializer);
        }

        public void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder)
        {
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return Enumerable.Empty<ValidateResult>();
        }
    }
}