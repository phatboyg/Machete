using System;
using System.Diagnostics;
using Machete;
using Machete.HL7;
using Machete.HL7Schema.V26;

namespace ProfileConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            var schema = Schema.Factory.CreateHL7Version26();
            var parser = Parser.Factory.CreateHL7(schema);
            stopwatch.Stop();

            TimeSpan elapsedTime = stopwatch.Elapsed;

            Console.WriteLine("Schema Initialization: 00:00:{0:00}.{1:00}", elapsedTime.Seconds, elapsedTime.Milliseconds / 10);
        }
    }
}
