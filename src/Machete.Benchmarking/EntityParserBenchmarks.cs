namespace Machete.Benchmarking
{
    using System;
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using Configuration;
    using HL7;
    using HL7Schema.V26;


    [Config(typeof(DotNetCoreBenchmarkConfig))]
    [MinColumn, MaxColumn]
    public class EntityParserBenchmarks
    {
        ISchema<HL7Entity> _hl7Schema;
        readonly IEntityParser<HL7Entity> _hl7Parser;
        readonly ParseResult<HL7Entity> _parse;

        const string _message2 = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
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

        public EntityParserBenchmarks()
        {
            _hl7Schema = Schema.Factory.CreateHL7<HL7Entity>(x => x.AddFromNamespaceContaining<MSH>());

            _hl7Parser = Parser.Factory.CreateHL7(_hl7Schema);
            _parse = _hl7Parser.Parse(_message2);
        }

//        [Benchmark]
        public void HL7EntityWithoutInitialParseSingleFieldBenchmark()
        {
            _parse.TryGetEntity(9, out ORC orc);
            
            string placerOrderNumber = orc.PlacerGroupNumber
                .Select(x => x.EntityIdentifier)
                .ValueOrDefault();
        }

//        [Benchmark]
        public void HL7EntityWithInitialParseSingleFieldBenchmark()
        {
            var parse = _hl7Parser.Parse(_message2);
            
            parse.TryGetEntity(9, out ORC orc);
            
            string placerOrderNumber = orc.PlacerGroupNumber
                .Select(x => x.EntityIdentifier)
                .ValueOrDefault();
        }

//        [Benchmark]
        public void TryGetEntityBenchmark()
        {
//            var parse = _hl7Parser.Parse(_message2);
            
            _parse.TryGetEntity(9, out ORC orc);
        }

        [Benchmark]
        public void HL7EntityWithInitialParseMultipleFieldBenchmark()
        {
            var parse = _hl7Parser.Parse(_message2);
            
            parse.TryGetEntity(9, out ORC orc);
            
            string placerOrderNumber = orc.PlacerGroupNumber
                .Select(x => x.EntityIdentifier)
                .ValueOrDefault();

            string orderNumber = orc.PlacerOrderNumber
                .Select(x => x.EntityIdentifier)
                .ValueOrDefault();

            string orderControl = orc.OrderControl
                .ValueOrDefault();

            DateTimeOffset dt = orc.DateTimeOfTransaction
                .ValueOrDefault();

            var enteredBy = orc.EnteredBy[0]
                .Select(x => x.IdNumber)
                .ValueOrDefault();
        }

        [Benchmark]
        public void HL7EntityWithoutInitialParseMultipleFieldBenchmark()
        {
            _parse.TryGetEntity(9, out ORC orc);
            
            string placerOrderNumber = orc.PlacerGroupNumber
                .Select(x => x.EntityIdentifier)
                .ValueOrDefault();

            string orderNumber = orc.PlacerOrderNumber
                .Select(x => x.EntityIdentifier)
                .ValueOrDefault();

            string orderControl = orc.OrderControl
                .ValueOrDefault();

            DateTimeOffset dt = orc.DateTimeOfTransaction
                .ValueOrDefault();

            var enteredBy = orc.EnteredBy[0]
                .Select(x => x.IdNumber)
                .ValueOrDefault();

            var orderingProvider = orc.OrderingProvider[0]
                .Select(x => x.IdNumber)
                .ValueOrDefault();
        }
    }
}