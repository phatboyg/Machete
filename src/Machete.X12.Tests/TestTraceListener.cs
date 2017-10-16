namespace Machete.X12.Tests
{
    using System;
    using System.Diagnostics;

#if !NETCORE
    public class TestTraceListener :
        TraceListener
    {
        public override void Write(string message)
        {
            Console.Write(message);
        }

        public override void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
#endif
}