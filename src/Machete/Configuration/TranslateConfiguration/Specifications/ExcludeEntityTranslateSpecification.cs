namespace Machete.TranslateConfiguration.Specifications
{
    using System.Collections.Generic;
    using Configuration;
    using Translators;


    public class ExcludeEntityTranslateSpecification<TEntity, TSchema> :
        ITranslateSpecification<TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly TranslateEntityFilter<TEntity, TSchema> _filter;

        public ExcludeEntityTranslateSpecification(TranslateEntityFilter<TEntity, TSchema> filter = null)
        {
            _filter = filter;
        }

        public void Apply(ITranslateBuilder<TSchema> builder)
        {
            builder.Add(new ExcludeEntityTranslator<TEntity, TSchema>(_filter));
        }

        public IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }
    }
}