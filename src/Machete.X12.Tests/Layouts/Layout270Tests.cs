namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Layout270Tests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test]
        public void Verify_can_parse_270()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*270*1235*005010X279A1
BHT*0022*13*10001235*20060501*1320
HL*1**20*1
NM1*PR*2*ABC COMPANY*****PI*842610001
HL*2*1*21*1
NM1*1P*1*JONES*MARCUS****SV*0202034
HL*3*2*22*1
NM1*IL*1******MI*11122333301
HL*4*3*23*0
TRN*1*93175-012547*9877281234
NM1*03*1*SMITH*MARY
DMG*D8*19781014
DTP*291*D8*20060501
EQ*30
SE*15*1234
GE*1*1
IEA*1*000026531";

            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HEBI270, X12Entity> layout));

            IParser<X12Entity, HEBI270> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, HEBI270> result = entityResult.Query(query);

            var interchangeSegment = result.Select(x => x.InterchangeControlHeader);
            var transactionSetHeader = result.Select(x => x.TransactionSetHeader);
            var groupSegment = result.Select(x => x.FunctionalGroupHeader);
            
            Assert.IsTrue(result.HasResult);
            Assert.IsNotNull(interchangeSegment);
            Assert.IsTrue(interchangeSegment.HasValue);
            Assert.IsTrue(groupSegment.HasValue);
            Assert.IsTrue(transactionSetHeader.HasValue);

            string organizationName = result.Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.InformationSourceDetail)
                .Select(x => x.InformationSource)
                .Select(x => x.LastNameOrOrganizationName).ValueOrDefault();
            
            Assert.AreEqual("ABC COMPANY", organizationName);
        }
    }
}