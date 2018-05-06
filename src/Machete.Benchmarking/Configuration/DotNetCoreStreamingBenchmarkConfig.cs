namespace Machete.Benchmarking.Configuration
{
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Diagnosers;
    using BenchmarkDotNet.Engines;
    using BenchmarkDotNet.Environments;
    using BenchmarkDotNet.Jobs;


    public class DotNetCoreStreamingBenchmarkConfig :
        ManualConfig
    {
        const int Iteration = 5;

        public DotNetCoreStreamingBenchmarkConfig()
        {
            Add(MemoryDiagnoser.Default);
            Add(new Job
            {
                Env = {Runtime = Runtime.Core},
                Run =
                {
                    TargetCount = Iteration,
                    RunStrategy = RunStrategy.Throughput,
                    WarmupCount = 5,
                    LaunchCount = 1,
                    UnrollFactor = 1,
                    InvocationCount = Iteration
                }
            });
        }
    }
}