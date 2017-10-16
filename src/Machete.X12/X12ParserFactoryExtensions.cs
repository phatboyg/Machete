namespace Machete.X12
{
    using System;
    using Configuration.ParserConfiguration;
    using Configuration.ParserConfiguration.Configurators;
    using Machete;
    using Machete.Configuration;


    public static class X12ParserFactoryExtensions
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
        public static IParser<TSchema> CreateX12<TSchema>(this IParserFactorySelector selector, ISchema<TSchema> schema, Action<IX12ParserConfigurator> configure = null)
            where TSchema : X12Entity
        {
            var configurator = new X12ParserConfigurator<TSchema>(schema);

            configure?.Invoke(configurator);

            configurator.ValidateSpecification();

            try
            {
                return configurator.Build();
            }
            catch (Exception exception)
            {
                throw new SchemaConfigurationException("The X12 parser could not be built (see InnerException for details).", exception);
            }
        }
    }
}