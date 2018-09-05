namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing277AckL2000BConditionalTests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test(Description = "Condition : InformationSourceDetail.InformationSourceLevel => 20, InformationReceiverDetail.InformationSourceLevel => missing, BillingProviderOfServiceDetail.BillingProviderOfServiceLevel => missing")]
        public void Test1()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*SM123456
REF*BLT*111
DTP*472*RD8*20070131-20070204
DTP*050*D8*20070206
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

            var levelCode = transactions
                .Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(levelCode.HasValue);
            Assert.IsTrue(levelCode.IsPresent);
            Assert.AreEqual("20", levelCode.ValueOrDefault());

            var informationSourceLevel = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(informationSourceLevel.HasValue);
            Assert.IsFalse(informationSourceLevel.IsPresent);

            var billingProviderOfServiceLevel = transactions
                .Select(x => x.BillingProviderOfServiceDetail)[0]
                .Select(x => x.BillingProviderOfServiceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(billingProviderOfServiceLevel.HasValue);
            Assert.IsFalse(billingProviderOfServiceLevel.IsPresent);
        }
        
        [Test(Description = "Condition : InformationReceiverDetail.InformationSourceLevel => 21, InformationSourceDetail.InformationSourceLevel => missing, BillingProviderOfServiceDetail.BillingProviderOfServiceLevel => missing")]
        public void Test2()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*SM123456
REF*BLT*111
DTP*472*RD8*20070131-20070204
DTP*050*D8*20070206
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

            var levelCode = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(levelCode.HasValue);
            Assert.IsTrue(levelCode.IsPresent);
            Assert.AreEqual("21", levelCode.ValueOrDefault());

            var informationSourceLevel = transactions
                .Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(informationSourceLevel.HasValue);
            Assert.IsFalse(informationSourceLevel.IsPresent);

            var billingProviderOfServiceLevel = transactions
                .Select(x => x.BillingProviderOfServiceDetail)[0]
                .Select(x => x.BillingProviderOfServiceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(billingProviderOfServiceLevel.HasValue);
            Assert.IsFalse(billingProviderOfServiceLevel.IsPresent);
        }
        
        [Test(Description = "Condition : BillingProviderOfServiceDetail.BillingProviderOfServiceLevel => 19, InformationSourceDetail.InformationSourceLevel => missing, InformationReceiverDetail.InformationSourceLevel => missing")]
        public void Test3()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*SM123456
REF*BLT*111
DTP*472*RD8*20070131-20070204
DTP*050*D8*20070206
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

            var levelCode = transactions
                .Select(x => x.BillingProviderOfServiceDetail)[0]
                .Select(x => x.BillingProviderOfServiceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(levelCode.HasValue);
            Assert.IsTrue(levelCode.IsPresent);
            Assert.AreEqual("19", levelCode.ValueOrDefault());
        }
        
        [Test(Description = "Condition : InformationSourceDetail.InformationSourceLevel => 20, InformationReceiverDetail.InformationSourceLevel => 21, BillingProviderOfServiceDetail.BillingProviderOfServiceLevel => 19")]
        public void Test4()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*SM123456
REF*BLT*111
DTP*472*RD8*20070131-20070204
DTP*050*D8*20070206
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

            var levelCode = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(levelCode.HasValue);
            Assert.IsTrue(levelCode.IsPresent);
            Assert.AreEqual("21", levelCode.ValueOrDefault());

            var billingProviderOfServiceLevel = transactions
                .Select(x => x.BillingProviderOfServiceDetail)[0]
                .Select(x => x.BillingProviderOfServiceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(billingProviderOfServiceLevel.HasValue);
            Assert.IsTrue(billingProviderOfServiceLevel.IsPresent);
            Assert.AreEqual("19", billingProviderOfServiceLevel.ValueOrDefault());

            var informationSourceLevel = transactions
                .Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(informationSourceLevel.HasValue);
            Assert.IsTrue(informationSourceLevel.IsPresent);
            Assert.AreEqual("20", informationSourceLevel.ValueOrDefault());
        }
        
        [Test(Description = "Condition : InformationSourceDetail.InformationSourceLevel => 20, InformationReceiverDetail.InformationSourceLevel => missing, BillingProviderOfServiceDetail.BillingProviderOfServiceLevel => 19")]
        public void Test5()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*SM123456
REF*BLT*111
DTP*472*RD8*20070131-20070204
DTP*050*D8*20070206
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

            var levelCode = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(levelCode.HasValue);
            Assert.IsFalse(levelCode.IsPresent);

            var billingProviderOfServiceLevel = transactions
                .Select(x => x.BillingProviderOfServiceDetail)[0]
                .Select(x => x.BillingProviderOfServiceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(billingProviderOfServiceLevel.HasValue);
            Assert.IsTrue(billingProviderOfServiceLevel.IsPresent);
            Assert.AreEqual("19", billingProviderOfServiceLevel.ValueOrDefault());

            var informationSourceLevel = transactions
                .Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(informationSourceLevel.HasValue);
            Assert.IsTrue(informationSourceLevel.IsPresent);
            Assert.AreEqual("20", informationSourceLevel.ValueOrDefault());
        }
        
        [Test(Description = "Condition : InformationSourceDetail.InformationSourceLevel => 20, InformationReceiverDetail.InformationSourceLevel => 21, BillingProviderOfServiceDetail.BillingProviderOfServiceLevel => missing")]
        public void Test6()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*SM123456
REF*BLT*111
DTP*472*RD8*20070131-20070204
DTP*050*D8*20070206
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

            var levelCode = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(levelCode.HasValue);
            Assert.IsTrue(levelCode.IsPresent);
            Assert.AreEqual("21", levelCode.ValueOrDefault());

            var billingProviderOfServiceLevel = transactions
                .Select(x => x.BillingProviderOfServiceDetail)[0]
                .Select(x => x.BillingProviderOfServiceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(billingProviderOfServiceLevel.HasValue);
            Assert.IsFalse(billingProviderOfServiceLevel.IsPresent);

            var informationSourceLevel = transactions
                .Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(informationSourceLevel.HasValue);
            Assert.IsTrue(informationSourceLevel.IsPresent);
            Assert.AreEqual("20", informationSourceLevel.ValueOrDefault());
        }
        
        [Test(Description = "Condition : InformationSourceDetail.InformationSourceLevel => missing, InformationReceiverDetail.InformationSourceLevel => missing, BillingProviderOfServiceDetail.BillingProviderOfServiceLevel => missing")]
        public void Test7()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*SM123456
REF*BLT*111
DTP*472*RD8*20070131-20070204
DTP*050*D8*20070206
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

            var levelCode = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(levelCode.HasValue);
            Assert.IsFalse(levelCode.IsPresent);

            var billingProviderOfServiceLevel = transactions
                .Select(x => x.BillingProviderOfServiceDetail)[0]
                .Select(x => x.BillingProviderOfServiceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(billingProviderOfServiceLevel.HasValue);
            Assert.IsFalse(billingProviderOfServiceLevel.IsPresent);

            var informationSourceLevel = transactions
                .Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(informationSourceLevel.HasValue);
            Assert.IsFalse(informationSourceLevel.IsPresent);
        }
    }
}