﻿namespace Machete.X12
{
    using System;
    using Configuration.FormatterConfiguration;
    using Machete.Configuration;
    using Machete.Formatters;


    public static class X12FormatterFactoryExtensions
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
        public static IFormatter<TSchema> CreateX12<TSchema>(this IFormatterFactorySelector selector, ISchema<TSchema> schema,
            Action<IX12FormatterConfigurator<TSchema>> configure = null)
            where TSchema : X12Entity
        {
            var configurator = new X12FormatterConfigurator<TSchema>(schema);

            configure?.Invoke(configurator);

            configurator.ValidateSpecification();

            try
            {
                return configurator.Build();
            }
            catch (Exception exception)
            {
                throw new SchemaConfigurationException("The X12 formatter could not be built (see InnerException for details).", exception);
            }
        }
    }
}