namespace Machete.TranslatorConfiguration.Builders
{
    using System.Collections.Generic;
    using Translators.PropertyTranslators;


    public class PropertyTranslatorBuilder<TResult, TInput, TSchema> :
        IPropertyTranslatorBuilder<TResult, TInput, TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        readonly List<IPropertyTranslator<TResult, TInput, TSchema>> _translaters;

        public PropertyTranslatorBuilder()
        {
            _translaters = new List<IPropertyTranslator<TResult, TInput, TSchema>>();
        }

        public bool IsDefined => _translaters.Count > 0;

        public void Add(IPropertyTranslator<TResult, TInput, TSchema> translator)
        {
            _translaters.Add(translator);
        }

        public void Clear()
        {
            _translaters.Clear();
        }

        public IPropertyTranslator<TResult, TInput, TSchema> Build()
        {
            if (_translaters.Count == 1)
                return _translaters[0];

            return new PropertyTranslatorList<TResult, TInput, TSchema>(_translaters);
        }
    }
    
    public class PropertyTranslatorBuilder<TResult, TSchema> :
        IPropertyTranslatorBuilder<TResult, TSchema>
        where TResult : TSchema
        where TSchema : Entity
    {
        readonly List<IPropertyTranslator<TResult, TSchema>> _translaters;

        public PropertyTranslatorBuilder()
        {
            _translaters = new List<IPropertyTranslator<TResult, TSchema>>();
        }

        public bool IsDefined => _translaters.Count > 0;

        public void Add(IPropertyTranslator<TResult, TSchema> translator)
        {
            _translaters.Add(translator);
        }

        public void Clear()
        {
            _translaters.Clear();
        }

        public IPropertyTranslator<TResult, TSchema> Build()
        {
            if (_translaters.Count == 1)
                return _translaters[0];

            return new PropertyTranslatorList<TResult, TSchema>(_translaters);
        }
    }
}