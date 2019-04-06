namespace Machete.TranslatorConfiguration
{
    using System;
    using System.Collections.Generic;
    using Configuration;
    using Configurators;
    using Specifications;


    public class TranslateCreation<TSchema> :
        ICreatorSpecification<TSchema>
        where TSchema : Entity
    {
        readonly CreatorSpecification<TSchema> _specification;

        public TranslateCreation()
        {
            _specification = new CreatorSpecification<TSchema>();

            _specification.Name = GetType().Name;
        }

        public IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        public string Name { get; }
        public void Apply(ICreatorBuilder<TSchema> builder)
        {
            _specification.Apply(builder);
        }

        protected void Generate<T>(Action<ITranslateEntityCreatorUsingConfigurator<T, TSchema>> configure)
            where T : TSchema
        {
            var configurator = new TranslateEntityCreatorUsingConfigurator<T, TSchema>(_specification);

            configure?.Invoke(configurator);
        }
    }
}