namespace Machete.Translators
{
    using TranslateConfiguration;
    using TranslateConfiguration.Builders;


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
}