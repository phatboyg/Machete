namespace Machete.X12.Tests.EntityFieldAccessTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class TryGetSliceTests :
        X12MacheteTestHarness<TestX12Entity, X12Entity>
    {
        string _message;

        [OneTimeSetUp]
        public void Setup()
        {
            _message =
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
        }
        
        [Test]
        public void Should_be_able_to_access_entity_fields()
        {
            EntityResult<X12Entity> entityResult = Parser.Parse(_message);

            var query = entityResult.CreateQuery(q =>
                from isa in q.Select<ISASegment>()
                from gs in q.Select<GSSegment>()
                from st in q.Select<STSegment>()
                select st);

            var result = entityResult.Query(query);

            Assert.IsNotNull(result.Result.ParsedText);
            Assert.IsTrue(result.Result.ParsedText.TryGetSlice(1, out var slice));
            Assert.AreEqual("837", slice.Text.ToString());
        }
        
        [Test]
        public void Should_be_able_to_get_fields()
        {
            ParseResult<X12Entity> entityResult = Parser.Parse(_message);

            var query = entityResult.CreateQuery(q =>
                from isa in q.Select<ISASegment>()
                from gs in q.Select<GSSegment>()
                from st in q.Select<STSegment>()
                select st);

            var result = entityResult.Query(query);

            Assert.IsNotNull(result.Result.ParsedText);
            Assert.IsTrue(result.Result.ParsedText.TryGetSlice(3, out var slice));
            Assert.AreEqual("005010X223A3", slice.Text.ToString());
        }
        
        [Test]
        public void Should_be_able_return_no_fields_on_empty_entity()
        {
            string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*837*987654*005010X223A3";
            
            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from isa in q.Select<ISASegment>()
                from gs in q.Select<GSSegment>()
                from st in q.Select<STSegment>()
                select st);

            var result = entityResult.Query(query);
            
            Assert.IsNotNull(result.Result.ParsedText);
            Assert.IsFalse(result.Result.ParsedText.TryGetSlice(4, out var slice));
            Assert.AreEqual(Slice.Missing, slice);
        }
        
        [Test]
        public void Should_not_throw_when_trying_to_access_fields_on_missing_entity()
        {
            EntityResult<X12Entity> entityResult = Parser.Parse(_message);

            Assert.IsTrue(entityResult.TryGetEntity(2, out STSegment segment));
            Assert.IsNotNull(segment.ParsedText);
            Assert.IsFalse(segment.ParsedText.TryGetSlice(5, out var slice));
            Assert.AreEqual(Slice.Missing, slice);
            Assert.IsFalse(slice.TryGetSlice(2, out _));
        }
        
        [Test]
        public void Should_be_able_to_get_component_of_complex_field_from_entity_text_slice()
        {
            ParseResult<X12Entity> parse = Parser.Parse(_message);

            Assert.IsTrue(parse.TryGetEntity(21, out X12Segment segment));
            Assert.IsTrue(segment is CLMSegment);
            Assert.IsTrue(segment.ParsedText.TryGetSlice(5, out var slice));
            Assert.AreEqual("14:A:1", slice.Text.ToString());
            Assert.IsTrue(slice.TryGetSlice(1, out var componentSlice));
            Assert.AreEqual("A", componentSlice.Text.ToString());
        }
        
        [Test]
        public void Should_not_throw_trying_to_get_component_text_slice_having_negative_index()
        {
            ParseResult<X12Entity> parse = Parser.Parse(_message);

            Assert.IsTrue(parse.TryGetEntity(21, out X12Segment segment));
            Assert.IsTrue(segment is CLMSegment);
            Assert.IsTrue(segment.ParsedText.TryGetSlice(5, out var slice));
            Assert.AreEqual("14:A:1", slice.Text.ToString());
            Assert.IsFalse(slice.TryGetSlice(-1, out var componentSlice));
        }
    }
}