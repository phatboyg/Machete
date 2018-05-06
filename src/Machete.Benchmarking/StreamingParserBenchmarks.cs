namespace Machete.Benchmarking
{
    using System.IO;
    using System.Reflection;
    using System.Threading.Tasks;
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using Configuration;
    using HL7;
    using HL7Schema.V26;
    using Texts;


    [Config(typeof(DotNetCoreStreamingBenchmarkConfig))]
    [MinColumn, MaxColumn]
    public class StreamingParserBenchmarks
    {
        readonly IEntityParser<HL7Entity> _hl7Parser;
        readonly ParseResult<HL7Entity> _parse1;
        readonly string _contentPath;

        public StreamingParserBenchmarks()
        {
            var hl7Schema = Schema.Factory.CreateHL7<HL7Entity>(x => x.AddFromNamespaceContaining<MSH>());

            _hl7Parser = Parser.Factory.CreateHL7(hl7Schema);
//            _parse1 = _hl7Parser.Parse(Message);
            var baseDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _contentPath = Path.Combine(baseDirectory, "Content", "MultipleHL7Messages.txt");
        }

        [Benchmark]
        public async Task StreamingParserBenchmark()
        {
            using (var fileStream = File.OpenRead(_contentPath))
            {
                StreamText text = await new StreamTextReader(fileStream).Text;

                ParseResult<HL7Entity> result = await _hl7Parser.ParseStream(text, new TextSpan(0, text.Length));

                int index = 0;
                int segments = 0;
                int messages = 0;
                while (result.HasResult)
                {
                    while (result.TryGetEntity(index, out HL7Segment segment))
                    {
                        segments++;
                        index++;
                        
                        if (segment is MSH)
                            messages++;
                    }
                    
                    result = await result.NextAsync();
                }
            }
        }
    }
}