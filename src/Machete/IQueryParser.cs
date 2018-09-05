namespace Machete
{
    using System;


    public interface IQueryParser<TSchema, out T> :
        IParser<TSchema, T>
        where TSchema : Entity
    {
        /// <summary>
        /// Returns a <see cref="IQueryParser{TSchema, T}"/> if the filter condition evaluates to true.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IQueryParser<TSchema, T> Where(Func<T, bool> predicate);

        /// <summary>
        /// Returns a parser 
        /// </summary>
        /// <param name="selector"></param>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        IQueryParser<TSchema, TResult> Select<TResult>(Func<T, TResult> selector);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TValue"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        IQueryParser<TSchema, TResult> SelectMany<TValue, TResult>(Func<T, IParser<TSchema, TValue>> selector, Func<T, TValue, TResult> projector);

        IQueryParser<TSchema, TResult> SelectMany<TValue, TResult>(Func<T, Value<TValue>> selector, Func<T, TValue, TResult> projector);

        IParser<TSchema, T> Parser { get; }
    }
}