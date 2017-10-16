namespace Machete.X12.Tests
{
    using System.Diagnostics;
    using NUnit.Framework;


    [SetUpFixture]
    public class ContextSetup
    {
        #if !NETCORE
        static readonly TestTraceListener TestTraceListener = new TestTraceListener();
        #endif

        [OneTimeSetUp]
        public void Setup()
        {
            #if !NETCORE
            Trace.Listeners.Add(TestTraceListener);
            #endif
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            #if !NETCORE
            Trace.Listeners.Remove(TestTraceListener);
            #endif
        }
    }
}