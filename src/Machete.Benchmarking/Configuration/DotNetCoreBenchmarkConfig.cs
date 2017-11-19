namespace Machete.Benchmarking.Configuration
{
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Diagnosers;
    using BenchmarkDotNet.Engines;
    using BenchmarkDotNet.Environments;
    using BenchmarkDotNet.Jobs;


    public class DotNetCoreBenchmarkConfig :
        ManualConfig
    {
        const int Iteration = 100;

        public DotNetCoreBenchmarkConfig()
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