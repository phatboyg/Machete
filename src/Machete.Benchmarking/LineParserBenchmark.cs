namespace Machete.Benchmarking
{
    using System;
    using System.Buffers;
    using System.IO.Pipelines;
    using System.Text;
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Jobs;
    using MacheteToo;


    [SimpleJob(RuntimeMoniker.Net60)]
    [MemoryDiagnoser]
    public class LineParserBenchmark
    {
        const string _message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
PD1|M|F|N||||F|
NTE|1||IN42
PV1|1|O|||||92383^Machete^Janice||||||||||||12345|||||||||||||||||||||||||201304051104
PV2||||||||20150615|20150616|1||||||||||||||||||||||||||N
IN1|1|||MACHETE INC|1234 Fruitvale ave^^Oakland^CA^94601^USA||5101234567^^^^^510^1234567|074394|||||||A1|MACHETE^JOE||19890909|123 SEASAME STREET^^Oakland^CA^94600||||||||||||N|||||666889999|0||||||F||||T||60043^^^MACHETE^MRN
GT1|1|60043^^^MACHETE^MRN|MACHETE^JOE||123 SEASAME STREET^^Oakland^CA^94600|5416666666|5418888888|19890909|F|P
AL1|1|FA|^pollen allergy|SV|jalubu daggu||
ORC|NW|PRO2350||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa
ORC|NW|PRO2351||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11637^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R";

        readonly LineTextParser _parser;
        readonly ReadOnlySequence<byte> _sequence;
        readonly ReadToStringParser _elementParser;

        public LineParserBenchmark()
        {
            _parser = new LineTextParser();
            _elementParser = new ReadToStringParser("|");

            var bytes = Encoding.UTF8.GetBytes(_message);
            _sequence = new ReadOnlySequence<byte>(bytes);
        }

        [Benchmark]
        public void StringSplit()
        {
            var lines = _message.Split(Environment.NewLine);
            for (int i = 0; i < lines.Length; i++)
            {
                var elements = lines[i].Split('|');
            }
        }

        [Benchmark]
        public void SplitLines()
        {
            var reader = PipeReader.Create(_sequence);

            for (var result = _parser.Parse(reader); result.IsValid; result = _parser.Parse(reader))
            {
                for (var elementResult = _elementParser.Parse(result.Buffer); elementResult.IsValid; elementResult = _elementParser.Parse(elementResult.Next))
                {
                }
            }
        }
    }
}