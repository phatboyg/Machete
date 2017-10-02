namespace Machete.HL7.Tests
{
    using System.Diagnostics;
    using NUnit.Framework;


//    [SetUpFixture]
    public class ContextSetup
    {
        static readonly TestTraceListener TestTraceListener = new TestTraceListener();

//        [OneTimeSetUp]
//        public void Setup()
//        {
//            Trace.Listeners.Add(TestTraceListener);
//        }
//
//        [OneTimeTearDown]
//        public void Teardown()
//        {
//            Trace.Listeners.Remove(TestTraceListener);
//        }
    }
}