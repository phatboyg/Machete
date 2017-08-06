namespace Machete.TranslateConfiguration.Specifications
{
    using System.Collections.Generic;
    using System.Linq;
    using Configuration;


    public class TranslateSpecification<TSchema> :
        ITranslateSpecification<TSchema>,
        ITranslateConfigurator<TSchema>
        where TSchema : Entity
    {
        readonly IList<ITranslateSpecification<TSchema>> _specifications;

        public TranslateSpecification()
        {
            _specifications = new List<ITranslateSpecification<TSchema>>();
        }

        public void Apply(ITranslateBuilder<TSchema> builder)
        {
            foreach (var specification in _specifications)
            {
                specification.Apply(builder);
            }
        }

        public void Add(ITranslateSpecification<TSchema> specification)
        {
            _specifications.Add(specification);
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _specifications.SelectMany(x => x.Validate());
        }
    }
}