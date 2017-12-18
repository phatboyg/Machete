namespace Machete.Translators
{
    using TranslatorConfiguration;
    using TranslatorConfiguration.Builders;


    public class EntityTranslatorFactory<TResult, TInput, TSchema> :
        IEntityTranslatorFactory<TInput, TSchema>
        where TInput : TSchema
        where TSchema : Entity
        where TResult : TSchema
    {
        readonly IEntityTranslatorSpecification<TResult, TInput, TSchema> _specification;

        public EntityTranslatorFactory(IEntityTranslatorSpecification<TResult, TInput, TSchema> specification)
        {
            _specification = specification;
        }

        public IEntityTranslator<TInput, TSchema> Create(TranslatorFactoryContext<TSchema> context)
        {
            var builder = new EntityTranslatorBuilder<TResult, TInput, TSchema>(context, _specification.Name);

            _specification.Apply(builder);

            return builder.Build();
        }
    }
    
    public class EntityCreatorFactory<TResult, TSchema> :
        IEntityCreatorFactory<TSchema>
        where TSchema : Entity
        where TResult : TSchema
    {
        readonly IEntityCreatorSpecification<TResult, TSchema> _specification;

        public EntityCreatorFactory(IEntityCreatorSpecification<TResult, TSchema> specification)
        {
            _specification = specification;
        }

        public IEntityCreator<TSchema> Create(TranslatorFactoryContext<TSchema> context)
        {
            var builder = new EntityCreatorBuilder<TResult, TSchema>(context, _specification.Name);

            _specification.Apply(builder);

            return builder.Build();
        }
    }
}