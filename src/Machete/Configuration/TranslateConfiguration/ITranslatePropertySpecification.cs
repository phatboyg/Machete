namespace Machete.TranslateConfiguration
{
    using System;
    using System.Collections.Generic;
    using Configuration;


    public interface ITranslatePropertySpecification<in TResult, TProperty, in TInput, TSchema> :
        ITranslatePropertySpecification<TResult, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
    }


    public interface ITranslatePropertySpecification<in TResult, in TInput, TSchema> :
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

        void Apply(ITranslateBuilder<TResult, TInput, TSchema> builder);
    }
}