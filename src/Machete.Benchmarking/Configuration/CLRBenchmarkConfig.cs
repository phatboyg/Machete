namespace Machete.Benchmarking.Configuration
{
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Diagnosers;
    using BenchmarkDotNet.Engines;
    using BenchmarkDotNet.Environments;
    using BenchmarkDotNet.Exporters;
    using BenchmarkDotNet.Jobs;


    public class CLRBenchmarkConfig :
        ManualConfig
    {
        const int Iteration = 20;

        public CLRBenchmarkConfig()
        {
            Add(MemoryDiagnoser.Default);
            Add(HtmlExporter.Default);
            Add(new Job
            {
                Env = { Runtime = Runtime.Clr },
                Run =
                {
                    TargetCount = Iteration,
                    RunStrategy = RunStrategy.Throughput,
                    WarmupCount = 1,
                    LaunchCount = 1,
                    UnrollFactor = 1,
                    InvocationCount = Iteration
                }
            });
        }
    }
}