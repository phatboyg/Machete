namespace Machete.Benchmarking
{
    using System;
    using System.Collections.Generic;
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Jobs;
    using Parsers;


    [SimpleJob(RuntimeMoniker.Net60)]
    [MemoryDiagnoser]
    public class SimpleParserBenchmark
    {
        readonly IParser<int, int> _filterQuery;
        readonly IParserV2<int, int> _filterQueryV2;
        readonly IParser<int, IReadOnlyList<int>> _query;
        readonly IParserV2<int, ReadOnlyMemory<int>> _queryV2;
        readonly int[] _subject;

        public SimpleParserBenchmark()
        {
            var anyParser = new AnyParser<int>();

            _query = (from x in anyParser
                select x).Take(2);

            _filterQuery = from x in anyParser
                where x == 1
                select x;

            var anyParserV2 = new AnyParserV2<int>();

            _queryV2 = (from x in anyParserV2
                select x).Take(2);

            _filterQueryV2 = from x in anyParserV2
                where x == 1
                select x;

            _subject = new[] { 1, 2, 3, 4, 5 };
        }

        [Benchmark]
        public void TakeV1()
        {
            _query.Execute(_subject);
        }

        [Benchmark]
        public void TakeV2()
        {
            _queryV2.Execute(_subject);
        }

        [Benchmark]
        public void FilterV1()
        {
            _filterQuery.Execute(_subject);
        }

        [Benchmark]
        public void FilterV2()
        {
            _filterQueryV2.Execute(_subject);
        }
    }
}