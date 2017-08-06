namespace Machete.HL7.Translators
{
    using Machete.TranslateConfiguration;
    using Machete.TranslateConfiguration.Builders;
    using Machete.Translators;
    using TranslateConfiguration.Visitors;


    public class Hl7EntityTranslateFactory<TResult, TInput, TSchema> :
        IEntityTranslateFactory<TInput, TSchema>
        where TInput : TSchema
        where TSchema : HL7Entity
        where TResult : TSchema
    {
        readonly IEntityTranslateSpecification<TResult, TInput, TSchema> _specification;

        public Hl7EntityTranslateFactory(IEntityTranslateSpecification<TResult, TInput, TSchema> specification)
        {
            _specification = specification;
        }

        public IEntityTranslator<TInput, TSchema> Create(TranslateFactoryContext<TSchema> context)
        {
            var builder = new EntityTranslateBuilder<TResult, TInput, TSchema>(context);

            builder.CopyPropertyVisitor = new HL7CopyTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>(builder);
            builder.MissingPropertyVisitor = new HL7MissingTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>(builder);

            _specification.Apply(builder);

            return builder.Build();
        }
    }
}