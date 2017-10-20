﻿namespace Machete
{
    using System;
    using Parsers;
    using X12;
    using X12.Schema.Segments;


    public static class LoopQueryExtensions
    {
        /// <summary>
        /// Parses an element only if the except parser is not matched
        /// </summary>
        public static Parser<X12Entity, HL> Loop2000A<T, TExcept>(this IQueryBuilder<X12Entity> parser, Parser<X12Entity, TExcept> except)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (except == null)
                throw new ArgumentNullException(nameof(except));

            QueryParser<X12Entity, HL> query = from p in parser.Select<HL>()
                where p.LevelCode.HasValue && p.LevelCode.Value == "20"
                select p;

            return query;
        }
    }
}