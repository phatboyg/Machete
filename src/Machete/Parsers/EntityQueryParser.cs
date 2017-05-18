namespace Machete.Parsers
{
    using System;


    public class EntityQueryParser<TSchema, T> :
        QueryParser<TSchema, T>
        where TSchema : Entity
    {
        readonly Parser<TSchema, T> _parser;

        public EntityQueryParser(Parser<TSchema, T> parser)
        {
            _parser = parser;
        }

        public Result<Cursor<TSchema>, T> Parse(Cursor<TSchema> input)
        {
            return _parser.Parse(input);
        }

        public QueryParser<TSchema, T> Where(Func<T, bool> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return new EntityQueryParser<TSchema, T>(new WhereParser<TSchema, T>(_parser, predicate));
        }

        public QueryParser<TSchema, TResult> Select<TResult>(Func<T, TResult> selector)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return new EntityQueryParser<TSchema, TResult>(new SelectParser<TSchema, T, TResult>(_parser, selector));
        }

        public QueryParser<TSchema, TResult> SelectMany<TValue, TResult>(Func<T, Parser<TSchema, TValue>> selector, Func<T, TValue, TResult> projector)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));
            if (projector == null)
                throw new ArgumentNullException(nameof(projector));

            return new EntityQueryParser<TSchema, TResult>(new SelectManyParser<TSchema, T, TValue, TResult>(_parser, selector, projector));
        }

        public QueryParser<TSchema, TResult> SelectMany<TValue, TResult>(Func<T, Value<TValue>> selector, Func<T, TValue, TResult> projector)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));
            if (projector == null)
                throw new ArgumentNullException(nameof(projector));

            return new EntityQueryParser<TSchema, TResult>(new SelectValueParser<TSchema, T, TValue, TResult>(_parser, selector, projector));
        }
    }
}