namespace Machete.TranslateConfiguration.Specifications
{
    using System;


    public class TranslateEntityUsingConfigurator<TEntity, TSchema> :
        ITranslateEntityUsingConfigurator<TEntity, TSchema>
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly ITranslatorConfigurator<TSchema> _configurator;

        public TranslateEntityUsingConfigurator(ITranslatorConfigurator<TSchema> configurator)
        {
            _configurator = configurator;
        }

        public void Using<T>()
            where T : IEntityTranslatorSpecification<TEntity, TEntity, TSchema>, new()
        {
            var specification = new TranslateEntityUsingSpecification<T, TEntity, TSchema>();

            _configurator.Add(specification);
        }

        public void By(Action<IEntityTranslatorConfigurator<TEntity, TEntity, TSchema>> configure)
        {
            var specification = new EntityTranslatorSpecification<TEntity, TEntity, TSchema>();

            configure?.Invoke(specification);

            var translateSpecification = new TranslateEntityInlineSpecification<TEntity, TSchema>(specification);

            _configurator.Add(translateSpecification);
        }
    }
}