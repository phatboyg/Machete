namespace Machete.HL7
{
    using System;
    using Configuration.SchemaConfiguration;
    using Configuration.SchemaConfiguration.Configurators;
    using Machete;
    using Machete.Configuration;


    public static class HL7SchemaFactoryExtensions
    {
        public static ISchema<HL7Entity> CreateHL7(this ISchemaFactorySelector selector, Action<IHL7SchemaConfigurator> configure = null)
        {
            var configurator = new HL7SchemaConfigurator();

            configure?.Invoke(configurator);

            configurator.ValidateConfiguration();

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