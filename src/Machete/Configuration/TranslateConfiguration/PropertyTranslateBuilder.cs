namespace Machete.TranslateConfiguration
{
    using System.Collections.Generic;
    using Translators;


    public class PropertyTranslateBuilder<TResult, TInput, TSchema> :
        IPropertyTranslateBuilder<TResult, TInput, TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        readonly List<IEntityPropertyTranslator<TResult, TInput, TSchema>> _translaters;

        public PropertyTranslateBuilder()
        {
            _translaters = new List<IEntityPropertyTranslator<TResult, TInput, TSchema>>();
        }

        public void Add(IEntityPropertyTranslator<TResult, TInput, TSchema> translator)
        {
            _translaters.Add(translator);
        }

        public IEntityPropertyTranslator<TResult, TInput, TSchema> Build()
        {
            if (_translaters.Count == 1)
                return _translaters[0];

            return new EntityPropertyTranslatorList<TResult, TInput, TSchema>(_translaters);
        }

        public bool IsDefined => _translaters.Count > 0;
    }
}