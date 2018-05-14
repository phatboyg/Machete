namespace Machete.Benchmarking.Configuration
{
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Diagnosers;
    using BenchmarkDotNet.Engines;
    using BenchmarkDotNet.Environments;
    using BenchmarkDotNet.Exporters;
    using BenchmarkDotNet.Exporters.Csv;
    using BenchmarkDotNet.Jobs;


    public class DotNetCoreBenchmarkConfig :
        ManualConfig
    {
        const int Iteration = 300;

        public DotNetCoreBenchmarkConfig()
        {
            Add(MemoryDiagnoser.Default);
//            Add(RPlotExporter.Default);
            Add(new CsvExporter(CsvSeparator.CurrentCulture, new BenchmarkDotNet.Reports.SummaryStyle
            {
                PrintUnitsInHeader = true,
                PrintUnitsInContent = false,
                TimeUnit = BenchmarkDotNet.Horology.TimeUnit.Microsecond,
                SizeUnit = BenchmarkDotNet.Columns.SizeUnit.KB
            }));
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