namespace Machete
{
    public static class LayoutConfiguratorExtensions
    {
        public static ILayoutConfigurator<T> Required<T>(this ILayoutConfigurator<T> configurator)
        {
            configurator.Required = true;

            return configurator;
        }
    }
}