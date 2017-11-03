namespace Machete
{
    using System;
    using System.Collections.Generic;
    using Configuration;
    using TranslateConfiguration;
    using TranslateConfiguration.Specifications;
    using Translators;


    /// <summary>
    /// Define a translator that can be used to translate an <see cref="EntityResult{TSchema}"/>.
    /// </summary>
    /// <typeparam name="TSchema"></typeparam>
    public abstract class TranslateMap<TSchema> :
        ITranslateSpecification<TSchema>
        where TSchema : Entity
    {
        readonly TranslateSpecification<TSchema> _specification;

        protected TranslateMap()
        {
            _specification = new TranslateSpecification<TSchema>();

            _specification.Name = GetType().Name;
        }

        /// <summary>
        /// Exclude all entities of the specified entity type
        /// </summary>
        /// <typeparam name="T">The entity type</typeparam>
        protected void Exclude<T>()
            where T : TSchema
        {
            var specification = new ExcludeEntityTranslateSpecification<T, TSchema>();

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
            var specification = new ExcludeEntityTranslateSpecification<T, TSchema>(filter);

            _specification.Add(specification);
        }

        /// <summary>
        /// Copy all entities of the specified entity type
        /// </summary>
        /// <typeparam name="T">The entity type</typeparam>
        protected void Copy<T>()
            where T : TSchema
        {
            var specification = new CopyEntityTranslateSpecification<T, TSchema>();

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
            var specification = new CopyEntityTranslateSpecification<T, TSchema>(filter);

            _specification.Add(specification);
        }

        protected void Translate<T>(Action<ITranslateEntityUsingConfigurator<T, TSchema>> configure)
            where T : TSchema
        {
            var configurator = new TranslateEntityUsingConfigurator<T, TSchema>(_specification);

            configure?.Invoke(configurator);
        }

        public string Name => _specification.Name;

        void ITranslateSpecification<TSchema>.Apply(ITranslateBuilder<TSchema> builder)
        {
            _specification.Apply(builder);
        }

        IEnumerable<ValidateResult> ISpecification.Validate()
        {
            return _specification.Validate();
        }
    }
}