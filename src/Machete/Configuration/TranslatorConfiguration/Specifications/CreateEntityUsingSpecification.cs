namespace Machete.TranslatorConfiguration.Specifications
{
    using System.Collections.Generic;
    using Configuration;


    public class CreateEntityUsingSpecification<TTranslation, TResult, TSchema> :
        ICreatorSpecification<TSchema>
        where TResult : TSchema
        where TSchema : Entity
        where TTranslation : IEntityCreatorSpecification<TResult, TSchema>
    {
        readonly EntityCreatorSpecification<TResult, TSchema> _specification;
        public string Name => "Generate";

        public CreateEntityUsingSpecification()
        {
            _specification = new EntityCreatorSpecification<TResult, TSchema>();
        }

        public void Apply(ICreatorBuilder<TSchema> builder)
        {
            var entityTranslator = builder.CreateEntityTranslator<TTranslation, TResult>(_specification);

            builder.Add<TSchema>(entityTranslator);
        }
        
        public IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }
    }
}