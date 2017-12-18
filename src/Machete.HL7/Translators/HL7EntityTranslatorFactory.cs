namespace Machete.HL7.Translators
{
    using Machete.TranslatorConfiguration;
    using Machete.TranslatorConfiguration.Builders;
    using Machete.Translators;
    using TranslatorConfiguration.Visitors;


    public class HL7EntityTranslatorFactory<TResult, TInput, TSchema> :
        IEntityTranslatorFactory<TInput, TSchema>
        where TInput : TSchema
        where TSchema : HL7Entity
        where TResult : TSchema
    {
        readonly IEntityTranslatorSpecification<TResult, TInput, TSchema> _specification;

        public HL7EntityTranslatorFactory(IEntityTranslatorSpecification<TResult, TInput, TSchema> specification)
        {
            _specification = specification;
        }

        public IEntityTranslator<TInput, TSchema> Create(TranslatorFactoryContext<TSchema> context)
        {
            var builder = new EntityTranslatorBuilder<TResult, TInput, TSchema>(context, _specification.Name);

            builder.CopyPropertyVisitor = new HL7CopyTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>(builder);
            builder.MissingPropertyVisitor = new HL7MissingTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>(builder);

            _specification.Apply(builder);

            return builder.Build();
        }
    }
    
    public class HL7EntityCreatorFactory<TResult, TSchema> :
        IEntityCreatorFactory<TSchema>
        where TSchema : HL7Entity
        where TResult : TSchema
    {
        readonly IEntityCreatorSpecification<TResult, TSchema> _specification;

        public HL7EntityCreatorFactory(IEntityCreatorSpecification<TResult, TSchema> specification)
        {
            _specification = specification;
        }

        public IEntityCreator<TSchema> Create(TranslatorFactoryContext<TSchema> context)
        {
            var builder = new EntityCreatorBuilder<TResult, TSchema>(context, _specification.Name);

            builder.MissingPropertyVisitor = new HL7MissingCreatorBuilderPropertyVisitor<TResult, TSchema>(builder);

            _specification.Apply(builder);

            return builder.Build();
        }
    }
}