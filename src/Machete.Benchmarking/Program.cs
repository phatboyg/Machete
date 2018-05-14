namespace Machete.Benchmarking
{
    using BenchmarkDotNet.Running;


    class Program
    {
        public static void Main(string[] args)
        {
//            var run1 = BenchmarkRunner.Run<LINQParserBenchmarks>();
//            var run2 = BenchmarkRunner.Run<LayoutParserBenchmarks>();
            var run3 = BenchmarkRunner.Run<EntityParserBenchmarks>();
//            var run4 = BenchmarkRunner.Run<StreamingParserBenchmarks>();
        }
    }
}