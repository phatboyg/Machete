namespace Machete.CoreDependencyInjectIntegration
{
    using HL7;
    using X12;
    using Microsoft.Extensions.DependencyInjection;


    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddMacheteX12<T>(this IServiceCollection services)
            where T : X12Entity
        {
            services.AddSingleton(x => Schema.Factory.CreateX12<X12Entity>(cfg => cfg.AddFromNamespaceContaining<T>()));

            services.AddSingleton(x => Parser.Factory.CreateX12(x.GetService<ISchema<T>>()));

            services.AddSingleton(x => Formatter.Factory.CreateX12(x.GetService<ISchema<T>>()));

            return services;
        }
        
        public static IServiceCollection AddMacheteHL7<T>(this IServiceCollection services)
            where T : HL7Entity
        {
            services.AddSingleton(x => Schema.Factory.CreateHL7<HL7Entity>(cfg => cfg.AddFromNamespaceContaining<T>()));

            services.AddSingleton(x => Parser.Factory.CreateHL7(x.GetService<ISchema<HL7Entity>>()));

            services.AddSingleton(x => Formatter.Factory.CreateHL7(x.GetService<ISchema<HL7Entity>>()));

            return services;
        }
    }
}