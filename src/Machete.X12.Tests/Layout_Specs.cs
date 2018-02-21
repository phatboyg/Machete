namespace Machete.X12.Tests
{
    using System;
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;
    using X12Schema.V5010.Layouts;


    [TestFixture]
    public class Using_a_layout_on_any_message :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test]
        public void Should_match_a_valid_message()
        {
            const string example271 =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:~GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~ST*271*4321*005010X279~BHT*0022*11*10001234*20060501*1319~HL*1**20*1~NM1*PR*2*THE COMPANY*****PI*842610001~HL*2*1*21*1~NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035~HL*3*2*22*1~NM1*IL*1*SMITH*JOHN****MI*123456789~N3*PO BOX 12345laskdjflaskdjflasjdflsajdflkasjdlfjalsdjflaskjdfl*Suite X~N4*Atlanta*GA*30000~HL*4*3*23*0~TRN*2*93175-012547*9877281234~NM1*03*1*SMITH*JOHNNY~N3*PO BOX 12345*Suite X~N4*Atlanta*GA*30000~DMG*D8*19600409*M~HI*BK:123*BF:34555*BF:566677*BK:456*BF:3877~DTP*346*D8*20060101~MPI*C*AO*A**L3~EB*F*IND*55^CB^77***29***DY*33**Y**1:2:3~REF*Y4*653745725*5010 CASE DESCRIPTION 3H~EB*1*IND*55^PT*MA**24*26**LA*10**Y**4:5~LS*2120~NM1*P3*1*JONES*MARCUS****XX*1003853409~LE*2120~SE*25*4321~GE*1*1~IEA*1*000026531~";


            EntityResult<X12Entity> entityResult = Parser.Parse(example271);

            Assert.That(Schema.TryGetLayout(out ILayoutParserFactory<X12MessageLayout, X12Entity> layout), Is.True);

            IParser<X12Entity, X12MessageLayout> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, X12MessageLayout> result = entityResult.Query(query);

            Assert.That(result.HasResult, Is.True);
            Assert.That(result.Select(x => x.ISA), Is.Not.Null);
            Assert.That(result.Select(x => x.ISA).HasValue, Is.True);

            Value<DateTime> isaDate = result.Select(x => x.ISA).Select(x => x.Date);
            Assert.That(isaDate.HasValue, Is.True);
            Assert.That(isaDate.Value, Is.EqualTo(new DateTime(2009, 6, 1, 4, 6, 0)));

            Assert.That(result.Select(x => x.GS).HasValue, Is.True);
            Assert.That(result.Select(x => x.TransactionSetHeader).HasValue, Is.True);
        }
        
        [Test]
        public void Verify_can_parse_837I_claim()
        {
            const string message =
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

            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837I, X12Entity> layout));

            IParser<X12Entity, HC837I> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, HC837I> result = entityResult.Query(query);

            var interchangeSegment = result.Select(x => x.InterchangeControlHeader);
            var transactionSetHeader = result.Select(x => x.TransactionSetHeader);
            var groupSegment = result.Select(x => x.FunctionalGroupHeader);
            
            Assert.IsTrue(result.HasResult);
            Assert.IsNotNull(interchangeSegment);
            Assert.IsTrue(interchangeSegment.HasValue);
            Assert.IsTrue(groupSegment.HasValue);
            Assert.IsTrue(transactionSetHeader.HasValue);

            string firstName = result.Select(x => x.Submitter)[0].Select(x => x.Name).Select(x => x.FirstName).ValueOrDefault();
            
            Assert.AreEqual("Joe", firstName);
        }
    }
}