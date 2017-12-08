namespace Machete.TranslateConfiguration.Specifications
{
    using System.Collections.Generic;
    using Configuration;
    using Translators;
    using Translators.EntityTranslators;


    public class ExcludeEntityTranslatorSpecification<TEntity, TSchema> :
        ITranslatorSpecification<TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly TranslateEntityFilter<TEntity, TSchema> _filter;

        public ExcludeEntityTranslatorSpecification(TranslateEntityFilter<TEntity, TSchema> filter = null)
        {
            _filter = filter;
        }

        public string Name => "Exclude";

        public void Apply(ITranslatorBuilder<TSchema> builder)
        {
            builder.Add(new ExcludeEntityTranslator<TEntity, TSchema>(_filter));
        }

        public IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }
    }
}