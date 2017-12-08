namespace Machete.TranslateConfiguration.Specifications
{
    using System.Collections.Generic;
    using System.Linq;
    using Configuration;


    public class TranslatorSpecification<TSchema> :
        ITranslatorSpecification<TSchema>,
        ITranslatorConfigurator<TSchema>
        where TSchema : Entity
    {
        readonly IList<ITranslatorSpecification<TSchema>> _specifications;

        public TranslatorSpecification()
        {
            _specifications = new List<ITranslatorSpecification<TSchema>>();
        }

        public string Name { get; set; }

        public void Apply(ITranslatorBuilder<TSchema> builder)
        {
            foreach (var specification in _specifications)
            {
                specification.Apply(builder);
            }
        }

        public void Add(ITranslatorSpecification<TSchema> specification)
        {
            _specifications.Add(specification);
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _specifications.SelectMany(x => x.Validate());
        }
    }
}