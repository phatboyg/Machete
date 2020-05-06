namespace Machete.X12.Tests
{
    using System;
    using System.Linq;
    using NUnit.Framework;
    using TestSchema;
    using X12Schema.V5010;


    [TestFixture]
    public class SpecificationRegistrationTests
    {
        [Test]
        public void Test()
        {
            var schema = CreateSchema2();
            
            schema.GetRegisteredLayouts().ToList().ForEach(x => Console.WriteLine(x.FullName));
        }
        
        ISchema<X12Entity> CreateSchema1()
        {
            return Machete.Schema.Factory.CreateX12<X12Entity>(cfg =>
            {
                cfg.AddFromNamespaceContaining<V5010>();
                cfg.AddFromNamespaceContaining<TestSpec>();
            });
        }
        
        ISchema<X12Entity> CreateSchema2()
        {
            return Machete.Schema.Factory.CreateX12<X12Entity>(cfg =>
            {
                cfg.AddFromNamespaceContaining<V5010>();
                cfg.Add(new TestX12LayoutMap());
            });
        }
    }
}