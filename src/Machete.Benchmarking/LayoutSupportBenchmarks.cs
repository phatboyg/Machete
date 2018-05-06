namespace Machete.Benchmarking
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using Configuration;
    using X12;
    using X12Schema.V5010;


    [Config(typeof(DotNetCoreBenchmarkConfig))]
    [MinColumn, MaxColumn]
    public class LayoutSupportBenchmarks
    {
        IEntityParser<X12Entity> _x12Parser;
        readonly ParseResult<X12Entity> _parse1;
        readonly ISchema<X12Entity> _x12Schema;

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

        public LayoutSupportBenchmarks()
        {
            _x12Schema = Schema.Factory.CreateX12<X12Entity>(x => x.AddFromNamespaceContaining<ISA>());
            _x12Parser = Parser.Factory.CreateX12(_x12Schema);
            _parse1 = _x12Parser.Parse(_message);
        }

        [Benchmark]
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
    }
}