namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing277AckL2200BConditionalTests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test(Description = "Condition : TotalAcceptedQuantity => missing, TotalRejectedQuantity => missing, TotalAcceptedAmount => YU, TotalRejectedAmount => YY")]
        public void Test1()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0002*005010X214
BHT*0085*08*277X2140002*20060201*0405*TH
HL*1**20*1
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00
TRN*1*200201312005S00002XYZABC
DTP*050*D8*20060131
DTP*009*D8*20060201
HL*2*1*21*0
NM1*41*2*LAST BILLING SERVICE*****46*S00002
TRN*2*20020131052389
STC*A3:24:41**U
AMT*YU*800
AMT*YY*800
SE *14*00002
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var totalAcceptedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsFalse(totalAcceptedQuantity.HasValue);
            Assert.IsFalse(totalAcceptedQuantity.IsPresent);

            var totalRejectedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsFalse(totalRejectedQuantity.HasValue);
            Assert.IsFalse(totalRejectedQuantity.IsPresent);

            var totalAcceptedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsTrue(totalAcceptedAmount.HasValue);
            Assert.IsTrue(totalAcceptedAmount.IsPresent);
            Assert.AreEqual("YU", totalAcceptedAmount.ValueOrDefault());

            var totalRejectedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsTrue(totalRejectedAmount.HasValue);
            Assert.IsTrue(totalRejectedAmount.IsPresent);
            Assert.AreEqual("YY", totalRejectedAmount.ValueOrDefault());
        }

        [Test(Description = "Condition : TotalAcceptedQuantity => 90, TotalRejectedQuantity => AA, TotalAcceptedAmount => YU, TotalRejectedAmount => YY")]
        public void Test2()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0002*005010X214
BHT*0085*08*277X2140002*20060201*0405*TH
HL*1**20*1
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00
TRN*1*200201312005S00002XYZABC
DTP*050*D8*20060131
DTP*009*D8*20060201
HL*2*1*21*0
NM1*41*2*LAST BILLING SERVICE*****46*S00002
TRN*2*20020131052389
STC*A3:24:41**U
QTY*90*3
QTY*AA*3
AMT*YU*800
AMT*YY*800
SE *14*00002
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var totalAcceptedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsTrue(totalAcceptedAmount.HasValue);
            Assert.IsTrue(totalAcceptedAmount.IsPresent);
            Assert.AreEqual("YU", totalAcceptedAmount.ValueOrDefault());

            var totalRejectedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsTrue(totalRejectedAmount.HasValue);
            Assert.IsTrue(totalRejectedAmount.IsPresent);
            Assert.AreEqual("YY", totalRejectedAmount.ValueOrDefault());

            var totalAcceptedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsTrue(totalAcceptedQuantity.HasValue);
            Assert.IsTrue(totalAcceptedQuantity.IsPresent);
            Assert.AreEqual("90", totalAcceptedQuantity.ValueOrDefault());

            var totalRejectedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsTrue(totalRejectedQuantity.HasValue);
            Assert.IsTrue(totalRejectedQuantity.IsPresent);
            Assert.AreEqual("AA", totalRejectedQuantity.ValueOrDefault());
        }

        [Test(Description = "Condition : TotalAcceptedQuantity => missing, TotalRejectedQuantity => AA, TotalAcceptedAmount => missing, TotalRejectedAmount => YY")]
        public void Test3()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0002*005010X214
BHT*0085*08*277X2140002*20060201*0405*TH
HL*1**20*1
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00
TRN*1*200201312005S00002XYZABC
DTP*050*D8*20060131
DTP*009*D8*20060201
HL*2*1*21*0
NM1*41*2*LAST BILLING SERVICE*****46*S00002
TRN*2*20020131052389
STC*A3:24:41**U
QTY*AA*3
AMT*YY*800
SE *14*00002
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var totalAcceptedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsFalse(totalAcceptedQuantity.HasValue);
            Assert.IsFalse(totalAcceptedQuantity.IsPresent);

            var totalAcceptedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsFalse(totalAcceptedAmount.HasValue);
            Assert.IsFalse(totalAcceptedAmount.IsPresent);

            var totalRejectedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsTrue(totalRejectedQuantity.HasValue);
            Assert.IsTrue(totalRejectedQuantity.IsPresent);
            Assert.AreEqual("AA", totalRejectedQuantity.ValueOrDefault());

            var totalRejectedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsTrue(totalRejectedAmount.HasValue);
            Assert.IsTrue(totalRejectedAmount.IsPresent);
            Assert.AreEqual("YY", totalRejectedAmount.ValueOrDefault());
        }

        [Test(Description = "Condition : TotalAcceptedQuantity => missing, TotalRejectedQuantity => AA, TotalAcceptedAmount => YU, TotalRejectedAmount => missing")]
        public void Test4()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0002*005010X214
BHT*0085*08*277X2140002*20060201*0405*TH
HL*1**20*1
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00
TRN*1*200201312005S00002XYZABC
DTP*050*D8*20060131
DTP*009*D8*20060201
HL*2*1*21*0
NM1*41*2*LAST BILLING SERVICE*****46*S00002
TRN*2*20020131052389
STC*A3:24:41**U
QTY*AA*3
AMT*YU*800
SE *14*00002
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var totalAcceptedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsFalse(totalAcceptedQuantity.HasValue);
            Assert.IsFalse(totalAcceptedQuantity.IsPresent);

            var totalRejectedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsTrue(totalRejectedQuantity.HasValue);
            Assert.IsTrue(totalRejectedQuantity.IsPresent);
            Assert.AreEqual("AA", totalRejectedQuantity.ValueOrDefault());

            var totalRejectedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsFalse(totalRejectedAmount.HasValue);
            Assert.IsFalse(totalRejectedAmount.IsPresent);

            var totalAcceptedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsTrue(totalAcceptedAmount.HasValue);
            Assert.IsTrue(totalAcceptedAmount.IsPresent);
            Assert.AreEqual("YU", totalAcceptedAmount.ValueOrDefault());
        }

        [Test(Description = "Condition : TotalAcceptedQuantity => 90, TotalRejectedQuantity => missing, TotalAcceptedAmount => missing, TotalRejectedAmount => YY")]
        public void Test5()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0002*005010X214
BHT*0085*08*277X2140002*20060201*0405*TH
HL*1**20*1
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00
TRN*1*200201312005S00002XYZABC
DTP*050*D8*20060131
DTP*009*D8*20060201
HL*2*1*21*0
NM1*41*2*LAST BILLING SERVICE*****46*S00002
TRN*2*20020131052389
STC*A3:24:41**U
QTY*90*3
AMT*YY*800
SE *14*00002
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var totalRejectedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsFalse(totalRejectedQuantity.HasValue);
            Assert.IsFalse(totalRejectedQuantity.IsPresent);

            var totalAcceptedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsFalse(totalAcceptedAmount.HasValue);
            Assert.IsFalse(totalAcceptedAmount.IsPresent);

            var totalRejectedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsTrue(totalRejectedAmount.HasValue);
            Assert.IsTrue(totalRejectedAmount.IsPresent);
            Assert.AreEqual("YY", totalRejectedAmount.ValueOrDefault());

            var totalAcceptedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsTrue(totalAcceptedQuantity.HasValue);
            Assert.IsTrue(totalAcceptedQuantity.IsPresent);
            Assert.AreEqual("90", totalAcceptedQuantity.ValueOrDefault());
        }

        [Test(Description = "Condition : TotalAcceptedQuantity => 90, TotalRejectedQuantity => missing, TotalAcceptedAmount => YU, TotalRejectedAmount => missing")]
        public void Test6()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0002*005010X214
BHT*0085*08*277X2140002*20060201*0405*TH
HL*1**20*1
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00
TRN*1*200201312005S00002XYZABC
DTP*050*D8*20060131
DTP*009*D8*20060201
HL*2*1*21*0
NM1*41*2*LAST BILLING SERVICE*****46*S00002
TRN*2*20020131052389
STC*A3:24:41**U
QTY*90*3
AMT*YU*800
SE *14*00002
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var totalAcceptedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsTrue(totalAcceptedQuantity.HasValue);
            Assert.IsTrue(totalAcceptedQuantity.IsPresent);
            Assert.AreEqual("90", totalAcceptedQuantity.ValueOrDefault());

            var totalAcceptedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsTrue(totalAcceptedAmount.HasValue);
            Assert.IsTrue(totalAcceptedAmount.IsPresent);
            Assert.AreEqual("YU", totalAcceptedAmount.ValueOrDefault());
        }

        [Test(Description = "Condition : TotalAcceptedQuantity => missing, TotalRejectedQuantity => missing, TotalAcceptedAmount => YY, TotalRejectedAmount => missing")]
        public void Test7()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0002*005010X214
BHT*0085*08*277X2140002*20060201*0405*TH
HL*1**20*1
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00
TRN*1*200201312005S00002XYZABC
DTP*050*D8*20060131
DTP*009*D8*20060201
HL*2*1*21*0
NM1*41*2*LAST BILLING SERVICE*****46*S00002
TRN*2*20020131052389
STC*A3:24:41**U
AMT*YY*800
SE*14*00002
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var totalAcceptedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsFalse(totalAcceptedQuantity.HasValue);
            Assert.IsFalse(totalAcceptedQuantity.IsPresent);

            var totalRejectedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsFalse(totalRejectedQuantity.HasValue);
            Assert.IsFalse(totalRejectedQuantity.IsPresent);

            var totalRejectedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsTrue(totalRejectedAmount.HasValue);
            Assert.IsTrue(totalRejectedAmount.IsPresent);
            Assert.AreEqual("YY", totalRejectedAmount.ValueOrDefault());
        }

        [Test(Description = "Condition : TotalAcceptedQuantity => missing, TotalRejectedQuantity => missing, TotalAcceptedAmount => YU, TotalRejectedAmount => missing")]
        public void Test8()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0002*005010X214
BHT*0085*08*277X2140002*20060201*0405*TH
HL*1**20*1
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00
TRN*1*200201312005S00002XYZABC
DTP*050*D8*20060131
DTP*009*D8*20060201
HL*2*1*21*0
NM1*41*2*LAST BILLING SERVICE*****46*S00002
TRN*2*20020131052389
STC*A3:24:41**U
AMT*YU*800
SE*14*00002
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var totalAcceptedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsTrue(totalAcceptedAmount.HasValue);
            Assert.IsTrue(totalAcceptedAmount.IsPresent);
            Assert.AreEqual("YU", totalAcceptedAmount.ValueOrDefault());
        }

        [Test(Description = "Condition : TotalAcceptedQuantity => missing, TotalRejectedQuantity => missing, TotalAcceptedAmount => YU, TotalRejectedAmount => YY")]
        public void Test9()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0002*005010X214
BHT*0085*08*277X2140002*20060201*0405*TH
HL*1**20*1
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00
TRN*1*200201312005S00002XYZABC
DTP*050*D8*20060131
DTP*009*D8*20060201
HL*2*1*21*0
NM1*41*2*LAST BILLING SERVICE*****46*S00002
TRN*2*20020131052389
STC*A3:24:41**U
AMT*YU*800
AMT*YY*800
SE *14*00002
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var totalAcceptedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsTrue(totalAcceptedAmount.HasValue);
            Assert.IsTrue(totalAcceptedAmount.IsPresent);
            Assert.AreEqual("YU", totalAcceptedAmount.ValueOrDefault());

            var totalRejectedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsTrue(totalRejectedAmount.HasValue);
            Assert.IsTrue(totalRejectedAmount.IsPresent);
            Assert.AreEqual("YY", totalRejectedAmount.ValueOrDefault());

            var totalAcceptedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsFalse(totalAcceptedQuantity.HasValue);
            Assert.IsFalse(totalAcceptedQuantity.IsPresent);

            var totalRejectedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsFalse(totalRejectedQuantity.HasValue);
            Assert.IsFalse(totalRejectedQuantity.IsPresent);
        }

        [Test(Description = "Condition : TotalAcceptedQuantity => 90, TotalRejectedQuantity => AA, TotalAcceptedAmount => missing, TotalRejectedAmount => missing")]
        public void Test10()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0002*005010X214
BHT*0085*08*277X2140002*20060201*0405*TH
HL*1**20*1
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00
TRN*1*200201312005S00002XYZABC
DTP*050*D8*20060131
DTP*009*D8*20060201
HL*2*1*21*0
NM1*41*2*LAST BILLING SERVICE*****46*S00002
TRN*2*20020131052389
STC*A3:24:41**U
QTY*90*3
QTY*AA*3
SE *14*00002
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var totalAcceptedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsFalse(totalAcceptedAmount.HasValue);
            Assert.IsFalse(totalAcceptedAmount.IsPresent);

            var totalRejectedAmount = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsFalse(totalRejectedAmount.HasValue);
            Assert.IsFalse(totalRejectedAmount.IsPresent);

            var totalAcceptedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsTrue(totalAcceptedQuantity.HasValue);
            Assert.IsTrue(totalAcceptedQuantity.IsPresent);
            Assert.AreEqual("90", totalAcceptedQuantity.ValueOrDefault());

            var totalRejectedQuantity = transactions
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsTrue(totalRejectedQuantity.HasValue);
            Assert.IsTrue(totalRejectedQuantity.IsPresent);
            Assert.AreEqual("AA", totalRejectedQuantity.ValueOrDefault());
        }
    }
}