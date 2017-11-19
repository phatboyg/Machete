namespace Machete.Benchmarking.Configuration
{
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Engines;
    using BenchmarkDotNet.Environments;
    using BenchmarkDotNet.Jobs;


    public class MonoBenchmarkConfig :
        ManualConfig
    {
        const int Iteration = 20;

        public MonoBenchmarkConfig()
        {
            Add(new Job
            {
                Env = {Runtime = Runtime.Mono},
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