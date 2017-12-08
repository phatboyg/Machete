namespace Machete.X12.Translators
{
    using Machete.Translators;
    using TranslateConfiguration;
    using TranslateConfiguration.Builders;


    public class X12EntityTranslatorFactory<TResult, TInput, TSchema> :
        IEntityTranslatorFactory<TInput, TSchema>
        where TInput : TSchema
        where TSchema : X12Entity
        where TResult : TSchema
    {
        readonly IEntityTranslatorSpecification<TResult, TInput, TSchema> _specification;

        public X12EntityTranslatorFactory(IEntityTranslatorSpecification<TResult, TInput, TSchema> specification)
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