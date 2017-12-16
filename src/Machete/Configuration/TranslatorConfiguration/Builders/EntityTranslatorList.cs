namespace Machete.TranslatorConfiguration.Builders
{
    using System;
    using System.Collections.Generic;
    using Internals.Extensions;


    public class EntityTranslatorList<TInput, TSchema> :
        IEntityTranslatorList<TSchema>
        where TSchema : Entity
        where TInput : TSchema
    {
        readonly IList<IEntityTranslator<TInput, TSchema>> _translators;

        public EntityTranslatorList()
        {
            _translators = new List<IEntityTranslator<TInput, TSchema>>();
        }

        public void Add<T>(IEntityTranslator<T, TSchema> translator)
            where T : TSchema
        {
            if (translator is IEntityTranslator<TInput, TSchema> entityTranslator)
                _translators.Add(entityTranslator);
            else
                throw new ArgumentException($"The translator entity type was invalid: {TypeCache<T>.ShortName} (expected: {TypeCache<TInput>.ShortName}");
        }

        public IEntityTranslator<TSchema> Build()
        {
            if (_translators.Count == 1)
                return _translators[0];

            // TODO: Must have one that starts and runs them in order
            return _translators[0];
        }
    }
}