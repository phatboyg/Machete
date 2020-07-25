namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing837ProfessionalL2300P14ConditionalTests :
        X12MacheteTestHarness<X12v5010, X12Entity>
    {
        [Test(Description = @"Condition : L2330A => present,
            L2330B => present,
            L2330C => present,
            L2330D => present,
            L2330E => present,
            L2330F => present,
            L2330G => present")]
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
DTP*431*D8*20061109
REF*G1*111222333444
HI✽ABK:8901✽BF:87200✽BF:5559
HI✽BP:8901✽BF:87200✽BF:5559
HI✽BG:8901✽BF:87200✽BF:5559
NM1*77*2*KILDARE ASSOCIATES*****XX*1581234567
N3*2345 OCEAN BLVD
N4*MI
NM1*45*2*KILDARE ASSOCIATES*****XX*1581234567
N3*2345 OCEAN BLVD
N4*MI
SBR*S*01*******CI
AMT*D*411
AMT*A8*273
AMT*EAF*75
OI***Y*P**Y
NM1*IL*1*SMITH*JACK****MI*T55TY666
N3*236 N MAIN ST
N4*MIAMI*FL*33111
REF*SY*R555588
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*2U*98765
NM1*DN*1*KILDARE*BEN****XX*6789012345
REF*0B*R555588
NM1*82*1*KILDARE*BEN****XX*6789012345
REF*0B*R555588
NM1*77*1*KILDARE*BEN****XX*6789012345
REF*0B*R555588
NM1*DQ*1*KILDARE*BEN****XX*6789012345
REF*0B*R555588
NM1*85*1*KILDARE*BEN****XX*6789012345
REF*G2*R555588
PRV*PE*PXC*1223P0221X
LX*1
SV3*AD:D3320*200****1
TOO*JP*5
SE*29*0002
IEA*1*176073292";

            var entityResult = Parser.Parse(message);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

                var query = entityResult.CreateQuery(layout);

                var queryResult = entityResult.Query(query);

                Assert.IsNotNull(queryResult);
                Assert.IsTrue(queryResult.HasResult);

                var transactions = queryResult.Select(x => x.Transaction)[0];

                Assert.IsNotNull(transactions, "Transaction");
                Assert.IsTrue(transactions.HasValue, "Transaction");

                // L2330A
                var otherSubscriberName = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330A);

                var subscribingProvider = otherSubscriberName
                    .Select(x => x.OtherSubscriber)
                    .Select(x => x.EntityIdentifierCode);

                var subscriberProviderSecondaryIdentification = otherSubscriberName
                    .Select(x => x.SecondaryIdentification)
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherSubscriberName, "L2330A");
                Assert.IsNotNull(subscribingProvider, "L2330A - NM1");
                Assert.IsNotNull(subscriberProviderSecondaryIdentification, "L2330A - REF");
                Assert.IsTrue(otherSubscriberName.HasValue);
                Assert.IsTrue(subscribingProvider.HasValue);
                Assert.IsTrue(subscriberProviderSecondaryIdentification.HasValue);
                Assert.IsTrue(subscribingProvider.IsPresent);
                Assert.IsTrue(subscriberProviderSecondaryIdentification.IsPresent);
                Assert.AreEqual("IL", subscribingProvider.ValueOrDefault());
                Assert.AreEqual("SY", subscriberProviderSecondaryIdentification.ValueOrDefault());

                // L2330B
                var otherPayerName = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330B);

                var payer = otherPayerName
                    .Select(x => x.OtherPayer)
                    .Select(x => x.EntityIdentifierCode);

                var payerSecondaryIdentification = otherPayerName
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerName, "L2330B");
                Assert.IsNotNull(payer, "L2330B - NM1");
                Assert.IsNotNull(payerSecondaryIdentification, "L2330B - REF");
                Assert.IsTrue(otherPayerName.HasValue);
                Assert.IsTrue(payer.HasValue);
                Assert.IsTrue(payerSecondaryIdentification.HasValue);
                Assert.IsTrue(payer.IsPresent);
                Assert.IsTrue(payerSecondaryIdentification.IsPresent);
                Assert.AreEqual("PR", payer.ValueOrDefault());
                Assert.AreEqual("2U", payerSecondaryIdentification.ValueOrDefault());

                // L2330C
                var otherPayerReferringProvider = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330C)[0];

                var referringProvider = otherPayerReferringProvider
                    .Select(x => x.OtherPayerReferringProvider)
                    .Select(x => x.EntityIdentifierCode);

                var referringProviderSecondaryIdentification = otherPayerReferringProvider
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerReferringProvider, "L2330C");
                Assert.IsNotNull(referringProvider, "L2330C - NM1");
                Assert.IsNotNull(referringProviderSecondaryIdentification, "L2330C - REF");
                Assert.IsTrue(otherPayerReferringProvider.HasValue);
                Assert.IsTrue(referringProvider.HasValue);
                Assert.IsTrue(referringProviderSecondaryIdentification.HasValue);
                Assert.IsTrue(referringProvider.IsPresent);
                Assert.IsTrue(referringProviderSecondaryIdentification.IsPresent);
                Assert.AreEqual("DN", referringProvider.ValueOrDefault());
                Assert.AreEqual("0B", referringProviderSecondaryIdentification.ValueOrDefault());

                // L2330D
                var otherPayerRenderingProvider = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330D);

                var payerRenderingProvider = otherPayerRenderingProvider
                    .Select(x => x.OtherPayerRenderingProvider)
                    .Select(x => x.EntityIdentifierCode);

                var payerRenderingProviderSecondaryIdentification = otherPayerRenderingProvider
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerRenderingProvider, "L2330D");
                Assert.IsNotNull(payerRenderingProvider, "L2330D - NM1");
                Assert.IsNotNull(payerRenderingProviderSecondaryIdentification, "L2330D - REF");
                Assert.IsTrue(otherPayerRenderingProvider.HasValue);
                Assert.IsTrue(payerRenderingProvider.HasValue);
                Assert.IsTrue(payerRenderingProviderSecondaryIdentification.HasValue);
                Assert.IsTrue(payerRenderingProvider.IsPresent);
                Assert.IsTrue(payerRenderingProviderSecondaryIdentification.IsPresent);
                Assert.AreEqual("82", payerRenderingProvider.ValueOrDefault());
                Assert.AreEqual("0B", payerRenderingProviderSecondaryIdentification.ValueOrDefault());

                // L2330E
                var otherPayerServiceFacilityLocation = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330E);

                var facilityLocation = otherPayerServiceFacilityLocation
                    .Select(x => x.OtherPayerServiceFacilityLocation)
                    .Select(x => x.EntityIdentifierCode);

                var payerServiceFacilityLocationSecondaryIdentification = otherPayerServiceFacilityLocation
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerServiceFacilityLocation, "L2330E");
                Assert.IsNotNull(facilityLocation, "L2330E - NM1");
                Assert.IsNotNull(payerServiceFacilityLocationSecondaryIdentification, "L2330E - REF");
                Assert.IsTrue(otherPayerServiceFacilityLocation.HasValue);
                Assert.IsTrue(facilityLocation.HasValue);
                Assert.IsTrue(payerServiceFacilityLocationSecondaryIdentification.HasValue);
                Assert.IsTrue(facilityLocation.IsPresent);
                Assert.IsTrue(payerServiceFacilityLocationSecondaryIdentification.IsPresent);
                Assert.AreEqual("77", facilityLocation.ValueOrDefault());
                Assert.AreEqual("0B", payerServiceFacilityLocationSecondaryIdentification.ValueOrDefault());

                // L2330F
                var otherPayerSupervisingProvider = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330F);

                var payerSupervisingProvider = otherPayerSupervisingProvider
                    .Select(x => x.OtherPayerSupervisingProvider)
                    .Select(x => x.EntityIdentifierCode);

                var payerSupervisingProviderSecondaryIdentification = otherPayerSupervisingProvider
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerSupervisingProvider, "L2330F");
                Assert.IsNotNull(payerSupervisingProvider, "L2330F - NM1");
                Assert.IsNotNull(payerSupervisingProviderSecondaryIdentification, "L2330F - REF");
                Assert.IsTrue(otherPayerSupervisingProvider.HasValue);
                Assert.IsTrue(payerSupervisingProvider.HasValue);
                Assert.IsTrue(payerSupervisingProviderSecondaryIdentification.HasValue);
                Assert.IsTrue(payerSupervisingProvider.IsPresent);
                Assert.IsTrue(payerSupervisingProviderSecondaryIdentification.IsPresent);
                Assert.AreEqual("DQ", payerSupervisingProvider.ValueOrDefault());
                Assert.AreEqual("0B", payerSupervisingProviderSecondaryIdentification.ValueOrDefault());

                // L2330G
                var otherPayerBillingProvider = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330G);

                var payerBillingProvider = otherPayerBillingProvider
                    .Select(x => x.OtherPayerBillingProvider)
                    .Select(x => x.EntityIdentifierCode);

                var otherPayerBillingProviderSecondaryIdentification = otherPayerBillingProvider
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerBillingProvider, "L2330G");
                Assert.IsNotNull(payerBillingProvider, "L2330G - NM1");
                Assert.IsNotNull(otherPayerBillingProviderSecondaryIdentification, "L2330G - REF");
                Assert.IsTrue(otherPayerBillingProvider.HasValue);
                Assert.IsTrue(payerBillingProvider.HasValue);
                Assert.IsTrue(otherPayerBillingProviderSecondaryIdentification.HasValue);
                Assert.IsTrue(payerBillingProvider.IsPresent);
                Assert.IsTrue(otherPayerBillingProviderSecondaryIdentification.IsPresent);
                Assert.AreEqual("85", payerBillingProvider.ValueOrDefault());
                Assert.AreEqual("G2", otherPayerBillingProviderSecondaryIdentification.ValueOrDefault());
            });
        }

        [Test(Description = @"Condition : L2330A => present,
            L2330B => missing,
            L2330C => missing,
            L2330D => missing,
            L2330E => missing,
            L2330F => missing,
            L2330G => present")]
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
DTP*431*D8*20061109
REF*G1*111222333444
HI✽ABK:8901✽BF:87200✽BF:5559
HI✽BP:8901✽BF:87200✽BF:5559
HI✽BG:8901✽BF:87200✽BF:5559
NM1*77*2*KILDARE ASSOCIATES*****XX*1581234567
N3*2345 OCEAN BLVD
N4*MI
NM1*45*2*KILDARE ASSOCIATES*****XX*1581234567
N3*2345 OCEAN BLVD
N4*MI
SBR*S*01*******CI
AMT*D*411
AMT*A8*273
AMT*EAF*75
OI***Y*P**Y
NM1*IL*1*SMITH*JACK****MI*T55TY666
N3*236 N MAIN ST
N4*MIAMI*FL*33111
REF*SY*R555588
NM1*85*1*SMITH*JACK****MI*T55TY666
REF*G2*R555588
LX*1
SV3*AD:D3320*200****1
TOO*JP*5
SE*29*0002
IEA*1*176073292";

            var entityResult = Parser.Parse(message);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

                var query = entityResult.CreateQuery(layout);

                var queryResult = entityResult.Query(query);

                Assert.IsNotNull(queryResult);
                Assert.IsTrue(queryResult.HasResult);

                var transactions = queryResult.Select(x => x.Transaction)[0];

                Assert.IsNotNull(transactions, "Transaction");
                Assert.IsTrue(transactions.HasValue, "Transaction");

                // L2330A
                var otherSubscriberName = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330A);

                var subscribingProvider = otherSubscriberName
                    .Select(x => x.OtherSubscriber)
                    .Select(x => x.EntityIdentifierCode);

                var subscriberProviderSecondaryIdentification = otherSubscriberName
                    .Select(x => x.SecondaryIdentification)
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherSubscriberName);
                Assert.IsNotNull(subscribingProvider);
                Assert.IsNotNull(subscriberProviderSecondaryIdentification);
                Assert.AreEqual("IL", subscribingProvider.ValueOrDefault());
                Assert.IsTrue(otherSubscriberName.HasValue);
                Assert.IsTrue(subscribingProvider.HasValue);
                Assert.IsTrue(subscriberProviderSecondaryIdentification.HasValue);
                Assert.IsTrue(subscribingProvider.IsPresent);
                Assert.IsTrue(subscriberProviderSecondaryIdentification.IsPresent);
                Assert.AreEqual("SY", subscriberProviderSecondaryIdentification.ValueOrDefault());

                // L2330B
                var otherPayerName = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330B);

                var payer = otherPayerName
                    .Select(x => x.OtherPayer)
                    .Select(x => x.EntityIdentifierCode);

                var payerSecondaryIdentification = otherPayerName
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerName);
                Assert.IsNotNull(payer);
                Assert.IsNotNull(payerSecondaryIdentification);
                Assert.IsTrue(otherPayerName.HasValue);
                Assert.IsFalse(payer.HasValue);
                Assert.IsFalse(payerSecondaryIdentification.HasValue);
                Assert.IsFalse(payer.IsPresent);
                Assert.IsFalse(payerSecondaryIdentification.IsPresent);

                // L2330C
                var otherPayerReferringProvider = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330C);

                var referringProvider = otherPayerReferringProvider[0]
                    .Select(x => x.OtherPayerReferringProvider)
                    .Select(x => x.EntityIdentifierCode);

                var referringProviderSecondaryIdentification = otherPayerReferringProvider[0]
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerReferringProvider);
                Assert.IsNotNull(referringProvider);
                Assert.IsNotNull(referringProviderSecondaryIdentification);
                Assert.IsTrue(otherPayerReferringProvider.HasValue);
                Assert.IsFalse(referringProvider.HasValue);
                Assert.IsFalse(referringProviderSecondaryIdentification.HasValue);
                Assert.IsFalse(referringProvider.IsPresent);
                Assert.IsFalse(referringProviderSecondaryIdentification.IsPresent);

                // L2330D
                var otherPayerRenderingProvider = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330D);

                var payerRenderingProvider = otherPayerRenderingProvider
                    .Select(x => x.OtherPayerRenderingProvider)
                    .Select(x => x.EntityIdentifierCode);

                var payerRenderingProviderSecondaryIdentification = otherPayerRenderingProvider
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerRenderingProvider);
                Assert.IsNotNull(payerRenderingProvider);
                Assert.IsNotNull(payerRenderingProviderSecondaryIdentification);
                Assert.IsTrue(otherPayerRenderingProvider.HasValue);
                Assert.IsFalse(payerRenderingProvider.HasValue);
                Assert.IsFalse(payerRenderingProviderSecondaryIdentification.HasValue);
                Assert.IsFalse(payerRenderingProvider.IsPresent);
                Assert.IsFalse(payerRenderingProviderSecondaryIdentification.IsPresent);

                // L2330E
                var otherPayerServiceFacilityLocation = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330E);

                var facilityLocation = otherPayerServiceFacilityLocation
                    .Select(x => x.OtherPayerServiceFacilityLocation)
                    .Select(x => x.EntityIdentifierCode);

                var payerServiceFacilityLocationSecondaryIdentification = otherPayerServiceFacilityLocation
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerServiceFacilityLocation);
                Assert.IsNotNull(facilityLocation);
                Assert.IsNotNull(payerServiceFacilityLocationSecondaryIdentification);
                Assert.IsTrue(otherPayerServiceFacilityLocation.HasValue);
                Assert.IsFalse(facilityLocation.HasValue);
                Assert.IsFalse(payerServiceFacilityLocationSecondaryIdentification.HasValue);
                Assert.IsFalse(facilityLocation.IsPresent);
                Assert.IsFalse(payerServiceFacilityLocationSecondaryIdentification.IsPresent);

                // L2330F
                var otherPayerSupervisingProvider = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330F);

                var payerSupervisingProvider = otherPayerSupervisingProvider
                    .Select(x => x.OtherPayerSupervisingProvider)
                    .Select(x => x.EntityIdentifierCode);

                var payerSupervisingProviderSecondaryIdentification = otherPayerSupervisingProvider
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerSupervisingProvider);
                Assert.IsNotNull(payerSupervisingProvider);
                Assert.IsNotNull(payerSupervisingProviderSecondaryIdentification);
                Assert.IsTrue(otherPayerSupervisingProvider.HasValue);
                Assert.IsFalse(payerSupervisingProvider.HasValue);
                Assert.IsFalse(payerSupervisingProviderSecondaryIdentification.HasValue);
                Assert.IsFalse(payerSupervisingProvider.IsPresent);
                Assert.IsFalse(payerSupervisingProviderSecondaryIdentification.IsPresent);

                // L2330G
                var otherPayerBillingProvider = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330G);

                var payerBillingProvider = otherPayerBillingProvider
                    .Select(x => x.OtherPayerBillingProvider)
                    .Select(x => x.EntityIdentifierCode);

                var otherPayerBillingProviderSecondaryIdentification = otherPayerBillingProvider
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerBillingProvider);
                Assert.IsNotNull(payerBillingProvider);
                Assert.IsNotNull(otherPayerBillingProviderSecondaryIdentification);
                Assert.IsTrue(otherPayerBillingProvider.HasValue);
                Assert.IsTrue(payerBillingProvider.HasValue);
                Assert.IsTrue(otherPayerBillingProviderSecondaryIdentification.HasValue);
                Assert.IsTrue(payerBillingProvider.IsPresent);
                Assert.IsTrue(otherPayerBillingProviderSecondaryIdentification.IsPresent);
                Assert.AreEqual("85", payerBillingProvider.ValueOrDefault());
                Assert.AreEqual("G2", otherPayerBillingProviderSecondaryIdentification.ValueOrDefault());
            });
        }

        [Test(Description = @"Condition : L2330A => missing,
            L2330B => missing,
            L2330C => missing,
            L2330D => missing,
            L2330E => missing,
            L2330F => missing,
            L2330G => missing")]
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
DTP*431*D8*20061109
REF*G1*111222333444
HI✽ABK:8901✽BF:87200✽BF:5559
HI✽BP:8901✽BF:87200✽BF:5559
HI✽BG:8901✽BF:87200✽BF:5559
NM1*77*2*KILDARE ASSOCIATES*****XX*1581234567
N3*2345 OCEAN BLVD
N4*MI
NM1*77*2*KILDARE ASSOCIATES*****XX*1581234567
N3*2345 OCEAN BLVD
N4*MI
SBR*S*01*******CI
AMT*D*411
AMT*A8*273
AMT*EAF*75
OI***Y*P**Y
PRV*PE*PXC*1223P0221X
LX*1
SV3*AD:D3320*200****1
TOO*JP*5
SE*29*0002
IEA*1*176073292";

            var entityResult = Parser.Parse(message);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

                var query = entityResult.CreateQuery(layout);

                var queryResult = entityResult.Query(query);

                Assert.IsNotNull(queryResult);
                Assert.IsTrue(queryResult.HasResult);

                var transactions = queryResult.Select(x => x.Transaction)[0];

                Assert.IsNotNull(transactions, "Transaction");
                Assert.IsTrue(transactions.HasValue, "Transaction");

                // L2330A
                var otherSubscriberName = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330A);

                var subscribingProvider = otherSubscriberName
                    .Select(x => x.OtherSubscriber)
                    .Select(x => x.EntityIdentifierCode);

                var subscriberProviderSecondaryIdentification = otherSubscriberName
                    .Select(x => x.SecondaryIdentification)
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherSubscriberName, "L2330A");
                Assert.IsNotNull(subscribingProvider, "L2330A - NM1");
                Assert.IsNotNull(subscriberProviderSecondaryIdentification, "L2330A - REF");
                Assert.IsTrue(otherSubscriberName.HasValue);
                Assert.IsFalse(subscribingProvider.HasValue);
                Assert.IsFalse(subscriberProviderSecondaryIdentification.HasValue);
                Assert.IsFalse(subscribingProvider.IsPresent);
                Assert.IsFalse(subscriberProviderSecondaryIdentification.IsPresent);

                // L2330B
                var otherPayerName = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330B);

                var payer = otherPayerName
                    .Select(x => x.OtherPayer)
                    .Select(x => x.EntityIdentifierCode);

                var payerSecondaryIdentification = otherPayerName
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerName, "L2330B");
                Assert.IsNotNull(payer, "L2330B - NM1");
                Assert.IsNotNull(payerSecondaryIdentification, "L2330B - REF");
                Assert.IsTrue(otherPayerName.HasValue);
                Assert.IsFalse(payer.HasValue);
                Assert.IsFalse(payerSecondaryIdentification.HasValue);
                Assert.IsFalse(payer.IsPresent);
                Assert.IsFalse(payerSecondaryIdentification.IsPresent);

                // L2330C
                var otherPayerReferringProvider = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330C)[0];

                var referringProvider = otherPayerReferringProvider
                    .Select(x => x.OtherPayerReferringProvider)
                    .Select(x => x.EntityIdentifierCode);

                var referringProviderSecondaryIdentification = otherPayerReferringProvider
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerReferringProvider, "L2330C");
                Assert.IsNotNull(referringProvider, "L2330C - NM1");
                Assert.IsNotNull(referringProviderSecondaryIdentification, "L2330C - REF");
                Assert.IsFalse(otherPayerReferringProvider.HasValue);
                Assert.IsFalse(referringProvider.HasValue);
                Assert.IsFalse(referringProviderSecondaryIdentification.HasValue);
                Assert.IsFalse(referringProvider.IsPresent);
                Assert.IsFalse(referringProviderSecondaryIdentification.IsPresent);

                // L2330D
                var otherPayerRenderingProvider = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330D);

                var payerRenderingProvider = otherPayerRenderingProvider
                    .Select(x => x.OtherPayerRenderingProvider)
                    .Select(x => x.EntityIdentifierCode);

                var payerRenderingProviderSecondaryIdentification = otherPayerRenderingProvider
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerRenderingProvider, "L2330D");
                Assert.IsNotNull(payerRenderingProvider, "L2330D - NM1");
                Assert.IsNotNull(payerRenderingProviderSecondaryIdentification, "L2330D - REF");
                Assert.IsTrue(otherPayerRenderingProvider.HasValue);
                Assert.IsFalse(payerRenderingProvider.HasValue);
                Assert.IsFalse(payerRenderingProviderSecondaryIdentification.HasValue);
                Assert.IsFalse(payerRenderingProvider.IsPresent);
                Assert.IsFalse(payerRenderingProviderSecondaryIdentification.IsPresent);

                // L2330E
                var otherPayerServiceFacilityLocation = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330E);

                var facilityLocation = otherPayerServiceFacilityLocation
                    .Select(x => x.OtherPayerServiceFacilityLocation)
                    .Select(x => x.EntityIdentifierCode);

                var payerServiceFacilityLocationSecondaryIdentification = otherPayerServiceFacilityLocation
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerServiceFacilityLocation, "L2330E");
                Assert.IsNotNull(facilityLocation, "L2330E - NM1");
                Assert.IsNotNull(payerServiceFacilityLocationSecondaryIdentification, "L2330E - REF");
                Assert.IsTrue(otherPayerServiceFacilityLocation.HasValue);
                Assert.IsTrue(facilityLocation.HasValue);
                Assert.IsFalse(payerServiceFacilityLocationSecondaryIdentification.HasValue);
                Assert.IsTrue(facilityLocation.IsPresent);
                Assert.IsFalse(payerServiceFacilityLocationSecondaryIdentification.IsPresent);

                // L2330F
                var otherPayerSupervisingProvider = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330F);

                var payerSupervisingProvider = otherPayerSupervisingProvider
                    .Select(x => x.OtherPayerSupervisingProvider)
                    .Select(x => x.EntityIdentifierCode);

                var payerSupervisingProviderSecondaryIdentification = otherPayerSupervisingProvider
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerSupervisingProvider, "L2330F");
                Assert.IsNotNull(payerSupervisingProvider, "L2330F - NM1");
                Assert.IsNotNull(payerSupervisingProviderSecondaryIdentification, "L2330F - REF");
                Assert.IsTrue(otherPayerSupervisingProvider.HasValue);
                Assert.IsFalse(payerSupervisingProvider.HasValue);
                Assert.IsFalse(payerSupervisingProviderSecondaryIdentification.HasValue);
                Assert.IsFalse(payerSupervisingProvider.IsPresent);
                Assert.IsFalse(payerSupervisingProviderSecondaryIdentification.IsPresent);

                // L2330G
                var otherPayerBillingProvider = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330G);

                var payerBillingProvider = otherPayerBillingProvider
                    .Select(x => x.OtherPayerBillingProvider)
                    .Select(x => x.EntityIdentifierCode);

                var otherPayerBillingProviderSecondaryIdentification = otherPayerBillingProvider
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerBillingProvider, "L2330G");
                Assert.IsNotNull(payerBillingProvider, "L2330G - NM1");
                Assert.IsNotNull(otherPayerBillingProviderSecondaryIdentification, "L2330G - REF");
                Assert.IsFalse(otherPayerBillingProvider.HasValue);
                Assert.IsFalse(payerBillingProvider.HasValue);
                Assert.IsFalse(otherPayerBillingProviderSecondaryIdentification.HasValue);
                Assert.IsFalse(payerBillingProvider.IsPresent);
                Assert.IsFalse(otherPayerBillingProviderSecondaryIdentification.IsPresent);
            });
        }

        [Test(Description = @"Condition : L2330A => present,
            L2330B => present,
            L2330C => present,
            L2330D => missing,
            L2330E => present,
            L2330F => missing,
            L2330G => present")]
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
HL*2*1*22*1
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
CLM*26403774*200***11:B:1*Y**Y*I
DTP*431*D8*20061109
REF*G1*111222333444
HI✽ABK:8901✽BF:87200✽BF:5559
HI✽BP:8901✽BF:87200✽BF:5559
HI✽BG:8901✽BF:87200✽BF:5559
SBR*P********CI
AMT*D*411
AMT*A8*273
AMT*EAF*75
OI***Y*P**Y
NM1*IL*2*KILDARE ASSOCIATES*****XX*1581234567
N3*2345 OCEAN BLVD
N4*MI
REF*SY*R555588
NM1*PR*2*KILDARE ASSOCIATES*****XX*1581234567
N3*2345 OCEAN BLVD
N4*MI
REF*2U*R555588
NM1*DN*1*SMITH*JACK****MI*T55TY666
REF*0B*R555588
NM1*77*2*KEY INSURANCE COMPANY*****PI*999996666
REF*0B*98765
NM1*85*1*KILDARE*BEN****XX*6789012345
REF*G2*R555588
LX*1
SV3*AD:D3320*200****1
TOO*JP*5
SE*29*0002
IEA*1*176073292";

            var entityResult = Parser.Parse(message);

            // Assert.Multiple(() =>
            // {
                Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

                var query = entityResult.CreateQuery(layout);

                var queryResult = entityResult.Query(query);

                Assert.IsNotNull(queryResult);
                Assert.IsTrue(queryResult.HasResult);

                var transactions = queryResult.Select(x => x.Transaction)[0];

                Assert.IsNotNull(transactions, "Transaction");
                Assert.IsTrue(transactions.HasValue, "Transaction");

                // L2330A
                var otherSubscriberName = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330A);

                var subscribingProvider = otherSubscriberName
                    .Select(x => x.OtherSubscriber)
                    .Select(x => x.EntityIdentifierCode);

                var subscriberProviderSecondaryIdentification = otherSubscriberName
                    .Select(x => x.SecondaryIdentification)
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsTrue(otherSubscriberName.HasValue);
                Assert.IsTrue(subscribingProvider.HasValue);
                Assert.IsTrue(subscriberProviderSecondaryIdentification.HasValue);
                Assert.IsTrue(subscribingProvider.IsPresent);
                Assert.IsTrue(subscriberProviderSecondaryIdentification.IsPresent);
                Assert.AreEqual("IL", subscribingProvider.ValueOrDefault());
                Assert.AreEqual("SY", subscriberProviderSecondaryIdentification.ValueOrDefault());

                // L2330B
                var otherPayerName = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330B);

                var payer = otherPayerName
                    .Select(x => x.OtherPayer)
                    .Select(x => x.EntityIdentifierCode);

                var payerSecondaryIdentification = otherPayerName
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherSubscriberName, "L2330A");
                Assert.IsNotNull(subscribingProvider, "L2330A - NM1");
                Assert.IsNotNull(subscriberProviderSecondaryIdentification, "L2330A - REF");
                Assert.IsTrue(otherPayerName.HasValue);
                Assert.IsTrue(payer.HasValue);
                Assert.IsTrue(payerSecondaryIdentification.HasValue);
                Assert.IsTrue(payer.IsPresent);
                Assert.IsTrue(payerSecondaryIdentification.IsPresent);
                Assert.AreEqual("PR", payer.ValueOrDefault());
                Assert.AreEqual("2U", payerSecondaryIdentification.ValueOrDefault());

                // L2330C
                var otherPayerReferringProvider = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330C)[0];

                var referringProvider = otherPayerReferringProvider
                    .Select(x => x.OtherPayerReferringProvider)
                    .Select(x => x.EntityIdentifierCode);

                var referringProviderSecondaryIdentification = otherPayerReferringProvider
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerReferringProvider, "L2330C");
                Assert.IsNotNull(referringProvider, "L2330C - NM1");
                Assert.IsNotNull(referringProviderSecondaryIdentification, "L2330C - REF");
                Assert.IsTrue(otherPayerReferringProvider.HasValue);
                Assert.IsTrue(referringProvider.HasValue);
                Assert.IsTrue(referringProviderSecondaryIdentification.HasValue);
                Assert.IsTrue(referringProviderSecondaryIdentification.IsPresent);
                Assert.AreEqual("DN", referringProvider.ValueOrDefault());
                Assert.AreEqual("0B", referringProviderSecondaryIdentification.ValueOrDefault());

                // L2330D
                var otherPayerRenderingProvider = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330D);

                var payerRenderingProvider = otherPayerRenderingProvider
                    .Select(x => x.OtherPayerRenderingProvider)
                    .Select(x => x.EntityIdentifierCode);

                var payerRenderingProviderSecondaryIdentification = otherPayerRenderingProvider
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerRenderingProvider, "L2320");
                Assert.IsNotNull(payerRenderingProvider, "L2330D - NM1");
                Assert.IsNotNull(payerRenderingProviderSecondaryIdentification, "L2330D - REF");
                Assert.IsTrue(otherPayerRenderingProvider.HasValue);
                Assert.IsFalse(payerRenderingProvider.HasValue);
                Assert.IsFalse(payerRenderingProviderSecondaryIdentification.HasValue);
                Assert.IsFalse(payerRenderingProvider.IsPresent);
                Assert.IsFalse(payerRenderingProviderSecondaryIdentification.IsPresent);

                // L2330E
                var otherPayerServiceFacilityLocation = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330E);

                var facilityLocation = otherPayerServiceFacilityLocation
                    .Select(x => x.OtherPayerServiceFacilityLocation)
                    .Select(x => x.EntityIdentifierCode);

                var payerServiceFacilityLocationSecondaryIdentification = otherPayerServiceFacilityLocation
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerServiceFacilityLocation, "L2330E");
                Assert.IsNotNull(facilityLocation, "L2330E - NM1");
                Assert.IsNotNull(payerServiceFacilityLocationSecondaryIdentification, "L2330E - REF");
                Assert.IsTrue(otherPayerServiceFacilityLocation.HasValue);
                Assert.IsTrue(facilityLocation.HasValue);
                Assert.IsTrue(payerServiceFacilityLocationSecondaryIdentification.HasValue);
                Assert.IsTrue(facilityLocation.IsPresent);
                Assert.IsTrue(payerServiceFacilityLocationSecondaryIdentification.IsPresent);
                Assert.AreEqual("77", facilityLocation.ValueOrDefault());
                Assert.AreEqual("0B", payerServiceFacilityLocationSecondaryIdentification.ValueOrDefault());

                // L2330F
                var otherPayerSupervisingProvider = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330F);

                var payerSupervisingProvider = otherPayerSupervisingProvider
                    .Select(x => x.OtherPayerSupervisingProvider)
                    .Select(x => x.EntityIdentifierCode);

                var payerSupervisingProviderSecondaryIdentification = otherPayerSupervisingProvider
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerSupervisingProvider, "L2330");
                Assert.IsNotNull(payerSupervisingProvider, "l2330f - NM1");
                Assert.IsNotNull(payerSupervisingProviderSecondaryIdentification, "l2330f - REF");
                Assert.IsTrue(otherPayerSupervisingProvider.HasValue);
                Assert.IsFalse(payerSupervisingProvider.HasValue);
                Assert.IsFalse(payerSupervisingProviderSecondaryIdentification.HasValue);
                Assert.IsFalse(payerSupervisingProvider.IsPresent);
                Assert.IsFalse(payerSupervisingProviderSecondaryIdentification.IsPresent);

                // L2330G
                var otherPayerBillingProvider = transactions
                    .Select(x => x.Loop2000C)[0]
                    .Select(x => x.Loop2300)[0]
                    .Select(x => x.Loop2320)[0]
                    .Select(x => x.Loop2330G);

                var payerBillingProvider = otherPayerBillingProvider
                    .Select(x => x.OtherPayerBillingProvider)
                    .Select(x => x.EntityIdentifierCode);

                var otherPayerBillingProviderSecondaryIdentification = otherPayerBillingProvider
                    .Select(x => x.SecondaryIdentification)[0]
                    .Select(x => x.ReferenceIdentificationQualifier);

                Assert.IsNotNull(otherPayerBillingProvider, "L2330G");
                Assert.IsNotNull(payerBillingProvider, "L2330G - REF");
                Assert.IsNotNull(otherPayerBillingProviderSecondaryIdentification, "L2330G - REF");
                Assert.IsTrue(otherPayerBillingProvider.HasValue);
                Assert.IsTrue(payerBillingProvider.HasValue);
                Assert.IsTrue(otherPayerBillingProviderSecondaryIdentification.HasValue);
                Assert.IsTrue(payerBillingProvider.IsPresent);
                Assert.IsTrue(otherPayerBillingProviderSecondaryIdentification.IsPresent);
                Assert.AreEqual("85", payerBillingProvider.ValueOrDefault());
                Assert.AreEqual("G2", otherPayerBillingProviderSecondaryIdentification.ValueOrDefault());
            // });
        }
    }
}