﻿namespace Machete.TranslateConfiguration.Builders
{
    using System.Collections.Generic;
    using Translators.PropertyTranslaters;


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
}