namespace Machete.TranslatorConfiguration.Specifications
{
    using System.Collections.Generic;
    using Configuration;


    public class TranslateEntityUsingSpecification<TTranslation, TEntity, TSchema> :
        ITranslatorSpecification<TSchema>
        where TEntity : TSchema
        where TSchema : Entity
        where TTranslation : IEntityTranslatorSpecification<TEntity, TEntity, TSchema>, new()
    {
        public string Name => "Translate";

        public void Apply(ITranslatorBuilder<TSchema> builder)
        {
            var entityTranslator = builder.GetEntityTranslator<TEntity, TEntity, TTranslation>();

            builder.Add(entityTranslator);
        }

        public IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }
    }
}