namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing277AckL2200AConditionalTests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test(Description = "Condition : InformationSourceReceiptDate => 050, InformationSourceProcessDate => 009")]
        public void Test1()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
TRN*1*05347006051
DTP*050*D8*20070206
DTP*009*RD8*20070131-20070204
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*JO234567
REF*BLT*111
DTP*472*RD8*20070201-20070205
DTP*050*D8*20070206
HL*6*2*19*1
NM1*1P*2*HOME HOSPITAL PHYSICIANS*****XX*1666666666
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
SVC*HC:99203*150*****1
STC*P2:52*20070208
DTP*472*D8*20070201
DTP*050*D8*20070206
SE*35*0001GE*1*176073292
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var informationSourceReceiptDate = transactions
                .Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.TransmissionReceiptControlIdentifier)
                .Select(x => x.InformationSourceReceiptDate)
                .Select(x => x.DateTimeQualifier);
            
            Assert.IsTrue(informationSourceReceiptDate.HasValue);
            Assert.IsTrue(informationSourceReceiptDate.IsPresent);
            Assert.AreEqual("050", informationSourceReceiptDate.ValueOrDefault());

            var informationSourceProcessDate = transactions
                .Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.TransmissionReceiptControlIdentifier)
                .Select(x => x.InformationSourceProcessDate)
                .Select(x => x.DateTimeQualifier);
            
            Assert.IsTrue(informationSourceProcessDate.HasValue);
            Assert.IsTrue(informationSourceProcessDate.IsPresent);
            Assert.AreEqual("009", informationSourceProcessDate.ValueOrDefault());
        }
    }
}