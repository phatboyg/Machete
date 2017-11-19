namespace Machete.Benchmarking
{
    using BenchmarkDotNet.Running;


    class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<LINQSupportBenchmarks>();
        }
    }
}