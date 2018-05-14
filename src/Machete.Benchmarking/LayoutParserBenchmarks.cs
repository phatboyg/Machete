namespace Machete.Benchmarking
{
    using System;
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using BenchmarkSchema;
    using Configuration;
    using HL7;
    using HL7Schema.V26;
    using X12;
    using X12Schema.V5010;


    [Config(typeof(DotNetCoreBenchmarkConfig))]
    [MinColumn, MaxColumn]
    public class LayoutParserBenchmarks
    {
        IEntityParser<X12Entity> _x12Parser;
        readonly ParseResult<X12Entity> _parse1;
        readonly ISchema<X12Entity> _x12Schema;
        readonly ISchema<HL7Entity> _hl7Schema;
        readonly IEntityParser<HL7Entity> _hl7Parser;
        readonly ParseResult<HL7Entity> _parse2;

        const string _message =
            @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*837*987654*005010X223A3
BHT*0019*00*0123*19960918*0932*CH
NM1*41*2*JONES HOSPITAL*Joe****46*12345
PER*IC*JANE DOE*TE*9005555555
NM1*40*2*MEDICARE*****46*00120
HL*1**20*1
PRV*BI*PXC*203BA0200N
NM1*85*2*JONES HOSPITAL*****XX*9876540809
N3*225 MAIN STREET BARKLEY BUILDING
N4*CENTERVILLE*PA*17111
REF*EI*567891234
HL*2*1*22*0
SBR*P*18*******MB
NM1*IL*1*DOE*JOHN*T***MI*030005074A
N3*125 CITY AVENUE
N4*CENTERVILLE*PA*17111
DMG*D8*19261111*M
NM1*PR*2*MEDICARE B*****PI*00435
REF*G2*330127
CLM*756048Q*89.93***14:A:1*Y*A*Y*Y
DTP*434*D8*19960911
CL1*3**01
HI*BK:3669
HI*BF:4019*BF:79431
HI*BH:A1:D8:19261111*BH:A2:D8:19911101*BH:B1:D8:19261111*BH:B2:D8:19870101
HI*BE:A2:::15.31
HI*BG:09
NM1*71*1*JONES*JOHN*J
REF*1G*B99937
SBR*S*01*351630*STATE TEACHERS*****CI
DMG*D8*19271211*F
OI***Y***Y
NM1*IL*1*DOE*JANE*S***MI*222004433
N3*125 CITY AVENUE
N4*CENTERVILLE*PA*17111
NM1*PR*2*STATE TEACHERS*****PI*1135
LX*1
SV2*0305*HC:85025*13.39*UN*1
DTP*472*D8*19960911
LX*2
SV2*0730*HC:93005*76.54*UN*3
DTP*472*D8*19960911
SE*43*987654
GE*1*1
IEA*1*000026531";

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

        public LayoutParserBenchmarks()
        {
            _x12Schema = Schema.Factory.CreateX12<X12Entity>(x => x.AddFromNamespaceContaining<ISA>());
            _x12Parser = Parser.Factory.CreateX12(_x12Schema);
            _hl7Schema = Schema.Factory.CreateHL7<HL7Entity>(x => x.AddFromNamespaceContaining<MSH>());
            _hl7Parser = Parser.Factory.CreateHL7(_hl7Schema);
            _parse1 = _x12Parser.Parse(_message);
            _parse2 = _hl7Parser.Parse(_message2);
        }

//        [Benchmark]
        public void QueryLayoutBenchmark()
        {
//            EntityResult<X12Entity> entityResult = _parse1.Parse(message);

            _x12Schema.TryGetLayout(out ILayoutParserFactory<HC837I, X12Entity> layout);

            IParser<X12Entity, HC837I> query = _parse1.CreateQuery(layout);

            Result<Cursor<X12Entity>, HC837I> result = _parse1.Query(query);

            int controlNumber1 = result.Select(x => x.InterchangeControlHeader).Select(x => x.ControlNumber).ValueOrDefault();
            string controlNumber2 = result.Select(x => x.TransactionSetHeader).Select(x => x.ControlNumber).ValueOrDefault();
            int controlNumber3 = result.Select(x => x.FunctionalGroupHeader).Select(x => x.ControlNumber).ValueOrDefault();

            string firstName = result.Select(x => x.Submitter)[0].Select(x => x.Name).Select(x => x.FirstName).ValueOrDefault();
        }

//        [Benchmark]
        public void HL7QueryLayoutWithInitialParseSingleFieldBenchmark()
        {
            var parse = _hl7Parser.Parse(_message2);

            _hl7Schema.TryGetLayout(out ILayoutParserFactory<OrderedTestLayout, HL7Entity> layout);

            IParser<HL7Entity, OrderedTestLayout> query = parse.CreateQuery(layout);

            Result<Cursor<HL7Entity>, OrderedTestLayout> result = parse.Query(query);

            string placerOrderNumber = result.Select(x => x.ORC)
                .Select(x => x.PlacerGroupNumber)
                .Select(x => x.EntityIdentifier)
                .ValueOrDefault();
        }

        [Benchmark]
        public void HL7QueryLayoutWithInitialParseMultipleFieldBenchmark()
        {
            var parse = _hl7Parser.Parse(_message2);

            _hl7Schema.TryGetLayout(out ILayoutParserFactory<OrderedTestLayout, HL7Entity> layout);

            IParser<HL7Entity, OrderedTestLayout> query = parse.CreateQuery(layout);

            Result<Cursor<HL7Entity>, OrderedTestLayout> result = parse.Query(query);

            string orderGroupNumber = result.Select(x => x.ORC)
                .Select(x => x.PlacerGroupNumber)
                .Select(x => x.EntityIdentifier)
                .ValueOrDefault();

            string orderNumber = result.Select(x => x.ORC)
                .Select(x => x.PlacerOrderNumber)
                .Select(x => x.EntityIdentifier)
                .ValueOrDefault();

            string orderControl = result.Select(x => x.ORC)
                .Select(x => x.OrderControl)
                .ValueOrDefault();

            DateTimeOffset dt = result.Select(x => x.ORC)
                .Select(x => x.DateTimeOfTransaction)
                .ValueOrDefault();

            var enteredBy = result.Select(x => x.ORC)
                .Select(x => x.EnteredBy)[0]
                .Select(x => x.IdNumber)
                .ValueOrDefault();
        }

//        [Benchmark]
        public void HL7QueryLayoutWithoutInitialParseSingleFieldBenchmark()
        {
            _hl7Schema.TryGetLayout(out ILayoutParserFactory<OrderedTestLayout, HL7Entity> layout);

            IParser<HL7Entity, OrderedTestLayout> query = _parse2.CreateQuery(layout);
            Result<Cursor<HL7Entity>, OrderedTestLayout> result = _parse2.Query(query);

            string orderGroupNumber = result.Select(x => x.ORC)
                .Select(x => x.PlacerGroupNumber)
                .Select(x => x.EntityIdentifier)
                .ValueOrDefault();
        }

//        [Benchmark]
        public void HL7QueryLayoutWithoutInitialParseMultipleFieldBenchmark()
        {
            _hl7Schema.TryGetLayout(out ILayoutParserFactory<OrderedTestLayout, HL7Entity> layout);

            IParser<HL7Entity, OrderedTestLayout> query = _parse2.CreateQuery(layout);
            Result<Cursor<HL7Entity>, OrderedTestLayout> result = _parse2.Query(query);

            string orderGroupNumber = result.Select(x => x.ORC)
                .Select(x => x.PlacerGroupNumber)
                .Select(x => x.EntityIdentifier)
                .ValueOrDefault();

            string orderNumber = result.Select(x => x.ORC)
                .Select(x => x.PlacerOrderNumber)
                .Select(x => x.EntityIdentifier)
                .ValueOrDefault();

            string orderControl = result.Select(x => x.ORC)
                .Select(x => x.OrderControl)
                .ValueOrDefault();

            DateTimeOffset dt = result.Select(x => x.ORC)
                .Select(x => x.DateTimeOfTransaction)
                .ValueOrDefault();

            var enteredBy = result.Select(x => x.ORC)
                .Select(x => x.EnteredBy)[0]
                .Select(x => x.IdNumber)
                .ValueOrDefault();
        }
    }
}