namespace Machete.AutofacIntegration
{
    using HL7;
    using X12;
    using Autofac;


    public static class DependencyInjectionExtensions
    {
        public static ContainerBuilder AddMacheteX12<T>(this ContainerBuilder builder)
            where T : X12Entity
        {
            builder.Register(x => Schema.Factory.CreateX12<X12Entity>(cfg => cfg.AddFromNamespaceContaining<T>()))
                .As<ISchema<X12Entity>>()
                .SingleInstance();

            builder.Register(x => Parser.Factory.CreateX12(x.Resolve<ISchema<X12Entity>>()));
            
            builder.Register(x => Formatter.Factory.CreateX12(x.Resolve<ISchema<X12Entity>>()));

            return builder;
        }
        
        public static ContainerBuilder AddMacheteHL7<T>(this ContainerBuilder builder)
            where T : HL7Entity
        {
            builder.Register(x => Schema.Factory.CreateHL7<HL7Entity>(cfg => cfg.AddFromNamespaceContaining<T>()))
                .As<ISchema<HL7Entity>>()
                .SingleInstance();

            builder.Register(x => Parser.Factory.CreateHL7(x.Resolve<ISchema<HL7Entity>>()));
            
            builder.Register(x => Formatter.Factory.CreateHL7(x.Resolve<ISchema<HL7Entity>>()));

            return builder;
        }
    }
}