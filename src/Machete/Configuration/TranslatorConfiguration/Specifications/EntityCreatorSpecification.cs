namespace Machete.TranslatorConfiguration.Specifications
{
    using System.Collections.Generic;
    using System.Linq;
    using Configuration;


    public class EntityCreatorSpecification<TResult, TSchema> :
        IEntityCreatorSpecification<TResult, TSchema>,
        IEntityCreatorConfigurator<TResult, TSchema>
        where TResult : TSchema
        where TSchema : Entity
    {
        readonly IList<IPropertyCreatorSpecification<TResult, TSchema>> _specifications;

        public EntityCreatorSpecification()
        {
            _specifications = new List<IPropertyCreatorSpecification<TResult, TSchema>>();
        }

        public void Apply(IEntityCreatorBuilder<TResult, TSchema> builder)
        {
            foreach (var specification in _specifications)
            {
                specification.Apply(builder);
            }
        }

        public string Name { get; set; }

        public void Add(IPropertyCreatorSpecification<TResult, TSchema> specification)
        {
            _specifications.Add(specification);
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _specifications.SelectMany(x => x.Validate());
        }
    }
}