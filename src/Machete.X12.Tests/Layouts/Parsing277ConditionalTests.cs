namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing277ConditionalTests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test(Description = "Condition : InformationSourceDetail => 20, InformationReceiverDetail => 21, ServiceProviderDetail => 19")]
        public void Test1()
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
REF*EA*111
REF*D9*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*SM123456
REF*BLT*111
REF*EA*111
REF*D9*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*SM123456
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";

            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var informationSourceLevel = transactions
                .Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(informationSourceLevel.HasValue);
            Assert.IsTrue(informationSourceLevel.IsPresent);
            Assert.AreEqual("20", informationSourceLevel.ValueOrDefault());

            var informationReceiverLevel = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(informationReceiverLevel.HasValue);
            Assert.IsTrue(informationReceiverLevel.IsPresent);
            Assert.AreEqual("21", informationReceiverLevel.ValueOrDefault());

            var serviceProviderLevel = transactions
                .Select(x => x.ServiceProviderDetail)[0]
                .Select(x => x.ServiceProviderLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(serviceProviderLevel.HasValue);
            Assert.IsTrue(serviceProviderLevel.IsPresent);
            Assert.AreEqual("19", serviceProviderLevel.ValueOrDefault());
        }

        [Test(Description = "Condition : InformationSourceDetail => 20, InformationReceiverDetail => 21, ServiceProviderDetail => missing")]
        public void Test2()
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
REF*EA*111
REF*D9*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*SM123456
REF*BLT*111
REF*EA*111
REF*D9*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*SM123456
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";

            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var informationSourceLevel = transactions
                .Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(informationSourceLevel.HasValue);
            Assert.IsTrue(informationSourceLevel.IsPresent);
            Assert.AreEqual("20", informationSourceLevel.ValueOrDefault());

            var informationReceiverLevel = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(informationReceiverLevel.HasValue);
            Assert.IsTrue(informationReceiverLevel.IsPresent);
            Assert.AreEqual("21", informationReceiverLevel.ValueOrDefault());

            var serviceProviderLevel = transactions
                .Select(x => x.ServiceProviderDetail)[0]
                .Select(x => x.ServiceProviderLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(serviceProviderLevel.HasValue);
            Assert.IsFalse(serviceProviderLevel.IsPresent);
        }

        [Test(Description = "Condition : InformationSourceDetail => 20, InformationReceiverDetail => missing, ServiceProviderDetail => missing")]
        public void Test3()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*SM123456
REF*BLT*111
REF*EA*111
REF*D9*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*SM123456
REF*BLT*111
REF*EA*111
REF*D9*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*SM123456
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";

            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var informationSourceLevel = transactions
                .Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(informationSourceLevel.HasValue);
            Assert.IsTrue(informationSourceLevel.IsPresent);
            Assert.AreEqual("20", informationSourceLevel.ValueOrDefault());

            var informationReceiverLevel = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(informationReceiverLevel.HasValue);
            Assert.IsFalse(informationReceiverLevel.IsPresent);

            var serviceProviderLevel = transactions
                .Select(x => x.ServiceProviderDetail)[0]
                .Select(x => x.ServiceProviderLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(serviceProviderLevel.HasValue);
            Assert.IsFalse(serviceProviderLevel.IsPresent);
        }

        [Test(Description = "Condition : InformationSourceDetail => missing, InformationReceiverDetail => 21, ServiceProviderDetail => missing")]
        public void Test4()
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
REF*EA*111
REF*D9*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*SM123456
REF*BLT*111
REF*EA*111
REF*D9*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*SM123456
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";

            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var informationSourceLevel = transactions
                .Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(informationSourceLevel.HasValue);
            Assert.IsFalse(informationSourceLevel.IsPresent);

            var informationReceiverLevel = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(informationReceiverLevel.HasValue);
            Assert.IsTrue(informationReceiverLevel.IsPresent);
            Assert.AreEqual("21", informationReceiverLevel.ValueOrDefault());

            var serviceProviderLevel = transactions
                .Select(x => x.ServiceProviderDetail)[0]
                .Select(x => x.ServiceProviderLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(serviceProviderLevel.HasValue);
            Assert.IsFalse(serviceProviderLevel.IsPresent);
        }

        [Test(Description = "Condition : InformationSourceDetail => 20, InformationReceiverDetail => missing, ServiceProviderDetail => 19")]
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
REF*EA*111
REF*D9*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*SM123456
REF*BLT*111
REF*EA*111
REF*D9*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*SM123456
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";

            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var informationSourceLevel = transactions
                .Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(informationSourceLevel.HasValue);
            Assert.IsTrue(informationSourceLevel.IsPresent);
            Assert.AreEqual("20", informationSourceLevel.ValueOrDefault());

            var informationReceiverLevel = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(informationReceiverLevel.HasValue);
            Assert.IsFalse(informationReceiverLevel.IsPresent);

            var serviceProviderLevel = transactions
                .Select(x => x.ServiceProviderDetail)[0]
                .Select(x => x.ServiceProviderLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(serviceProviderLevel.HasValue);
            Assert.IsTrue(serviceProviderLevel.IsPresent);
            Assert.AreEqual("19", serviceProviderLevel.ValueOrDefault());
        }

        [Test(Description = "Condition : InformationSourceDetail => missing, InformationReceiverDetail => 21, ServiceProviderDetail => 19")]
        public void Test6()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
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
REF*EA*111
REF*D9*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*SM123456
REF*BLT*111
REF*EA*111
REF*D9*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*SM123456
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";

            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var informationSourceLevel = transactions
                .Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(informationSourceLevel.HasValue);
            Assert.IsFalse(informationSourceLevel.IsPresent);

            var informationReceiverLevel = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(informationReceiverLevel.HasValue);
            Assert.IsTrue(informationReceiverLevel.IsPresent);
            Assert.AreEqual("21", informationReceiverLevel.ValueOrDefault());

            var serviceProviderLevel = transactions
                .Select(x => x.ServiceProviderDetail)[0]
                .Select(x => x.ServiceProviderLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(serviceProviderLevel.HasValue);
            Assert.IsTrue(serviceProviderLevel.IsPresent);
            Assert.AreEqual("19", serviceProviderLevel.ValueOrDefault());
        }

        [Test(Description = "Condition : InformationSourceDetail => missing, InformationReceiverDetail => missing, ServiceProviderDetail => missing")]
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
REF*EA*111
REF*D9*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*SM123456
REF*BLT*111
REF*EA*111
REF*D9*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*SM123456
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";

            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var informationSourceLevel = transactions
                .Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(informationSourceLevel.HasValue);
            Assert.IsFalse(informationSourceLevel.IsPresent);

            var informationReceiverLevel = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(informationReceiverLevel.HasValue);
            Assert.IsFalse(informationReceiverLevel.IsPresent);

            var serviceProviderLevel = transactions
                .Select(x => x.ServiceProviderDetail)[0]
                .Select(x => x.ServiceProviderLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(serviceProviderLevel.HasValue);
            Assert.IsFalse(serviceProviderLevel.IsPresent);
        }

        [Test(Description = "Condition : InformationSourceDetail => missing, InformationReceiverDetail => missing, ServiceProviderDetail => 19")]
        public void Test8()
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
REF*EA*111
REF*D9*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*SM123456
REF*BLT*111
REF*EA*111
REF*D9*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*SM123456
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";

            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var informationSourceLevel = transactions
                .Select(x => x.InformationSourceDetail)[0]
                .Select(x => x.InformationSourceLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(informationSourceLevel.HasValue);
            Assert.IsFalse(informationSourceLevel.IsPresent);

            var informationReceiverLevel = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsFalse(informationReceiverLevel.HasValue);
            Assert.IsFalse(informationReceiverLevel.IsPresent);

            var serviceProviderLevel = transactions
                .Select(x => x.ServiceProviderDetail)[0]
                .Select(x => x.ServiceProviderLevel)
                .Select(x => x.LevelCode);
            
            Assert.IsTrue(serviceProviderLevel.HasValue);
            Assert.IsTrue(serviceProviderLevel.IsPresent);
            Assert.AreEqual("19", serviceProviderLevel.ValueOrDefault());
        }

//        [Test(Description = "Condition : InformationSourceDetail => 20, InformationReceiverDetail => 21, ServiceProviderDetail => missing")]
//        public void Test()
//        {
//            string message =
//                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
//GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
//ST*277*0001*005010X228
//BHT*0085*08*277PEND123*20070210*1635*NO
//HL*1**20*1
//NM1*PR*2*ABC INSURANCE*****PI*12345
//HL*2*1*21*1
//NM1*41*2*XYZ SERVICE*****46*X67E
//HL*3*2*19*1
//NM1*1P*2*HOME HOSPITAL*****XX*1666666661
//HL*4*3*PT
//NM1*QC*1*SMITH*FRED****MI*123456789A
//TRN*1*05347006051
//STC*P3:317*20070208**8513.88
//REF*EJ*SM123456
//REF*BLT*111
//REF*EA*111
//REF*D9*111
//DTP*472*RD8*20070131-20070204
//DTP*106*D8*20070206
//HL*5*3*PT
//NM1*QC*1*JONES*MARY****MI*234567890A
//TRN*1*0529675341
//STC*P1:20*20070210**7599
//REF*EJ*SM123456
//REF*BLT*111
//REF*EA*111
//REF*D9*111
//DTP*472*RD8*20070201-20070205
//DTP*106*D8*20070206
//HL*7*6*PT
//NM1*QC*1*MANN*JOSEPH****MI*345678901
//TRN*1*051681010827
//STC*P2:247*20070208**150
//REF*EJ*SM123456
//DTP*472*D8*20070201
//DTP*106*D8*20070206
//SE*35*0001
//GE*1*1
//IEA*1*176073292";
//
//            var parseResult = Parser.Parse(message);
//
//            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));
//
//            var query = parseResult.CreateQuery(layout);
//
//            var queryResult = parseResult.Query(query);
//
//            Assert.IsTrue(queryResult.HasResult);
//
//            var transactions = queryResult.Select(x => x.Transactions)[0];
//            
//            Assert.IsTrue(transactions.HasValue);
//
//            var informationSourceLevel = transactions
//                .Select(x => x.InformationSourceDetail)[0]
//                .Select(x => x.InformationSourceLevel)
//                .Select(x => x.LevelCode);
//            
//            Assert.IsTrue(informationSourceLevel.HasValue);
//            Assert.IsTrue(informationSourceLevel.IsPresent);
//            Assert.AreEqual("20", informationSourceLevel.ValueOrDefault());
//
//            var informationReceiverLevel = transactions
//                .Select(x => x.InformationReceiverDetail)[0]
//                .Select(x => x.InformationReceiverLevel)
//                .Select(x => x.LevelCode);
//            
//            Assert.IsTrue(informationReceiverLevel.HasValue);
//            Assert.IsTrue(informationReceiverLevel.IsPresent);
//            Assert.AreEqual("21", informationReceiverLevel.ValueOrDefault());
//
//            var serviceProviderLevel = transactions
//                .Select(x => x.ServiceProviderDetail)[0]
//                .Select(x => x.ServiceProviderLevel)
//                .Select(x => x.LevelCode);
//            
//            Assert.IsTrue(serviceProviderLevel.HasValue);
//            Assert.IsTrue(serviceProviderLevel.IsPresent);
//            Assert.AreEqual("19", serviceProviderLevel.ValueOrDefault());
//        }
    }
}