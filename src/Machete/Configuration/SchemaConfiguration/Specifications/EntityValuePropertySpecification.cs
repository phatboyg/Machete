namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Internals.Extensions;
    using PropertyMappers;
    using Slices.Providers;
    using Values;


    public class EntityValuePropertySpecification<TEntity, TSchema, TEntityValue> :
        PropertySpecification<TEntity, TSchema, TEntityValue>,
        IEntityValueConfigurator<TEntityValue>
        where TSchema : Entity
        where TEntity : TSchema
        where TEntityValue : TSchema
    {
        public EntityValuePropertySpecification(PropertyInfo property, int position)
            : base(property, position)
        {
        }

        public override IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield return typeof(TEntityValue);
        }

        public override void Apply(IEntityMapBuilder<TEntity, TSchema> builder)
        {
            IEntityMap<TEntityValue> entityMap = builder.GetEntityMap<TEntityValue>();

            var mapper = new SingleSliceValuePropertyMapper<TEntity, TEntityValue>(builder.ImplementationType, Property.Name, Position, x => Factory(x, entityMap));

            ITextSliceProvider<TEntity> provider = new EntityValueSliceProvider<TEntity, TEntityValue>(Property, entityMap);

            builder.AddValue(mapper, provider);
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            if (!typeof(TEntityValue).IsInterface)
                yield return this.Error("Entity values must be interfaces", "EntityType", TypeCache<TEntityValue>.ShortName);
        }

        static Value<TEntityValue> Factory(TextSlice slice, IEntityMap<TEntityValue> entityMap)
        {
            var value = entityMap.GetEntity(slice);

            return new ConvertedValue<TEntityValue>(slice, value);
        }
    }
}