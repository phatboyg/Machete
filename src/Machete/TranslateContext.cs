namespace Machete
{
    using System;


    public interface TranslateContext<out TInput, TSchema> :
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
        bool TryGetContext<T>(out TranslateContext<T, TSchema> context);

        /// <summary>
        /// Create a new context, which contains the same data as the current context but 
        /// prevents any changes/arguments from being updated in the current context.
        /// </summary>
        /// <returns></returns>
        TranslateContext<TInput, TSchema> CreateScope();
    }


    public interface TranslateContext<TSchema> :
        IPayload
        where TSchema : Entity
    {
        /// <summary>
        /// The entity result from which the input was parsed
        /// </summary>
        EntityResult<TSchema> Source { get; }

        Cursor<TSchema> Cursor { get; }

        /// <summary>
        /// Create a result, which can be returned by the translater
        /// </summary>
        /// <param name="result"></param>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        EntityResult<TSchema> Result<TResult>(TResult result)
            where TResult : TSchema;

        /// <summary>
        /// Create a result, which is mapped and returned by the translater
        /// </summary>
        /// <param name="result"></param>
        /// <param name="schemaType">The schema type, which must be derived from the <typeparamref name="TSchema"/></param>
        /// <returns></returns>
        EntityResult<TSchema> Result(TSchema result, Type schemaType);

        /// <summary>
        /// Create an empty result
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        EntityResult<TSchema> Empty<TResult>();

        /// <summary>
        /// Creates an entity result collection which can be used to add entity results and return them
        /// </summary>
        /// <returns></returns>
        IEntityResultCollection<TSchema> CreateResultCollection();

        /// <summary>
        /// Create a context for the specified input
        /// </summary>
        /// <param name="input">The input value</param>
        /// <param name="index">The index of the input, if it's a list</param>
        /// <typeparam name="TInput"></typeparam>
        /// <returns></returns>
        TranslateContext<TInput, TSchema> CreateContext<TInput>(TInput input, int? index = default(int?));

        /// <summary>
        /// Create a context for an empty input type
        /// </summary>
        /// <param name="index">The index of the input, if it's a list</param>
        /// <typeparam name="TInput"></typeparam>
        /// <returns></returns>
        TranslateContext<TInput, TSchema> CreateContext<TInput>(int? index = default(int?));
    }
}