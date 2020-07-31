namespace Machete.X12.Tests.Layouts
{
    using System;
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing860TransactionSetTests :
        X12MacheteTestHarness<X12v5010, X12Entity>
    {
        // TODO: need to find a X12 860 message
        [Test]
        public void Test()
        {
            string message =
                @"ISA*01*0000000000*01*0000000000*ZZ*ABCDEFGHIJKLMNO*ZZ*123456789012345*101127*1719*U*00400*000003438*0*P*>
GS*SH*4405197800*999999999*20111206*1045*49*X*004060
ST*856*0008
BSN*14*829716*20111206*142428*0002
HL*1**S
TD1*PCS*2****A3*60.310*LB
TD5**2*XXXX**XXXX
REF*BM*999999-001
REF*CN*5787970539
DTM*011*20111206
N1*SH*1 EDI SOURCE
N3*31875 SOLON RD
N4*SOLON*OH*44139
N1*OB*XYZ RETAIL
N3*P O BOX 9999999
N4*ATLANTA*GA*31139-0020**SN*9999
N1*SF*1 EDI SOURCE
N3*31875 SOLON ROAD
N4*SOLON*OH*44139
HL*2*1*O
PRF*99999817***20111205**BI9U9S93
HL*3*2*I
LIN*1*VP*87787D*UP*999999310145
SN1*1*24*EA
PO4*1*24*EA
PID*F****BLUE WIDGET
HL*4*2*I
LIN*2*VP*99887D*UP*999999311746
SN1*2*6*EA
PO4*1*6*EA
PID*F****RED WIDGET
CTT*4*30
SE*31*0008
GE*1*49
IEA*1*000000049";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<M856, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var date = queryResult
                .Select(x => x.Transaction)[0]
                .Select(x => x.BeginningShipNotice)
                .Select(x => x.Date)
                .ValueOrDefault();

            var time = queryResult
                .Select(x => x.Transaction)[0]
                .Select(x => x.BeginningShipNotice)
                .Select(x => x.Time)
                .ValueOrDefault();
            
            var purchaseOrderNumber = queryResult
                .Select(x => x.Transaction)[0]
                .Select(x => x.LoopHL)[1]
                .Select(x => x.PurchaseOrderReference)
                .Select(x => x.PurchaseOrderNumber)
                .ValueOrDefault();

            var contractNumber = queryResult
                .Select(x => x.Transaction)[0]
                .Select(x => x.LoopHL)[1]
                .Select(x => x.PurchaseOrderReference)
                .Select(x => x.ContractNumber)
                .ValueOrDefault();

            Assert.AreEqual(new DateTime(2011, 12, 6), date);
            Assert.AreEqual(new TimeSpan(14, 24, 28), time);
            Assert.AreEqual("99999817", purchaseOrderNumber);
            Assert.AreEqual("BI9U9S93", contractNumber);
        }
    }
}