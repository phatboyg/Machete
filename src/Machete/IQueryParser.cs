namespace Machete
{
    using System;


    public interface IQueryParser<TSchema, out T> :
        IParser<TSchema, T>
        where TSchema : Entity
    {
        IQueryParser<TSchema, T> Where(Func<T, bool> predicate);

        IQueryParser<TSchema, TResult> Select<TResult>(Func<T, TResult> selector);

        IQueryParser<TSchema, TResult> SelectMany<TValue, TResult>(Func<T, IParser<TSchema, TValue>> selector, Func<T, TValue, TResult> projector);

        IQueryParser<TSchema, TResult> SelectMany<TValue, TResult>(Func<T, Value<TValue>> selector, Func<T, TValue, TResult> projector);

        IParser<TSchema, T> Parser { get; }
    }
}