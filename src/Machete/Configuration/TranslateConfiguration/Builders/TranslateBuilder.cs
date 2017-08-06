namespace Machete.TranslateConfiguration.Builders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Translators;


    public class TranslateBuilder<TSchema> :
        ITranslateBuilder<TSchema>
        where TSchema : Entity
    {
        readonly TranslateFactoryContext<TSchema> _context;
        readonly Dictionary<Type, IEntityTranslatorList<TSchema>> _translators;

        public TranslateBuilder(TranslateFactoryContext<TSchema> context)
        {
            _context = context;

            _translators = new Dictionary<Type, IEntityTranslatorList<TSchema>>();
        }

        public void Add<T>(IEntityTranslator<T, TSchema> translator)
            where T : TSchema
        {
            IEntityTranslatorList<TSchema> translatorList;
            if (!_translators.TryGetValue(typeof(T), out translatorList))
            {
                translatorList = new EntityTranslatorList<T, TSchema>();
                _translators[typeof(T)] = translatorList;
            }

            translatorList.Add(translator);
        }

        public IEntityTranslator<TInput, TSchema> GetTranslator<T, TInput>(Type translateSpecificationType,
            Func<IEntityTranslateSpecification<T, TInput, TSchema>> translateFactory)
            where T : TSchema
            where TInput : TSchema
        {
            return _context.GetEntityTranslator(translateSpecificationType, translateFactory);
        }

        public ITranslator<TSchema> Build()
        {
            return new Translator<TSchema>(_translators.ToDictionary(x => x.Key, x => x.Value.Build()));
        }
    }
}