namespace Machete.TranslateConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using Configuration;


    public class TranslateEntityUsingSpecification<TTranslate, TEntity, TSchema> :
        ITranslateSpecification<TSchema>
        where TEntity : TSchema
        where TSchema : Entity
        where TTranslate : IEntityTranslateSpecification<TEntity, TEntity, TSchema>
    {
        readonly Func<IEntityTranslateSpecification<TEntity, TEntity, TSchema>> _specification;

        public TranslateEntityUsingSpecification(Func<IEntityTranslateSpecification<TEntity, TEntity, TSchema>> specification)
        {
            _specification = specification;
        }

        public void Apply(ITranslateBuilder<TSchema> builder)
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