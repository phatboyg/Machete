namespace Machete
{
    using System;
    using Parsers;


    public static class ParsedQueryExtensions
    {
        public static Parser<TContent, TResult> Select<TContent, T, TResult>(
            this Parser<TContent, T> parser, Func<T, TResult> selector)
            where TContent : Entity
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return new SelectParser<TContent, T, TResult>(parser, selector);
        }

//        public static Parser<TContent> Select<TContent>(
//            this Parsed<TContent> parser, Func<TContent, TContent> selector)
//            where TContent : Entity
//        {
//            if (parser == null)
//                throw new ArgumentNullException(nameof(parser));
//            if (selector == null)
//                throw new ArgumentNullException(nameof(selector));
//
//            return new SelectParser<TContent, TContent>(parser, selector);
//        }

        public static Parser<TContent, TResult> SelectMany<TContent, T, TValue, TResult>(
            this Parser<TContent, T> parser, Func<T, Parser<TContent, TValue>> selector,
            Func<T, TValue, TResult> projector)
            where TContent : Entity
        {
            if (parser == null)
                throw new ArgumentNullException("parser");
            if (selector == null)
                throw new ArgumentNullException("selector");
            if (projector == null)
                throw new ArgumentNullException("projector");

            return new SelectManyParser<TContent, T, TValue, TResult>(parser, selector, projector);
        }

//        public static Parser<TContent, TResult> SelectMany<TContent, T, TValue, TResult>(
//            this Parsed<TContent> parser, Func<T, Parser<TContent, TValue>> selector,
//            Func<T, TValue, TResult> projector)
//            where TContent : Entity
//        {
//            if (parser == null)
//                throw new ArgumentNullException("parser");
//            if (selector == null)
//                throw new ArgumentNullException("selector");
//            if (projector == null)
//                throw new ArgumentNullException("projector");
//
//            return input =>
//            {
//                Result<TContent, T> result = parser(input);
//                if (result == null)
//                    return null;
//
//                T val = result.Value;
//                Result<TContent, TValue> nextResult = selector(val)(result.Rest);
//                if (nextResult == null)
//                    return null;
//
//                return new Success<TContent, TResult>(projector(val, nextResult.Value), nextResult.Rest);
//            };
//        }

//        public static Parser<TContent, TResult> SelectMany<TContent, TResult>(
//            this Parsed<TContent> parser, Func<TContent, Parsed<TContent>> selector,
//            Func<TContent, TContent, TResult> projector)
//            where TContent : Entity
//        {
//            if (parser == null)
//                throw new ArgumentNullException("parser");
//            if (selector == null)
//                throw new ArgumentNullException("selector");
//            if (projector == null)
//                throw new ArgumentNullException("projector");
//
//            return input =>
//            {
//                Result<TContent, T> result = parser(input);
//                if (result == null)
//                    return null;
//
//                T val = result.Value;
//                Result<TContent, TValue> nextResult = selector(val)(result.Rest);
//                if (nextResult == null)
//                    return null;
//
//                return new Success<TContent, TResult>(projector(val, nextResult.Value), nextResult.Rest);
//            };
//        }
    }
}