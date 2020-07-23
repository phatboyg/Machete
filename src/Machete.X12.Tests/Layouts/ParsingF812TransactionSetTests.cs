namespace Machete.X12.Tests.Layouts
{
    using System;
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class ParsingF812TransactionSetTests :
        X12MacheteTestHarness<X12v5010, X12Entity>
    {
        [Test]
        public void Test()
        {
            string message =
                @"ISA*01*0000000000*01*0000000000*ZZ*ABCDEFGHIJKLMNO*ZZ*123456789012345*101127*1719*U*00400*000003438*0*P*>
GS*CD*1234567890 *999999999 *20120126*1211*1*T*004010
ST*812*0001
BCD*20120227*Credit/Debit Adjustmen*A*1800515*C*20120227*D8778ND*O892B4*20120227*VY32I9833B829*00*01*01*Reference Identification*1
CUR*01*CUR*24602*01*CUR*IMF*001*20120227*1243040*001*20120227*124304*001*20120227*1243040*001*20120227*12430400*001*20120227*12430400
N9*01*Reference Identification*Free-form Description*20120227*1243*01*01Reference Identification1Reference Identification1Reference Identification
PER*1A*Name*AA*Communication Number*AA*Communication Number*AA*Communication Number*Contact Inquiry Refe
ITD*01*1*23*20120227*209*20120227*1*238003146*20120227*1*6094*Description*19*1*29
DTM*001*20120227*1243*01*CC*Date Time Period
FOB*11*A*Description*01*CAF*A*Description*BY*Description
SHD*17*1013*01*199*01*4*01*17233239*Pri*6*STAN*AA*01*Reference Identification
SAC*A*A010*10*Agency Ser*1616129*1*25912*77*01*2167163517371*27*01*Reference Identification*Option Number*Description*LAN
N1*01*Name*1*Identification Code*01*01
N2*Name*Name
N3*Address Information*Address Information
N4*City Name*ST*POSTAL CODE*COU*A*Location Identifier
N9*01*Reference Identification*Free-form Description*20120227*12430500*01*01Reference Identification1Reference Identification1Reference Identification
PER*1A*Name*AA*Communication Number*AA*Communication Number*AA*Communication Number*Contact Inquiry Refe
AMT*1*327589079309141098*C
AMT*1*167592389827218*C
AMT*1*754894*C
AMT*1*266342117825427*C
AMT*1*14369261*C
AMT*1*8686379104*C
AMT*1*963738532*C
LM*10*Source Subquali
LQ*0*Industry Code
FA1*10*A010*A
FA2*01*Financial Information Code
CDD*01*C*Assigned Identificat*1979324906*N*Pri*294*01*22849145302749*ACT*197133256*ACT*236491739524783
LIN*Assigned Identificat*A1*Product/Service ID*A1*Product/Service ID*A1*Product/Service ID*A1*Product/Service ID*A1*Product/Service ID*A1*Product/Service ID*A1*Product/Service ID*A1*Product/Service ID*A1*Product/Service ID*A1*Product/Service ID*A1*Product/Service ID*A1*Product/Service ID*A1*Product/Service ID*A1*Product/Service ID*A1*Product/Service ID
PO4*32*3134531*01*AMM01*A*32*01*255*01*224*4*189812*01*12542*1S*Assigned Identificat*Assigned Identificat*15285261
SAC*A*A010*10*Agency Ser*31786*1*761*7*01*1511970252*1109170431*01*Reference Identification*Option Number*Description*LAN
N9*01*Reference Identification*Free-form Description*20120227*1243*01*01Reference Identification1Reference Identification1Reference Identification
DTM*001*20120227*1243*01*CC*Date Time Period
LM*10*Source Subquali
LQ*0*Industry Code
N11*Store Numb*Location Identifier*Reference Identification
AMT*1*2209018*C
PCT*1*138
N1*01*Name*1*Identification Code*01*01
AMT*1*268044699774370352*C
PCT*1*22
SE*42*0001
GE*1*1
IEA*1*000000025";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<F812, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var invoiceNumber = queryResult
                .Select(x => x.Transactions)[0]
                .Select(x => x.BeginningCreditOrDebitAdjustment)
                .Select(x => x.InvoiceNumber)
                .ValueOrDefault();

            var purchaseOrderNumber = queryResult
                .Select(x => x.Transactions)[0]
                .Select(x => x.BeginningCreditOrDebitAdjustment)
                .Select(x => x.PurchaseOrderNumber)
                .ValueOrDefault();

            var vendorOrderNumber = queryResult
                .Select(x => x.Transactions)[0]
                .Select(x => x.BeginningCreditOrDebitAdjustment)
                .Select(x => x.VendorOrderNumber)
                .ValueOrDefault();

            var date = queryResult
                .Select(x => x.Transactions)[0]
                .Select(x => x.BeginningCreditOrDebitAdjustment)
                .Select(x => x.Date1)
                .ValueOrDefault();

            var time = queryResult
                .Select(x => x.Transactions)[0]
                .Select(x => x.ReferenceIdentification)[0]
                .Select(x => x.Time)
                .ValueOrDefault();
            
            Assert.AreEqual(new DateTime(2012, 2, 27), date);
            Assert.AreEqual("VY32I9833B829", purchaseOrderNumber);
            Assert.AreEqual("O892B4", vendorOrderNumber);
            Assert.AreEqual("D8778ND", invoiceNumber);
            Assert.AreEqual(new TimeSpan(12, 43, 0), time);
        }
    }
}