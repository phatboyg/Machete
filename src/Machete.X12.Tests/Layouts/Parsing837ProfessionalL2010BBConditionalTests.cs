namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing837ProfessionalL2010BBConditionalTests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test(Description = "Condition : SecondaryIdentification => 2U, BillingProviderSecondaryIdentification => G2"), Explicit("Issue #65")]
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
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
REF*Y4*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*2U*587654321
REF*G2*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("2U", secondaryIdentification.ValueOrDefault());

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsTrue(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsTrue(propertyAndCasualtyClaimNumber.IsPresent);
            Assert.AreEqual("G2", propertyAndCasualtyClaimNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : SecondaryIdentification => 2U, BillingProviderSecondaryIdentification => LU"), Explicit("Issue #65")]
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
REF*2U*587654321
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
REF*Y4*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*2U*587654321
REF*LU*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("2U", secondaryIdentification.ValueOrDefault());

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsTrue(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsTrue(propertyAndCasualtyClaimNumber.IsPresent);
            Assert.AreEqual("LU", propertyAndCasualtyClaimNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : SecondaryIdentification => 2U, BillingProviderSecondaryIdentification => missing")]
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
REF*2U*587654321
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*2U*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("2U", secondaryIdentification.ValueOrDefault());

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
        }
        
        [Test(Description = "Condition : SecondaryIdentification => [2U], BillingProviderSecondaryIdentification => missing")]
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
REF*2U*587654321
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*2U*587654321
REF*2U*587654321
REF*2U*587654321
REF*2U*587654321
REF*2U*587654321
REF*2U*587654321
REF*2U*587654321
REF*2U*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            for (int i = 0;; i++)
            {
                if (!transactions.Select(x => x.SubscriberDetail)[0].Select(x => x.PayerName).Select(x => x.SecondaryIdentification).TryGetValue(i, out Segment<REF> segment))
                    break;

                var secondaryIdentification = segment.Select(x => x.ReferenceIdentificationQualifier);

                Assume.That(secondaryIdentification != null);
                Assert.IsTrue(secondaryIdentification.HasValue);
                Assert.IsTrue(secondaryIdentification.IsPresent);
                Assert.AreEqual("2U", secondaryIdentification.ValueOrDefault());
            }

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
        }
        
        [Test(Description = "Condition : SecondaryIdentification => missing, BillingProviderSecondaryIdentification => G2"), Explicit("Issue #65")]
        public void Test5()
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
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*G2*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

//            var secondaryIdentification = transactions
//                .Select(x => x.SubscriberDetail)[0]
//                .Select(x => x.PayerName)
//                .Select(x => x.SecondaryIdentification)[0]
//                .Select(x => x.ReferenceIdentificationQualifier);
//            
//            Assume.That(secondaryIdentification != null);
//            Assert.IsFalse(secondaryIdentification.HasValue);
//            Assert.IsFalse(secondaryIdentification.IsPresent);

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsTrue(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsTrue(propertyAndCasualtyClaimNumber.IsPresent);
            Assert.AreEqual("G2", propertyAndCasualtyClaimNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : SecondaryIdentification => missing, BillingProviderSecondaryIdentification => missing")]
        public void Test6()
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
REF*EIB*587654321
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
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsFalse(secondaryIdentification.HasValue);
            Assert.IsFalse(secondaryIdentification.IsPresent);

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
        }
        
        [Test(Description = "Condition : SecondaryIdentification => 2U, BillingProviderSecondaryIdentification => LU"), Explicit("Issue #65")]
        public void Test7()
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
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
REF*Y4*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*2U*587654321
REF*LU*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("2U", secondaryIdentification.ValueOrDefault());

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsTrue(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsTrue(propertyAndCasualtyClaimNumber.IsPresent);
            Assert.AreEqual("LU", propertyAndCasualtyClaimNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : SecondaryIdentification => missing, BillingProviderSecondaryIdentification => LU"), Explicit("Issue #65")]
        public void Test8()
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
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*Y4*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*LU*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsFalse(secondaryIdentification.HasValue);
            Assert.IsFalse(secondaryIdentification.IsPresent);

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsTrue(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsTrue(propertyAndCasualtyClaimNumber.IsPresent);
            Assert.AreEqual("LU", propertyAndCasualtyClaimNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : SecondaryIdentification => EI, BillingProviderSecondaryIdentification => missing")]
        public void Test9()
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
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*EI*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("EI", secondaryIdentification.ValueOrDefault());

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
        }
        
        [Test(Description = "Condition : SecondaryIdentification => [EI], BillingProviderSecondaryIdentification => missing")]
        public void Test10()
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
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*EI*587654321
REF*EI*587654321
REF*EI*587654321
REF*EI*587654321
REF*EI*587654321
REF*EI*587654321
REF*EI*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            for (int i = 0;; i++)
            {
                if (!transactions.Select(x => x.SubscriberDetail)[0].Select(x => x.PayerName).Select(x => x.SecondaryIdentification).TryGetValue(i, out Segment<REF> segment))
                    break;

                var secondaryIdentification = segment.Select(x => x.ReferenceIdentificationQualifier);

                Assume.That(secondaryIdentification != null);
                Assert.IsTrue(secondaryIdentification.HasValue);
                Assert.IsTrue(secondaryIdentification.IsPresent);
                Assert.AreEqual("EI", secondaryIdentification.ValueOrDefault());
            }

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
        }
        
        [Test(Description = "Condition : SecondaryIdentification => EI, BillingProviderSecondaryIdentification => G2"), Explicit("Issue #65")]
        public void Test11()
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
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*EI*587654321
REF*G2*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("EI", secondaryIdentification.ValueOrDefault());

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
            Assert.AreEqual("G2", propertyAndCasualtyClaimNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : SecondaryIdentification => EI, BillingProviderSecondaryIdentification => LU"), Explicit("Issue #65")]
        public void Test12()
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
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*EI*587654321
REF*LU*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("EI", secondaryIdentification.ValueOrDefault());

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
            Assert.AreEqual("LU", propertyAndCasualtyClaimNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : SecondaryIdentification => FY, BillingProviderSecondaryIdentification => missing")]
        public void Test13()
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
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*FY*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("FY", secondaryIdentification.ValueOrDefault());

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
        }
        
        [Test(Description = "Condition : SecondaryIdentification => [FY], BillingProviderSecondaryIdentification => missing")]
        public void Test14()
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
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*FY*587654321
REF*FY*587654321
REF*FY*587654321
REF*FY*587654321
REF*FY*587654321
REF*FY*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            for (int i = 0;; i++)
            {
                if (!transactions.Select(x => x.SubscriberDetail)[0].Select(x => x.PayerName).Select(x => x.SecondaryIdentification).TryGetValue(i, out Segment<REF> segment))
                    break;

                var secondaryIdentification = segment.Select(x => x.ReferenceIdentificationQualifier);

                Assume.That(secondaryIdentification != null);
                Assert.IsTrue(secondaryIdentification.HasValue);
                Assert.IsTrue(secondaryIdentification.IsPresent);
                Assert.AreEqual("FY", secondaryIdentification.ValueOrDefault());
            }

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
        }
        
        [Test(Description = "Condition : SecondaryIdentification => FY, BillingProviderSecondaryIdentification => G2"), Explicit("Issue #65")]
        public void Test15()
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
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*FY*587654321
REF*G2*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("FY", secondaryIdentification.ValueOrDefault());

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
            Assert.AreEqual("G2", propertyAndCasualtyClaimNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : SecondaryIdentification => FY, BillingProviderSecondaryIdentification => LU"), Explicit("Issue #65")]
        public void Test16()
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
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*FY*587654321
REF*LU*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("FY", secondaryIdentification.ValueOrDefault());

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
            Assert.AreEqual("LU", propertyAndCasualtyClaimNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : SecondaryIdentification => NF, BillingProviderSecondaryIdentification => missing")]
        public void Test17()
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
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*NF*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("NF", secondaryIdentification.ValueOrDefault());

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
        }
        
        [Test(Description = "Condition : SecondaryIdentification => [NF], BillingProviderSecondaryIdentification => missing")]
        public void Test18()
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
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*NF*587654321
REF*NF*587654321
REF*NF*587654321
REF*NF*587654321
REF*NF*587654321
REF*NF*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            for (int i = 0;; i++)
            {
                if (!transactions.Select(x => x.SubscriberDetail)[0].Select(x => x.PayerName).Select(x => x.SecondaryIdentification).TryGetValue(i, out Segment<REF> segment))
                    break;

                var secondaryIdentification = segment.Select(x => x.ReferenceIdentificationQualifier);

                Assume.That(secondaryIdentification != null);
                Assert.IsTrue(secondaryIdentification.HasValue);
                Assert.IsTrue(secondaryIdentification.IsPresent);
                Assert.AreEqual("NF", secondaryIdentification.ValueOrDefault());
            }

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
        }
        
        [Test(Description = "Condition : SecondaryIdentification => NF, BillingProviderSecondaryIdentification => G2"), Explicit("Issue #65")]
        public void Test19()
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
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*NF*587654321
REF*G2*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("NF", secondaryIdentification.ValueOrDefault());

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
            Assert.AreEqual("G2", propertyAndCasualtyClaimNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : SecondaryIdentification => NF, BillingProviderSecondaryIdentification => LU"), Explicit("Issue #65")]
        public void Test20()
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
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*NF*587654321
REF*LU*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
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

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("NF", secondaryIdentification.ValueOrDefault());

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.PayerName)
                .Select(x => x.BillingProviderSecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
            Assert.AreEqual("LU", propertyAndCasualtyClaimNumber.ValueOrDefault());
        }
    }
}