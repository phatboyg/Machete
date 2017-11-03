namespace Machete.TranslateConfiguration.Specifications
{
    using System.Collections.Generic;
    using Configuration;
    using Translators;
    using Translators.EntityTranslators;


    public class CopyEntityTranslateSpecification<TEntity, TSchema> :
        ITranslateSpecification<TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly TranslateEntityFilter<TEntity, TSchema> _filter;

        public CopyEntityTranslateSpecification(TranslateEntityFilter<TEntity, TSchema> filter = null)
        {
            _filter = filter;
        }

        public string Name => "Copy";

        public void Apply(ITranslateBuilder<TSchema> builder)
        {
            builder.Add(new CopyEntityTranslator<TEntity, TSchema>(_filter));
        }

        public IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }
    }
}