namespace Machete.Tests
{
    using System.Diagnostics;
    using NUnit.Framework;


    [SetUpFixture]
    public class ContextSetup
    {
        static readonly TestTraceListener TestTraceListener = new TestTraceListener();

        [SetUp]
        public void Setup()
        {
            Trace.Listeners.Add(TestTraceListener);
        }

        [TearDown]
        public void Teardown()
        {
            Trace.Listeners.Remove(TestTraceListener);
        }
    }
}