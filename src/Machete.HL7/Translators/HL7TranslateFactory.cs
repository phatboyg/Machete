namespace Machete.HL7.Translators
{
    using Configuration.TranslateConfiguration.Visitors;
    using Machete.Translators;
    using TranslateConfiguration;
    using TranslateConfiguration.Builders;


    public class HL7TranslateFactory<TResult, TInput, TSchema> :
        ITranslateFactory<TInput, TSchema>
        where TInput : TSchema
        where TSchema : HL7Entity
        where TResult : TSchema
    {
        readonly ITranslateSpecification<TResult, TInput, TSchema> _specification;

        public HL7TranslateFactory(ITranslateSpecification<TResult, TInput, TSchema> specification)
        {
            _specification = specification;
        }

        public ITranslator<TInput, TSchema> Create(TranslateFactoryContext<TSchema> context)
        {
            var builder = new TranslateBuilder<TResult, TInput, TSchema>(context);

            builder.CopyPropertyVisitor = new HL7CopyTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>(builder);
            builder.MissingPropertyVisitor = new HL7MissingTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>(builder);

            _specification.Apply(builder);

            return builder.Build();
        }
    }
}