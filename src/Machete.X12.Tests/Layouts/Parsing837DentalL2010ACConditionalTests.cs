namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing837DentalL2010ACConditionalTests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test(Description = "Condition : SecondaryIdentification => 2U, TaxIdNumber => EI")]
        public void Test1()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*837*0002*005010X224A3
BHT*0019*00*0123*20061123*1023*CH
NM1*41*2*PREMIER BILLING SERVICE*****46*567890
PER*IC*JERRY*TE*7176149999
NM1*40*2*KEY INSURANCE COMPANY*****46*999996666
HL*1**20*1
NM1*85*2*DENTAL ASSOCIATES*****XX*4567890123
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*SY*587654321
REF*1G*587654321
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*2U*587654321
REF*EI*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
CLM*26403774*200***11:B:1*Y**Y*I
DTP*472*D8*20061109
REF*D9*111222333444
NM1*82*1*KILDARE*BEN****XX*6789012345
PRV*PE*PXC*1223P0221X
LX*1
SV3*AD:D3320*200****1
TOO*JP*5
SE*29*0002
IEA*1*176073292";
 
            var entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837D, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.BillingProviderDetail)[0]
                .Select(x => x.PayToPlan)
                .Select(x => x.SecondaryIdentification)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("2U", secondaryIdentification.ValueOrDefault());

            var taxIdNumber = transactions
                .Select(x => x.BillingProviderDetail)[0]
                .Select(x => x.PayToPlan)
                .Select(x => x.TaxIdNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(taxIdNumber != null);
            Assert.IsTrue(taxIdNumber.HasValue);
            Assert.IsTrue(taxIdNumber.IsPresent);
            Assert.AreEqual("EI", taxIdNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : SecondaryIdentification => FY, TaxIdNumber => EI")]
        public void Test2()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*837*0002*005010X224A3
BHT*0019*00*0123*20061123*1023*CH
NM1*41*2*PREMIER BILLING SERVICE*****46*567890
PER*IC*JERRY*TE*7176149999
NM1*40*2*KEY INSURANCE COMPANY*****46*999996666
HL*1**20*1
NM1*85*2*DENTAL ASSOCIATES*****XX*4567890123
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*SY*587654321
REF*1G*587654321
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*FY*587654321
REF*EI*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
CLM*26403774*200***11:B:1*Y**Y*I
DTP*472*D8*20061109
REF*D9*111222333444
NM1*82*1*KILDARE*BEN****XX*6789012345
PRV*PE*PXC*1223P0221X
LX*1
SV3*AD:D3320*200****1
TOO*JP*5
SE*29*0002
IEA*1*176073292";
 
            var entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837D, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.BillingProviderDetail)[0]
                .Select(x => x.PayToPlan)
                .Select(x => x.SecondaryIdentification)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("FY", secondaryIdentification.ValueOrDefault());

            var taxIdNumber = transactions
                .Select(x => x.BillingProviderDetail)[0]
                .Select(x => x.PayToPlan)
                .Select(x => x.TaxIdNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(taxIdNumber != null);
            Assert.IsTrue(taxIdNumber.HasValue);
            Assert.IsTrue(taxIdNumber.IsPresent);
            Assert.AreEqual("EI", taxIdNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : SecondaryIdentification => NF, TaxIdNumber => EI")]
        public void Test3()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*837*0002*005010X224A3
BHT*0019*00*0123*20061123*1023*CH
NM1*41*2*PREMIER BILLING SERVICE*****46*567890
PER*IC*JERRY*TE*7176149999
NM1*40*2*KEY INSURANCE COMPANY*****46*999996666
HL*1**20*1
NM1*85*2*DENTAL ASSOCIATES*****XX*4567890123
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*SY*587654321
REF*1G*587654321
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*NF*587654321
REF*EI*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
CLM*26403774*200***11:B:1*Y**Y*I
DTP*472*D8*20061109
REF*D9*111222333444
NM1*82*1*KILDARE*BEN****XX*6789012345
PRV*PE*PXC*1223P0221X
LX*1
SV3*AD:D3320*200****1
TOO*JP*5
SE*29*0002
IEA*1*176073292";
 
            var entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837D, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.BillingProviderDetail)[0]
                .Select(x => x.PayToPlan)
                .Select(x => x.SecondaryIdentification)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("NF", secondaryIdentification.ValueOrDefault());

            var taxIdNumber = transactions
                .Select(x => x.BillingProviderDetail)[0]
                .Select(x => x.PayToPlan)
                .Select(x => x.TaxIdNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(taxIdNumber != null);
            Assert.IsTrue(taxIdNumber.HasValue);
            Assert.IsTrue(taxIdNumber.IsPresent);
            Assert.AreEqual("EI", taxIdNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : SecondaryIdentification => missing, TaxIdNumber => EI")]
        public void Test4()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*837*0002*005010X224A3
BHT*0019*00*0123*20061123*1023*CH
NM1*41*2*PREMIER BILLING SERVICE*****46*567890
PER*IC*JERRY*TE*7176149999
NM1*40*2*KEY INSURANCE COMPANY*****46*999996666
HL*1**20*1
NM1*85*2*DENTAL ASSOCIATES*****XX*4567890123
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*SY*587654321
REF*1G*587654321
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*EI*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
CLM*26403774*200***11:B:1*Y**Y*I
DTP*472*D8*20061109
REF*D9*111222333444
NM1*82*1*KILDARE*BEN****XX*6789012345
PRV*PE*PXC*1223P0221X
LX*1
SV3*AD:D3320*200****1
TOO*JP*5
SE*29*0002
IEA*1*176073292";
 
            var entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837D, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.BillingProviderDetail)[0]
                .Select(x => x.PayToPlan)
                .Select(x => x.SecondaryIdentification)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsFalse(secondaryIdentification.HasValue);
            Assert.IsFalse(secondaryIdentification.IsPresent);

            var taxIdNumber = transactions
                .Select(x => x.BillingProviderDetail)[0]
                .Select(x => x.PayToPlan)
                .Select(x => x.TaxIdNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(taxIdNumber != null);
            Assert.IsTrue(taxIdNumber.HasValue);
            Assert.IsTrue(taxIdNumber.IsPresent);
            Assert.AreEqual("EI", taxIdNumber.ValueOrDefault());
        }
    }
}