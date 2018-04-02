namespace Machete
{
    using System;

   
    public interface TranslateContext<TInput, TSchema> :
        TranslateContext<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// The input value
        /// </summary>
        TInput Input { get; }

        /// <summary>
        /// True if the input is not null
        /// </summary>
        bool HasInput { get; }

        /// <summary>
        /// The index, if present, indicates that it's a list of inputs being translated
        /// </summary>
        int? Index { get; }

        /// <summary>
        /// Try to get the context for the specified input type, if supported
        /// </summary>
        /// <param name="context"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        bool TryGetContext<T>(out TranslateContext<T, TSchema> context)
            where T : TInput;

        /// <summary>
        /// Create a new context, which contains the same data as the current context but 
        /// prevents any changes/arguments from being updated in the current context.
        /// </summary>
        /// <returns></returns>
        TranslateContext<TInput, TSchema> CreateScope();

        /// <summary>
        /// Create a value context for the input value
        /// </summary>
        /// <param name="value"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        TranslateValueContext<T, TInput, TSchema> CreateValueContext<T>(Value<T> value);
    }


    public interface TranslateContext<TSchema> :
        IContext
        where TSchema : Entity
    {
        /// <summary>
        /// The entity result from which the input was parsed
        /// </summary>
        EntityResult<TSchema> Source { get; }

        /// <summary>
        /// Create a result, which can be returned by the translater
        /// </summary>
        /// <param name="result"></param>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        TranslateResult<TSchema> Result<TResult>(TResult result)
            where TResult : TSchema;

        /// <summary>
        /// Create a result, which is mapped and returned by the translater
        /// </summary>
        /// <param name="result"></param>
        /// <param name="resultType">The schema type, which must be derived from the <typeparamref name="TSchema"/></param>
        /// <returns></returns>
        TranslateResult<TSchema> Result(TSchema result, Type resultType);

        /// <summary>
        /// Create an empty result
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        TranslateResult<TSchema> Empty<TResult>();

        /// <summary>
        /// Returns the result, which was not translated.
        /// </summary>
        /// <param name="result">The result</param>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        TranslateResult<TSchema> NotTranslated<TResult>(TResult result)
            where TResult : TSchema;

        /// <summary>
        /// Returns an empty result, which was not translated
        /// </summary>
        /// <returns></returns>
        TranslateResult<TSchema> NotTranslated<TResult>()
            where TResult : TSchema;

        /// <summary>
        /// Create an empty result
        /// </summary>
        /// <returns></returns>
        TranslateResult<TSchema> Empty();

        /// <summary>
        /// Creates an entity result collection which can be used to add entity results and return them
        /// </summary>
        /// <returns></returns>
        ITranslateResultCollection<TSchema> CreateResultCollection();

        /// <summary>
        /// Create a context for the specified input
        /// </summary>
        /// <param name="input">The input value</param>
        /// <param name="index">The index of the input, if it's a list</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        TranslateContext<T, TSchema> CreateContext<T>(T input, int? index = default);

        /// <summary>
        /// Create a context for an empty input type
        /// </summary>
        /// <param name="index">The index of the input, if it's a list</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        TranslateContext<T, TSchema> CreateContext<T>(int? index = default);
    }
}