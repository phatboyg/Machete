namespace Machete.TranslateConfiguration.Specifications
{
    using System.Collections.Generic;
    using Configuration;


    public class TranslateEntityInlineSpecification<TEntity, TSchema> :
        ITranslatorSpecification<TSchema>
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly IEntityTranslatorSpecification<TEntity, TEntity, TSchema> _specification;

        public TranslateEntityInlineSpecification(IEntityTranslatorSpecification<TEntity, TEntity, TSchema> specification)
        {
            _specification = specification;
        }

        public string Name => "Translate";

        public void Apply(ITranslatorBuilder<TSchema> builder)
        {
            var entityTranslator = builder.CreateEntityTranslator(_specification);

            builder.Add(entityTranslator);
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _specification.Validate();
        }
    }
}