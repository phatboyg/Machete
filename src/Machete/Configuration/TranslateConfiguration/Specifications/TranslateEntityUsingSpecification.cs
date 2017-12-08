namespace Machete.TranslateConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using Configuration;


    public class TranslateEntityUsingSpecification<TTranslate, TEntity, TSchema> :
        ITranslatorSpecification<TSchema>
        where TEntity : TSchema
        where TSchema : Entity
        where TTranslate : IEntityTranslatorSpecification<TEntity, TEntity, TSchema>
    {
        readonly Func<IEntityTranslatorSpecification<TEntity, TEntity, TSchema>> _specification;

        public TranslateEntityUsingSpecification(Func<IEntityTranslatorSpecification<TEntity, TEntity, TSchema>> specification)
        {
            _specification = specification;
        }

        public string Name => "Translate";

        public void Apply(ITranslatorBuilder<TSchema> builder)
        {
            var entityTranslator = builder.GetTranslator(typeof(TTranslate), _specification);

            builder.Add(entityTranslator);
        }

        public IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }
    }
}