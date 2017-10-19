﻿namespace Machete.HL7
{
    using System;
    using FormatterConfiguration;
    using Machete;
    using Machete.Configuration;
    using Machete.Formatters;
    using ParserConfiguration;
    using ParserConfiguration.Configurators;


    public static class HL7ParserFactoryExtensions
    {
        /// <summary>
        /// Create an HL7 parser with the specified schema, which can be optionally configured.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="schema">The schema used for parsing content</param>
        /// <param name="configure">An optional configuration callback</param>
        /// <typeparam name="TSchema">The parser's schema type</typeparam>
        /// <returns>An initialized parser, ready to use</returns>
        /// <exception cref="SchemaConfigurationException"></exception>
        public static IParser<TSchema> CreateHL7<TSchema>(this IParserFactorySelector selector, ISchema<TSchema> schema,
            Action<IHL7ParserConfigurator> configure = null)
            where TSchema : HL7Entity
        {
            var configurator = new HL7ParserConfigurator<TSchema>(schema);

            configure?.Invoke(configurator);

            configurator.ValidateSpecification();

            try
            {
                return configurator.Build();
            }
            catch (Exception exception)
            {
                throw new SchemaConfigurationException("The HL7 schema could not be built (see InnerException for details).", exception);
            }
        }
    }

    public static class HL7FormatterFactoryExtensions
    {
        /// <summary>
        /// Create an HL7 parser with the specified schema, which can be optionally configured.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="schema">The schema used for parsing content</param>
        /// <param name="configure">An optional configuration callback</param>
        /// <typeparam name="TSchema">The parser's schema type</typeparam>
        /// <returns>An initialized parser, ready to use</returns>
        /// <exception cref="SchemaConfigurationException"></exception>
        public static IFormatter<TSchema> CreateHL7<TSchema>(this IFormatterFactorySelector selector, ISchema<TSchema> schema,
            Action<IHL7FormatterConfigurator<TSchema>> configure = null)
            where TSchema : HL7Entity
        {
            var configurator = new HL7FormatterConfigurator<TSchema>(schema);

            configure?.Invoke(configurator);

            configurator.ValidateSpecification();

            try
            {
                return configurator.Build();
            }
            catch (Exception exception)
            {
                throw new SchemaConfigurationException("The HL7 schema could not be built (see InnerException for details).", exception);
            }
        }
    }

}