namespace Machete.Benchmarking
{
    using BenchmarkDotNet.Running;


    class Program
    {
        public static void Main(string[] args)
        {
//            var run1 = BenchmarkRunner.Run<LINQSupportBenchmarks>();
//            var run2 = BenchmarkRunner.Run<LayoutSupportBenchmarks>();
            var run3 = BenchmarkRunner.Run<StreamingParserBenchmarks>();
        }
    }
}