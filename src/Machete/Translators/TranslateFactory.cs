namespace Machete.Translators
{
    using TranslateConfiguration;
    using TranslateConfiguration.Builders;


    public class TranslateFactory<TSchema> :
        ITranslateFactory<TSchema>
        where TSchema : Entity
    {
        readonly ITranslateSpecification<TSchema> _specification;

        public TranslateFactory(ITranslateSpecification<TSchema> specification)
        {
            _specification = specification;
        }

        public ITranslator<TSchema> Create(TranslateFactoryContext<TSchema> context)
        {
            var builder = new TranslateBuilder<TSchema>(context);

            _specification.Apply(builder);

            return builder.Build();
        }
    }
}