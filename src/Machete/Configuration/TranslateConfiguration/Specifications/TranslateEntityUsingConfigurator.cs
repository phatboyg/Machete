namespace Machete.TranslateConfiguration.Specifications
{
    using System;


    public class TranslateEntityUsingConfigurator<TEntity, TSchema> :
        ITranslateEntityUsingConfigurator<TEntity, TSchema>
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly ITranslateConfigurator<TSchema> _configurator;

        public TranslateEntityUsingConfigurator(ITranslateConfigurator<TSchema> configurator)
        {
            _configurator = configurator;
        }

        public void Using<T>(Func<T> specificationFactory)
            where T : IEntityTranslateSpecification<TEntity, TEntity, TSchema>
        {
            var specification = new TranslateEntityUsingSpecification<T, TEntity, TSchema>(() => specificationFactory());

            _configurator.Add(specification);
        }

        public void Using<T>()
            where T : IEntityTranslateSpecification<TEntity, TEntity, TSchema>, new()
        {
            var specification = new TranslateEntityUsingSpecification<T, TEntity, TSchema>(() => new T());

            _configurator.Add(specification);
        }
    }
}