namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Entities.EntityProperties;
    using Formatters;
    using Values.Formatters;


    public class InitializeValuePropertySpecification<TEntity, TSchema, TValue> :
        PropertySpecification<TEntity, TSchema, TValue>
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly TValue _value;

        public InitializeValuePropertySpecification(PropertyInfo property, int position, TValue value)
            : base(property, position)
        {
            _value = value;

            SetParent();
        }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield break;
        }

        public override void Apply(IEntityConverterBuilder<TEntity, TSchema> builder)
        {
            var initializer = new InitializeEntityProperty<TEntity, TValue>(builder.ImplementationType, Property.Name, _value);

            builder.Add(initializer);
        }

        public override void Apply(IEntityFormatterBuilder<TEntity, TSchema> builder)
        {
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }
    }
}