namespace Machete.TranslatorConfiguration.Specifications
{
    using System.Collections.Generic;
    using Configuration;
    using Translators;
    using Translators.EntityTranslators;


    public class CopyEntityTranslatorSpecification<TEntity, TSchema> :
        ITranslatorSpecification<TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly TranslateEntityFilter<TEntity, TSchema> _filter;

        public CopyEntityTranslatorSpecification(TranslateEntityFilter<TEntity, TSchema> filter = null)
        {
            _filter = filter;
        }

        public string Name => "Copy";

        public void Apply(ITranslatorBuilder<TSchema> builder)
        {
            builder.Add(new CopyEntityTranslator<TEntity, TSchema>(_filter));
        }

        public IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }
    }
}