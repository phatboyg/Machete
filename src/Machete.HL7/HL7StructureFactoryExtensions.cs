namespace Machete.HL7
{
    using System;
    using Configuration.TemplateConfiguration;
    using Configuration.TemplateConfiguration.Configurators;
    using Machete.Configuration;


    public static class HL7StructureFactoryExtensions
    {
        public static IStructure<TSchema> CreateHL7<TSchema>(this IStructureFactorySelector selector, ISchema<TSchema> schema,
            Action<IHL7StructureConfigurator<TSchema>> configure = null)
            where TSchema : HL7Entity
        {
            var configurator = new HL7StructureConfigurator<TSchema>(schema);

            configure?.Invoke(configurator);

            configurator.ValidateConfiguration();

            try
            {
                return configurator.Build();
            }
            catch (Exception exception)
            {
                throw new StructureConfigurationException("The HL7 structure could not be built (see InnerException for details).", exception);
            }
        }
    }
}