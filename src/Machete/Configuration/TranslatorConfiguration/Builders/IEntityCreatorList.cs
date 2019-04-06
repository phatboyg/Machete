namespace Machete.TranslatorConfiguration.Builders
{
    using System;
    using System.Collections.Generic;
    using Internals.Extensions;


    public interface IEntityCreatorList<TSchema>
        where TSchema : Entity
    {
        void Add<T>(IEntityCreator<TSchema> translator)
            where T : TSchema;

        IEntityCreator<TSchema> Build();
    }


    public class EntityCreatorList<TSchema> :
        IEntityCreatorList<TSchema>
        where TSchema : Entity
    {
        readonly List<IEntityCreator<TSchema>> _translators;

        public EntityCreatorList()
        {
            _translators = new List<IEntityCreator<TSchema>>();
        }

        public void Add<T>(IEntityCreator<TSchema> translator)
            where T : TSchema
        {
            if (translator is IEntityCreator<TSchema> entityTranslator)
                _translators.Add(entityTranslator);
            else
                throw new ArgumentException($"The translator entity type was invalid: {TypeCache<T>.ShortName} (expected: {TypeCache<TSchema>.ShortName}");
        }

        public IEntityCreator<TSchema> Build()
        {
            if (_translators.Count == 1)
                return _translators[0];

            // TODO: Must have one that starts and runs them in order
            return _translators[0];
        }
    }
}