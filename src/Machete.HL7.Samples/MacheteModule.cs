namespace Machete.HL7.Samples
{
    using Autofac;
    using HL7Schema.V26;


    public class MacheteModule :
        Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context => Schema.Factory.CreateHL7<HL7Entity>(x => x.AddFromNamespaceContaining<MSH>()))
                .SingleInstance()
                .As<ISchema<HL7Entity>>();

            builder.Register(context =>
                {
                    var schema = context.Resolve<ISchema<HL7Entity>>();

                    return Formatter.Factory.CreateHL7(schema);
                })
                .SingleInstance()
                .As<IFormatter<HL7Entity>>();

            builder.Register(context =>
                {
                    var schema = context.Resolve<ISchema<HL7Entity>>();

                    return Parser.Factory.CreateHL7(schema);
                })
                .SingleInstance()
                .As<IEntityParser<HL7Entity>>();
        }
    }
}