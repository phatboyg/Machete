namespace Machete.CoreDependencyInjectIntegration
{
    using HL7;
    using X12;
    using Microsoft.Extensions.DependencyInjection;


    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddMacheteX12<TSchema, TVersion>(this IServiceCollection services)
            where TSchema : X12Entity
            where TVersion : TSchema
        {
            services.AddSingleton(x => Schema.Factory.CreateX12<TSchema>(cfg => cfg.AddFromNamespaceContaining<TVersion>()));

            services.AddSingleton(x => Parser.Factory.CreateX12(x.GetService<ISchema<TSchema>>()));

            services.AddSingleton(x => Formatter.Factory.CreateX12(x.GetService<ISchema<TSchema>>()));

            return services;
        }
        
        public static IServiceCollection AddMacheteHL7<TSchema, TVersion>(this IServiceCollection services)
            where TSchema : HL7Entity
            where TVersion : TSchema
        {
            services.AddSingleton(x => Schema.Factory.CreateHL7<TSchema>(cfg => cfg.AddFromNamespaceContaining<TVersion>()));

            services.AddSingleton(x => Parser.Factory.CreateHL7(x.GetService<ISchema<TSchema>>()));

            services.AddSingleton(x => Formatter.Factory.CreateHL7(x.GetService<ISchema<TSchema>>()));

            return services;
        }
    }
}