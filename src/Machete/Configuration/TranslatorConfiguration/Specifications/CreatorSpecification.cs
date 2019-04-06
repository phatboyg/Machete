namespace Machete.TranslatorConfiguration.Specifications
{
    using System.Collections.Generic;
    using System.Linq;
    using Configuration;


    public class CreatorSpecification<TSchema> :
        ICreatorSpecification<TSchema>,
        ICreatorConfigurator<TSchema>
        where TSchema : Entity
    {
        readonly List<ICreatorSpecification<TSchema>> _specifications;

        public CreatorSpecification()
        {
            _specifications = new List<ICreatorSpecification<TSchema>>();
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _specifications.SelectMany(x => x.Validate());
        }

        public string Name { get; set; }
        public void Add(ICreatorSpecification<TSchema> specification)
        {
            _specifications.Add(specification);
        }

        public void Apply(ICreatorBuilder<TSchema> builder)
        {
            foreach (var specification in _specifications)
            {
                specification.Apply(builder);
            }
        }
    }
}