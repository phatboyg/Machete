namespace Machete
{
    using System;
    using System.Collections.Generic;
    using Configuration;
    using TranslatorConfiguration;
    using TranslatorConfiguration.Configurators;
    using TranslatorConfiguration.Specifications;
    using Translators;


    /// <summary>
    /// Define a translator that can be used to translate an <see cref="EntityResult{TSchema}"/>.
    /// </summary>
    /// <typeparam name="TSchema"></typeparam>
    public abstract class Translation<TSchema> :
        ITranslatorSpecification<TSchema>
        where TSchema : Entity
    {
        readonly TranslatorSpecification<TSchema> _specification;

        protected Translation()
        {
            _specification = new TranslatorSpecification<TSchema>();

            _specification.Name = GetType().Name;
        }

        /// <summary>
        /// Exclude all entities of the specified entity type
        /// </summary>
        /// <typeparam name="T">The entity type</typeparam>
        protected void Exclude<T>()
            where T : TSchema
        {
            var specification = new ExcludeEntityTranslatorSpecification<T, TSchema>();

            _specification.Add(specification);
        }

        /// <summary>
        /// Exclude entities of the specified entity type that match the provided filter.
        /// </summary>
        /// <param name="filter"></param>
        /// <typeparam name="T"></typeparam>
        protected void Exclude<T>(TranslateEntityFilter<T, TSchema> filter)
            where T : TSchema
        {
            var specification = new ExcludeEntityTranslatorSpecification<T, TSchema>(filter);

            _specification.Add(specification);
        }

        /// <summary>
        /// Copy all entities of the specified entity type
        /// </summary>
        /// <typeparam name="T">The entity type</typeparam>
        protected void Copy<T>()
            where T : TSchema
        {
            var specification = new CopyEntityTranslatorSpecification<T, TSchema>();

            _specification.Add(specification);
        }

        /// <summary>
        /// Copy the entity if it matches the filter
        /// </summary>
        /// <param name="filter"></param>
        /// <typeparam name="T"></typeparam>
        protected void Copy<T>(TranslateEntityFilter<T, TSchema> filter)
            where T : TSchema
        {
            var specification = new CopyEntityTranslatorSpecification<T, TSchema>(filter);

            _specification.Add(specification);
        }

        protected void Translate<T>(Action<ITranslateEntityUsingConfigurator<T, TSchema>> configure)
            where T : TSchema
        {
            var configurator = new TranslateEntityUsingConfigurator<T, TSchema>(_specification);

            configure?.Invoke(configurator);
        }

        public string Name => _specification.Name;

        void ITranslatorSpecification<TSchema>.Apply(ITranslatorBuilder<TSchema> builder)
        {
            _specification.Apply(builder);
        }

        IEnumerable<ValidateResult> ISpecification.Validate()
        {
            return _specification.Validate();
        }
    }
}