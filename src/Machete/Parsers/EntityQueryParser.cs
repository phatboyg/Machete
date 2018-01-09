namespace Machete.Parsers
{
    using System;


    /// <summary>
    /// Supports query building that would otherwise be annoying using extension methods due to generic parameters
    /// </summary>
    /// <typeparam name="TSchema">The schema type</typeparam>
    /// <typeparam name="T">The parser result type</typeparam>
    public class EntityQueryParser<TSchema, T> :
        IQueryParser<TSchema, T>
        where TSchema : Entity
    {
        readonly IParser<TSchema, T> _parser;

        public EntityQueryParser(IParser<TSchema, T> parser)
        {
            // strip the query parser, if present, to avoid excessive indirection
            _parser = parser is EntityQueryParser<TSchema, T> entityQueryParser
                ? entityQueryParser.Parser
                : parser;
        }

        public IParser<TSchema, T> Parser => _parser;

        public Result<Cursor<TSchema>, T> Parse(Cursor<TSchema> input)
        {
            return _parser.Parse(input);
        }

        public IQueryParser<TSchema, T> Where(Func<T, bool> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return new EntityQueryParser<TSchema, T>(new WhereParser<TSchema, T>(_parser, predicate));
        }

        public IQueryParser<TSchema, TResult> Select<TResult>(Func<T, TResult> selector)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return new EntityQueryParser<TSchema, TResult>(new SelectParser<TSchema, T, TResult>(_parser, selector));
        }

        public IQueryParser<TSchema, TResult> SelectMany<TValue, TResult>(Func<T, IParser<TSchema, TValue>> selector, Func<T, TValue, TResult> projector)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));
            
            if (projector == null)
                throw new ArgumentNullException(nameof(projector));

            return new EntityQueryParser<TSchema, TResult>(new SelectManyParser<TSchema, T, TValue, TResult>(_parser, selector, projector));
        }

        public IQueryParser<TSchema, TResult> SelectMany<TValue, TResult>(Func<T, Value<TValue>> selector, Func<T, TValue, TResult> projector)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));
            
            if (projector == null)
                throw new ArgumentNullException(nameof(projector));

            return new EntityQueryParser<TSchema, TResult>(new SelectValueParser<TSchema, T, TValue, TResult>(_parser, selector, projector));
        }
    }
}