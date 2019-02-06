using System;


namespace Machete.HL7.Samples
{
    using Autofac;


    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<MacheteModule>();
//            builder.RegisterType<LINQ2HL7>()

            var container = builder.Build();
            var parser = container.Resolve<IEntityParser<HL7Entity>>()
            Console.WriteLine("Hello World!");
        }
    }
}