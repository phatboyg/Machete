namespace Machete.TranslatorConfiguration.Configurators
{
    using Specifications;


    public class TranslateEntityCreatorUsingConfigurator<TEntity, TSchema> :
        ITranslateEntityCreatorUsingConfigurator<TEntity, TSchema>
        where TEntity : TSchema
        where TSchema : Entity
    {
        readonly ICreatorConfigurator<TSchema> _configurator;

        public TranslateEntityCreatorUsingConfigurator(ICreatorConfigurator<TSchema> configurator)
        {
            _configurator = configurator;
        }

        public void Using<T>()
            where T : IEntityCreatorSpecification<TEntity, TSchema>, new()
        {
            var specification = new CreateEntityUsingSpecification<T, TEntity, TSchema>();

            _configurator.Add(specification);
        }

//        public void By(Action<IEntityCreatorConfigurator<TEntity, TSchema>> configure)
//        {
//            var specification = new EntityCreatorSpecification<TEntity, TEntity, TSchema>();
//
//            configure?.Invoke(specification);
//
//            var translateSpecification = new TranslateEntityInlineSpecification<TEntity, TSchema>(specification);
//
//            _configurator.Add(translateSpecification);
//        }
    }
}