namespace Machete.TranslatorConfiguration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Builders;
    using Translators;


    public interface ICreatorBuilder<TSchema>
        where TSchema : Entity
    {
        void Add<T>(IEntityCreator<TSchema> translator)
            where T : TSchema;

        /// <summary>
        /// Get a translator, specifying the factory if the translator doesn't already exist
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TTranslation"></typeparam>
        /// <returns></returns>
        IEntityTranslator<TInput, TSchema> GetEntityTranslator<T, TInput, TTranslation>()
            where T : TSchema
            where TInput : TSchema
            where TTranslation : IEntityTranslatorSpecification<T, TInput, TSchema>, new();

        /// <summary>
        /// Create an entity translator, using the provided specification, and do not cache it.
        /// </summary>
        /// <param name="specification"></param>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TSchema"></typeparam>
        /// <typeparam name="TTranslation"></typeparam>
        /// <returns></returns>
        IEntityCreator<TSchema> CreateEntityTranslator<TTranslation, TResult>(IEntityCreatorSpecification<TResult, TSchema> specification)
            where TResult : TSchema
            where TTranslation : IEntityCreatorSpecification<TResult, TSchema>;
    }


    public class CreatorBuilder<TSchema> :
        ICreatorBuilder<TSchema>
        where TSchema : Entity
    {
        readonly string _name;
        readonly TranslatorFactoryContext<TSchema> _context;
        readonly Dictionary<Type, IEntityCreatorList<TSchema>> _translators;

        public CreatorBuilder(string name, TranslatorFactoryContext<TSchema> context)
        {
            _name = name;
            _context = context;

            _translators = new Dictionary<Type, IEntityCreatorList<TSchema>>();
        }

        public void Add<T>(IEntityCreator<TSchema> translator)
            where T : TSchema
        {
            if (!_translators.TryGetValue(typeof(T), out var translatorList))
            {
                translatorList = new EntityCreatorList<TSchema>();
                _translators[typeof(T)] = translatorList;
            }

            translatorList.Add<T>(translator);
        }

        public IEntityTranslator<TInput, TSchema> GetEntityTranslator<T, TInput, TTranslation>()
            where T : TSchema
            where TInput : TSchema
            where TTranslation : IEntityTranslatorSpecification<T, TInput, TSchema>, new()
        {
            return _context.GetEntityTranslator<T, TInput, TTranslation>();
        }

        public IEntityCreator<TSchema> CreateEntityTranslator<TTranslation, TResult>(IEntityCreatorSpecification<TResult, TSchema> specification)
            where TTranslation : IEntityCreatorSpecification<TResult, TSchema>
            where TResult : TSchema
        {
            return _context.CreateEntityCreator(specification);
        }

        public ICreator<TSchema> Build()
        {
            return new TranslateCreator<TSchema>(_name, _translators.ToDictionary(x => x.Key, x => x.Value.Build()));
        }
    }
}