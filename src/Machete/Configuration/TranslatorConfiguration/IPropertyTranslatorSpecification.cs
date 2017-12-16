namespace Machete.TranslatorConfiguration
{
    using System;
    using System.Collections.Generic;
    using Configuration;


    public interface IPropertyTranslatorSpecification<in TResult, TInput, TSchema> :
        ISpecification
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        /// <summary>
        /// Returns the translate types referenced by the specification
        /// </summary>
        /// <returns></returns>
        IEnumerable<Type> GetReferencedTranslateTypes();

        void Apply(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder);
    }
}