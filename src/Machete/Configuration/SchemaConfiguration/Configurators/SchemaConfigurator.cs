namespace Machete.SchemaConfiguration.Configurators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Builders;
    using Configuration;
    using TypeSelectors;


    public class SchemaConfigurator<TSchema> :
        ISchemaConfigurator<TSchema>,
        ISpecification
        where TSchema : Entity
    {
        readonly IList<ISchemaSpecification<TSchema>> _specifications;
        readonly IEntityTypeSelectorFactory _entityTypeSelectorFactory;

        protected SchemaConfigurator(IEntityTypeSelectorFactory entityTypeSelectorFactory)
        {
            _entityTypeSelectorFactory = entityTypeSelectorFactory;

            _specifications = new List<ISchemaSpecification<TSchema>>();
        }

        public void Add(ISchemaSpecification<TSchema> specification)
        {
            if (specification == null)
                throw new ArgumentNullException(nameof(specification));

            _specifications.Add(specification);
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _specifications.SelectMany(x => x.Validate());
        }

        public ISchema<TSchema> Build()
        {
            var builder = new SchemaBuilder<TSchema>(_entityTypeSelectorFactory);

            foreach (var specification in _specifications)
            {
                specification.Apply(builder);
            }

            return builder.Build();
        }
    }
}