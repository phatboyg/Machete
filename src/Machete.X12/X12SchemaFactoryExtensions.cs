namespace Machete.X12
{
    using System;
    using Configuration.SchemaConfiguration;
    using Configuration.SchemaConfiguration.Configurators;
    using Machete;
    using Machete.Configuration;


    public static class X12SchemaFactoryExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="configure"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="SchemaConfigurationException"></exception>
        public static ISchema<T> CreateX12<T>(this ISchemaFactorySelector selector, Action<IX12SchemaConfigurator<T>> configure = null)
            where T : X12Entity
        {
            var configurator = new X12SchemaConfigurator<T>();

            configure?.Invoke(configurator);

            configurator.ValidateSpecification();

            try
            {
                return configurator.Build();
            }
            catch (Exception exception)
            {
                throw new SchemaConfigurationException("The X12 schema could not be built (see InnerException for details).", exception);
            }
        }
    }
}