namespace Machete.Translators
{
    using TranslatorConfiguration;
    using TranslatorConfiguration.Builders;


    public class TranslatorFactory<TSchema> :
        ITranslatorFactory<TSchema>
        where TSchema : Entity
    {
        readonly ITranslatorSpecification<TSchema> _specification;

        public TranslatorFactory(ITranslatorSpecification<TSchema> specification)
        {
            _specification = specification;
        }

        public ITranslator<TSchema> Create(TranslatorFactoryContext<TSchema> context)
        {
            var builder = new TranslatorBuilder<TSchema>(_specification.Name, context);

            _specification.Apply(builder);

            return builder.Build();
        }
    }
}