namespace Machete.TranslateConfiguration.Specifications
{
    using System.Collections.Generic;
    using System.Linq;
    using Configuration;


    public class EntityTranslatorSpecification<TResult, TInput, TSchema> :
        IEntityTranslatorSpecification<TResult, TInput, TSchema>,
        IEntityTranslatorConfigurator<TResult, TInput, TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        readonly IList<IPropertyTranslatorSpecification<TResult, TInput, TSchema>> _specifications;

        public EntityTranslatorSpecification()
        {
            _specifications = new List<IPropertyTranslatorSpecification<TResult, TInput, TSchema>>();
        }

        public void Apply(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder)
        {
            foreach (var specification in _specifications)
            {
                specification.Apply(builder);
            }
        }

        public string Name { get; set; }

        public void Add(IPropertyTranslatorSpecification<TResult, TInput, TSchema> specification)
        {
            _specifications.Add(specification);
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _specifications.SelectMany(x => x.Validate());
        }
    }
}