namespace Machete.TranslateConfiguration
{
    public class TranslateFactory<TResult, TInput, TSchema> :
        ITranslateFactory<TInput, TSchema>
        where TInput : TSchema
        where TSchema : Entity
        where TResult : TSchema
    {
        readonly ITranslateSpecification<TResult, TInput, TSchema> _specification;

        public TranslateFactory(ITranslateSpecification<TResult, TInput, TSchema> specification)
        {
            _specification = specification;
        }

        public ITranslator<TInput, TSchema> Create(TranslateFactoryContext<TSchema> context)
        {
            var builder = new TranslateBuilder<TResult, TInput, TSchema>(context);

            _specification.Apply(builder);

            return builder.Build();

        }
    }
}