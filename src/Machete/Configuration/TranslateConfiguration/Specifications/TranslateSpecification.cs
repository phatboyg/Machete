namespace Machete.TranslateConfiguration.Specifications
{
    using System.Collections.Generic;
    using System.Linq;
    using Configuration;


    public class TranslateSpecification<TResult, TInput, TSchema> :
        ITranslateSpecification<TResult, TInput, TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        readonly IList<IPropertyTranslateSpecification<TResult, TInput, TSchema>> _specifications;

        public TranslateSpecification()
        {
            _specifications = new List<IPropertyTranslateSpecification<TResult, TInput, TSchema>>();
        }

        public void Apply(ITranslateBuilder<TResult, TInput, TSchema> builder)
        {
            foreach (var specification in _specifications)
            {
                specification.Apply(builder);
            }
        }

        public void Add(IPropertyTranslateSpecification<TResult, TInput, TSchema> specification)
        {
            _specifications.Add(specification);
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _specifications.SelectMany(x => x.Validate());
        }
    }
}