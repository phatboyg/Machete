namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing837ProfessionalL2300P13ConditionalTests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test(Description = @"Condition : AmbulanceCertification => 07,
            PatientConditionInfo => E1,
            HomeboundIndicator => 75,
            EPSDTReferral => ZZ"), Explicit("Issue #65")]
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
CRC✽07✽Y✽65
CRC✽E1✽Y✽65
CRC✽75✽Y✽65
CRC✽ZZ✽Y✽65
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

            var ambulanceCertification = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AmbulanceCertification)[0]
                .Select(x => x.CodeCategory);

            Assume.That(ambulanceCertification != null);
            Assert.IsTrue(ambulanceCertification.HasValue);
            Assert.IsTrue(ambulanceCertification.IsPresent);
            Assert.AreEqual("07", ambulanceCertification.ValueOrDefault());

            var patientConditionInfo = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.PatientConditionInfo)[0]
                .Select(x => x.CodeCategory);

            Assume.That(patientConditionInfo != null);
            Assert.IsTrue(patientConditionInfo.HasValue);
            Assert.IsTrue(patientConditionInfo.IsPresent);
            Assert.AreEqual("E1", patientConditionInfo.ValueOrDefault());

            var homeboundIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.HomeboundIndicator)
                .Select(x => x.CodeCategory);

            Assume.That(homeboundIndicator != null);
            Assert.IsTrue(homeboundIndicator.HasValue);
            Assert.IsTrue(homeboundIndicator.IsPresent);
            Assert.AreEqual("75", homeboundIndicator.ValueOrDefault());

            var epsdtReferral = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.EPSDTReferral)
                .Select(x => x.CodeCategory);

            Assume.That(epsdtReferral != null);
            Assert.IsTrue(epsdtReferral.HasValue);
            Assert.IsTrue(epsdtReferral.IsPresent);
            Assert.AreEqual("ZZ", epsdtReferral.ValueOrDefault());
        }

        [Test(Description = @"Condition : AmbulanceCertification => [07],
            PatientConditionInfo => missing,
            HomeboundIndicator => missing,
            EPSDTReferral => missing"), Explicit("Issue #65")]
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
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
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
                if (!transactions.Select(x => x.PatientDetail)[0]
                    .Select(x => x.ClaimInformation)[0]
                    .Select(x => x.AmbulanceCertification)
                    .TryGetValue(i, out Segment<CRC> segment))
                    break;

                var ambulanceCertification = segment.Select(x => x.CodeCategory);
                
                Assume.That(ambulanceCertification != null);
                Assert.IsTrue(ambulanceCertification.HasValue);
                Assert.IsTrue(ambulanceCertification.IsPresent);
                Assert.AreEqual("07", ambulanceCertification.ValueOrDefault());
            }

            var patientConditionInfo = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.PatientConditionInfo)[0]
                .Select(x => x.CodeCategory);

            Assume.That(patientConditionInfo != null);
            Assert.IsFalse(patientConditionInfo.HasValue);
            Assert.IsFalse(patientConditionInfo.IsPresent);

            var homeboundIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.HomeboundIndicator)
                .Select(x => x.CodeCategory);

            Assume.That(homeboundIndicator != null);
            Assert.IsFalse(homeboundIndicator.HasValue);
            Assert.IsFalse(homeboundIndicator.IsPresent);

            var epsdtReferral = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.EPSDTReferral)
                .Select(x => x.CodeCategory);

            Assume.That(epsdtReferral != null);
            Assert.IsFalse(epsdtReferral.HasValue);
            Assert.IsFalse(epsdtReferral.IsPresent);
        }

        [Test(Description = @"Condition : AmbulanceCertification => [07],
            PatientConditionInfo => [E1],
            HomeboundIndicator => missing,
            EPSDTReferral => missing"), Explicit("Issue #65")]
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
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽E1✽Y✽65
CRC✽E1✽Y✽65
CRC✽E1✽Y✽65
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
                if (!transactions.Select(x => x.PatientDetail)[0]
                    .Select(x => x.ClaimInformation)[0]
                    .Select(x => x.AmbulanceCertification)
                    .TryGetValue(i, out Segment<CRC> segment))
                    break;

                var ambulanceCertification = segment.Select(x => x.CodeCategory);
                
                Assume.That(ambulanceCertification != null);
                Assert.IsTrue(ambulanceCertification.HasValue);
                Assert.IsTrue(ambulanceCertification.IsPresent);
                Assert.AreEqual("07", ambulanceCertification.ValueOrDefault());
            }

            for (int i = 0;; i++)
            {
                if (!transactions.Select(x => x.PatientDetail)[0]
                    .Select(x => x.ClaimInformation)[0]
                    .Select(x => x.PatientConditionInfo)
                    .TryGetValue(i, out Segment<CRC> segment))
                    break;

                var patientConditionInfo = segment.Select(x => x.CodeCategory);
                
                Assume.That(patientConditionInfo != null);
                Assert.IsTrue(patientConditionInfo.HasValue);
                Assert.IsTrue(patientConditionInfo.IsPresent);
                Assert.AreEqual("E1", patientConditionInfo.ValueOrDefault());
            }

            var homeboundIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.HomeboundIndicator)
                .Select(x => x.CodeCategory);

            Assume.That(homeboundIndicator != null);
            Assert.IsFalse(homeboundIndicator.HasValue);
            Assert.IsFalse(homeboundIndicator.IsPresent);

            var epsdtReferral = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.EPSDTReferral)
                .Select(x => x.CodeCategory);

            Assume.That(epsdtReferral != null);
            Assert.IsFalse(epsdtReferral.HasValue);
            Assert.IsFalse(epsdtReferral.IsPresent);
        }

        [Test(Description = @"Condition : AmbulanceCertification => [07],
            PatientConditionInfo => [E1, E2, E3],
            HomeboundIndicator => missing,
            EPSDTReferral => missing"), Explicit("Issue #65")]
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
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽E1✽Y✽65
CRC✽E2✽Y✽65
CRC✽E3✽Y✽65
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
                if (!transactions.Select(x => x.PatientDetail)[0]
                    .Select(x => x.ClaimInformation)[0]
                    .Select(x => x.AmbulanceCertification)
                    .TryGetValue(i, out Segment<CRC> segment))
                    break;

                var ambulanceCertification = segment.Select(x => x.CodeCategory);
                
                Assume.That(ambulanceCertification != null);
                Assert.IsTrue(ambulanceCertification.HasValue);
                Assert.IsTrue(ambulanceCertification.IsPresent);
                Assert.AreEqual("07", ambulanceCertification.ValueOrDefault());
            }

            for (int i = 0;; i++)
            {
                if (!transactions.Select(x => x.PatientDetail)[0]
                    .Select(x => x.ClaimInformation)[0]
                    .Select(x => x.PatientConditionInfo)
                    .TryGetValue(i, out Segment<CRC> segment))
                    break;

                var patientConditionInfo = segment.Select(x => x.CodeCategory);
                
                Assume.That(patientConditionInfo != null);
                Assert.IsTrue(patientConditionInfo.HasValue);
                Assert.IsTrue(patientConditionInfo.IsPresent);
                Assert.That(patientConditionInfo.ValueOrDefault(), Is.EqualTo("E1").Or.EqualTo("E2").Or.EqualTo("E3"));
            }

            var homeboundIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.HomeboundIndicator)
                .Select(x => x.CodeCategory);

            Assume.That(homeboundIndicator != null);
            Assert.IsFalse(homeboundIndicator.HasValue);
            Assert.IsFalse(homeboundIndicator.IsPresent);

            var epsdtReferral = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.EPSDTReferral)
                .Select(x => x.CodeCategory);

            Assume.That(epsdtReferral != null);
            Assert.IsFalse(epsdtReferral.HasValue);
            Assert.IsFalse(epsdtReferral.IsPresent);
        }

        [Test(Description = @"Condition : AmbulanceCertification => [07],
            PatientConditionInfo => [E1, E2, E3],
            HomeboundIndicator => 75,
            EPSDTReferral => missing"), Explicit("Issue #65")]
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
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽E1✽Y✽65
CRC✽E2✽Y✽65
CRC✽E3✽Y✽65
CRC✽75✽Y✽65
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
                if (!transactions.Select(x => x.PatientDetail)[0]
                    .Select(x => x.ClaimInformation)[0]
                    .Select(x => x.AmbulanceCertification)
                    .TryGetValue(i, out Segment<CRC> segment))
                    break;

                var ambulanceCertification = segment.Select(x => x.CodeCategory);
                
                Assume.That(ambulanceCertification != null);
                Assert.IsTrue(ambulanceCertification.HasValue);
                Assert.IsTrue(ambulanceCertification.IsPresent);
                Assert.AreEqual("07", ambulanceCertification.ValueOrDefault());
            }

            for (int i = 0;; i++)
            {
                if (!transactions.Select(x => x.PatientDetail)[0]
                    .Select(x => x.ClaimInformation)[0]
                    .Select(x => x.PatientConditionInfo)
                    .TryGetValue(i, out Segment<CRC> segment))
                    break;

                var patientConditionInfo = segment.Select(x => x.CodeCategory);
                
                Assume.That(patientConditionInfo != null);
                Assert.IsTrue(patientConditionInfo.HasValue);
                Assert.IsTrue(patientConditionInfo.IsPresent);
                Assert.That(patientConditionInfo.ValueOrDefault(), Is.EqualTo("E1").Or.EqualTo("E2").Or.EqualTo("E3"));
            }

            var homeboundIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.HomeboundIndicator)
                .Select(x => x.CodeCategory);

            Assume.That(homeboundIndicator != null);
            Assert.IsTrue(homeboundIndicator.HasValue);
            Assert.IsTrue(homeboundIndicator.IsPresent);
            Assert.AreEqual("75", homeboundIndicator.ValueOrDefault());

            var epsdtReferral = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.EPSDTReferral)
                .Select(x => x.CodeCategory);

            Assume.That(epsdtReferral != null);
            Assert.IsFalse(epsdtReferral.HasValue);
            Assert.IsFalse(epsdtReferral.IsPresent);
        }

        [Test(Description = @"Condition : AmbulanceCertification => [07],
            PatientConditionInfo => [E1, E2, E3],
            HomeboundIndicator => 75,
            EPSDTReferral => ZZ"), Explicit("Issue #65")]
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
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽E1✽Y✽65
CRC✽E2✽Y✽65
CRC✽E3✽Y✽65
CRC✽75✽Y✽65
CRC✽ZZ✽Y✽65
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
                if (!transactions.Select(x => x.PatientDetail)[0]
                    .Select(x => x.ClaimInformation)[0]
                    .Select(x => x.AmbulanceCertification)
                    .TryGetValue(i, out Segment<CRC> segment))
                    break;

                var ambulanceCertification = segment.Select(x => x.CodeCategory);
                
                Assume.That(ambulanceCertification != null);
                Assert.IsTrue(ambulanceCertification.HasValue);
                Assert.IsTrue(ambulanceCertification.IsPresent);
                Assert.AreEqual("07", ambulanceCertification.ValueOrDefault());
            }

            for (int i = 0;; i++)
            {
                if (!transactions.Select(x => x.PatientDetail)[0]
                    .Select(x => x.ClaimInformation)[0]
                    .Select(x => x.PatientConditionInfo)
                    .TryGetValue(i, out Segment<CRC> segment))
                    break;

                var patientConditionInfo = segment.Select(x => x.CodeCategory);
                
                Assume.That(patientConditionInfo != null);
                Assert.IsTrue(patientConditionInfo.HasValue);
                Assert.IsTrue(patientConditionInfo.IsPresent);
                Assert.That(patientConditionInfo.ValueOrDefault(), Is.EqualTo("E1").Or.EqualTo("E2").Or.EqualTo("E3"));
            }

            var homeboundIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.HomeboundIndicator)
                .Select(x => x.CodeCategory);

            Assume.That(homeboundIndicator != null);
            Assert.IsTrue(homeboundIndicator.HasValue);
            Assert.IsTrue(homeboundIndicator.IsPresent);
            Assert.AreEqual("75", homeboundIndicator.ValueOrDefault());

            var epsdtReferral = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.EPSDTReferral)
                .Select(x => x.CodeCategory);

            Assume.That(epsdtReferral != null);
            Assert.IsTrue(epsdtReferral.HasValue);
            Assert.IsTrue(epsdtReferral.IsPresent);
            Assert.AreEqual("ZZ", epsdtReferral.ValueOrDefault());
        }

        [Test(Description = @"Condition : AmbulanceCertification => missing,
            PatientConditionInfo => [E1, E2, E3],
            HomeboundIndicator => 75,
            EPSDTReferral => missing"), Explicit("Issue #65")]
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
CRC✽E1✽Y✽65
CRC✽E2✽Y✽65
CRC✽E3✽Y✽65
CRC✽75✽Y✽65
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

            var ambulanceCertification = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AmbulanceCertification)[0]
                .Select(x => x.CodeCategory);

            Assume.That(ambulanceCertification != null);
            Assert.IsFalse(ambulanceCertification.HasValue);
            Assert.IsFalse(ambulanceCertification.IsPresent);

            for (int i = 0;; i++)
            {
                if (!transactions.Select(x => x.PatientDetail)[0]
                    .Select(x => x.ClaimInformation)[0]
                    .Select(x => x.PatientConditionInfo)
                    .TryGetValue(i, out Segment<CRC> segment))
                    break;

                var patientConditionInfo = segment.Select(x => x.CodeCategory);
                
                Assume.That(patientConditionInfo != null);
                Assert.IsTrue(patientConditionInfo.HasValue);
                Assert.IsTrue(patientConditionInfo.IsPresent);
                Assert.That(patientConditionInfo.ValueOrDefault(), Is.EqualTo("E1").Or.EqualTo("E2").Or.EqualTo("E3"));
            }

            var homeboundIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.HomeboundIndicator)
                .Select(x => x.CodeCategory);

            Assume.That(homeboundIndicator != null);
            Assert.IsTrue(homeboundIndicator.HasValue);
            Assert.IsTrue(homeboundIndicator.IsPresent);
            Assert.AreEqual("75", homeboundIndicator.ValueOrDefault());

            var epsdtReferral = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.EPSDTReferral)
                .Select(x => x.CodeCategory);

            Assume.That(epsdtReferral != null);
            Assert.IsFalse(epsdtReferral.HasValue);
            Assert.IsFalse(epsdtReferral.IsPresent);
        }

        [Test(Description = @"Condition : AmbulanceCertification => missing,
            PatientConditionInfo => [E1, E2, E3],
            HomeboundIndicator => missing,
            EPSDTReferral => missing"), Explicit("Issue #65")]
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
CRC✽E1✽Y✽65
CRC✽E2✽Y✽65
CRC✽E3✽Y✽65
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

            var ambulanceCertification = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AmbulanceCertification)[0]
                .Select(x => x.CodeCategory);

            Assume.That(ambulanceCertification != null);
            Assert.IsFalse(ambulanceCertification.HasValue);
            Assert.IsFalse(ambulanceCertification.IsPresent);

            for (int i = 0;; i++)
            {
                if (!transactions.Select(x => x.PatientDetail)[0]
                    .Select(x => x.ClaimInformation)[0]
                    .Select(x => x.PatientConditionInfo)
                    .TryGetValue(i, out Segment<CRC> segment))
                    break;

                var patientConditionInfo = segment.Select(x => x.CodeCategory);
                
                Assume.That(patientConditionInfo != null);
                Assert.IsTrue(patientConditionInfo.HasValue);
                Assert.IsTrue(patientConditionInfo.IsPresent);
                Assert.That(patientConditionInfo.ValueOrDefault(), Is.EqualTo("E1").Or.EqualTo("E2").Or.EqualTo("E3"));
            }

            var homeboundIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.HomeboundIndicator)
                .Select(x => x.CodeCategory);

            Assume.That(homeboundIndicator != null);
            Assert.IsFalse(homeboundIndicator.HasValue);
            Assert.IsFalse(homeboundIndicator.IsPresent);

            var epsdtReferral = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.EPSDTReferral)
                .Select(x => x.CodeCategory);

            Assume.That(epsdtReferral != null);
            Assert.IsFalse(epsdtReferral.HasValue);
            Assert.IsFalse(epsdtReferral.IsPresent);
        }

        [Test(Description = @"Condition : AmbulanceCertification => [07],
            PatientConditionInfo => missing,
            HomeboundIndicator => missing,
            EPSDTReferral => missing"), Explicit("Issue #65")]
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
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽07✽Y✽65
CRC✽E1✽Y✽65
CRC✽E1✽Y✽65
CRC✽E1✽Y✽65
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
                if (!transactions.Select(x => x.PatientDetail)[0]
                    .Select(x => x.ClaimInformation)[0]
                    .Select(x => x.AmbulanceCertification)
                    .TryGetValue(i, out Segment<CRC> segment))
                    break;

                var ambulanceCertification = segment.Select(x => x.CodeCategory);
                
                Assume.That(ambulanceCertification != null);
                Assert.IsTrue(ambulanceCertification.HasValue);
                Assert.IsTrue(ambulanceCertification.IsPresent);
                Assert.AreEqual("07", ambulanceCertification.ValueOrDefault());
            }

            var patientConditionInfo = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.PatientConditionInfo)[0]
                .Select(x => x.CodeCategory);

            Assume.That(patientConditionInfo != null);
            Assert.IsFalse(patientConditionInfo.HasValue);
            Assert.IsFalse(patientConditionInfo.IsPresent);

            var homeboundIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.HomeboundIndicator)
                .Select(x => x.CodeCategory);

            Assume.That(homeboundIndicator != null);
            Assert.IsFalse(homeboundIndicator.HasValue);
            Assert.IsFalse(homeboundIndicator.IsPresent);

            var epsdtReferral = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.EPSDTReferral)
                .Select(x => x.CodeCategory);

            Assume.That(epsdtReferral != null);
            Assert.IsFalse(epsdtReferral.HasValue);
            Assert.IsFalse(epsdtReferral.IsPresent);
        }

        [Test(Description = @"Condition : AmbulanceCertification => missing,
            PatientConditionInfo => missing,
            HomeboundIndicator => 75,
            EPSDTReferral => ZZ"), Explicit("Issue #65")]
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
CRC✽75✽Y✽65
CRC✽ZZ✽Y✽65
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

            var ambulanceCertification = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AmbulanceCertification)[0]
                .Select(x => x.CodeCategory);

            Assume.That(ambulanceCertification != null);
            Assert.IsFalse(ambulanceCertification.HasValue);
            Assert.IsFalse(ambulanceCertification.IsPresent);

            var patientConditionInfo = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.PatientConditionInfo)[0]
                .Select(x => x.CodeCategory);

            Assume.That(patientConditionInfo != null);
            Assert.IsFalse(patientConditionInfo.HasValue);
            Assert.IsFalse(patientConditionInfo.IsPresent);

            var homeboundIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.HomeboundIndicator)
                .Select(x => x.CodeCategory);

            Assume.That(homeboundIndicator != null);
            Assert.IsTrue(homeboundIndicator.HasValue);
            Assert.IsTrue(homeboundIndicator.IsPresent);
            Assert.AreEqual("75", homeboundIndicator.ValueOrDefault());

            var epsdtReferral = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.EPSDTReferral)
                .Select(x => x.CodeCategory);

            Assume.That(epsdtReferral != null);
            Assert.IsTrue(epsdtReferral.HasValue);
            Assert.IsTrue(epsdtReferral.IsPresent);
            Assert.AreEqual("ZZ", epsdtReferral.ValueOrDefault());
        }

        [Test(Description = @"Condition : AmbulanceCertification => missing,
            PatientConditionInfo => missing,
            HomeboundIndicator => missing,
            EPSDTReferral => ZZ"), Explicit("Issue #65")]
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
CRC✽ZZ✽Y✽65
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

            var ambulanceCertification = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AmbulanceCertification)[0]
                .Select(x => x.CodeCategory);

            Assume.That(ambulanceCertification != null);
            Assert.IsFalse(ambulanceCertification.HasValue);
            Assert.IsFalse(ambulanceCertification.IsPresent);

            var patientConditionInfo = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.PatientConditionInfo)[0]
                .Select(x => x.CodeCategory);

            Assume.That(patientConditionInfo != null);
            Assert.IsFalse(patientConditionInfo.HasValue);
            Assert.IsFalse(patientConditionInfo.IsPresent);

            var homeboundIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.HomeboundIndicator)
                .Select(x => x.CodeCategory);

            Assume.That(homeboundIndicator != null);
            Assert.IsTrue(homeboundIndicator.HasValue);
            Assert.IsTrue(homeboundIndicator.IsPresent);
            Assert.AreEqual("75", homeboundIndicator.ValueOrDefault());

            var epsdtReferral = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.EPSDTReferral)
                .Select(x => x.CodeCategory);

            Assume.That(epsdtReferral != null);
            Assert.IsTrue(epsdtReferral.HasValue);
            Assert.IsTrue(epsdtReferral.IsPresent);
            Assert.AreEqual("ZZ", epsdtReferral.ValueOrDefault());
        }

        [Test(Description = @"Condition : AmbulanceCertification => missing,
            PatientConditionInfo => missing,
            HomeboundIndicator => 75,
            EPSDTReferral => missing"), Explicit("Issue #65")]
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
CRC✽75✽Y✽65
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

            var ambulanceCertification = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AmbulanceCertification)[0]
                .Select(x => x.CodeCategory);

            Assume.That(ambulanceCertification != null);
            Assert.IsFalse(ambulanceCertification.HasValue);
            Assert.IsFalse(ambulanceCertification.IsPresent);

            var patientConditionInfo = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.PatientConditionInfo)[0]
                .Select(x => x.CodeCategory);

            Assume.That(patientConditionInfo != null);
            Assert.IsFalse(patientConditionInfo.HasValue);
            Assert.IsFalse(patientConditionInfo.IsPresent);

            var homeboundIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.HomeboundIndicator)
                .Select(x => x.CodeCategory);

            Assume.That(homeboundIndicator != null);
            Assert.IsTrue(homeboundIndicator.HasValue);
            Assert.IsTrue(homeboundIndicator.IsPresent);
            Assert.AreEqual("75", homeboundIndicator.ValueOrDefault());

            var epsdtReferral = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.EPSDTReferral)
                .Select(x => x.CodeCategory);

            Assume.That(epsdtReferral != null);
            Assert.IsFalse(epsdtReferral.HasValue);
            Assert.IsFalse(epsdtReferral.IsPresent);
        }

        [Test(Description = @"Condition : AmbulanceCertification => missing,
            PatientConditionInfo => missing,
            HomeboundIndicator => missing,
            EPSDTReferral => missing")]
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

            var ambulanceCertification = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AmbulanceCertification)[0]
                .Select(x => x.CodeCategory);

            Assume.That(ambulanceCertification != null);
            Assert.IsFalse(ambulanceCertification.HasValue);
            Assert.IsFalse(ambulanceCertification.IsPresent);

            var patientConditionInfo = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.PatientConditionInfo)[0]
                .Select(x => x.CodeCategory);

            Assume.That(patientConditionInfo != null);
            Assert.IsFalse(patientConditionInfo.HasValue);
            Assert.IsFalse(patientConditionInfo.IsPresent);

            var homeboundIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.HomeboundIndicator)
                .Select(x => x.CodeCategory);

            Assume.That(homeboundIndicator != null);
            Assert.IsFalse(homeboundIndicator.HasValue);
            Assert.IsFalse(homeboundIndicator.IsPresent);

            var epsdtReferral = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.EPSDTReferral)
                .Select(x => x.CodeCategory);

            Assume.That(epsdtReferral != null);
            Assert.IsFalse(epsdtReferral.HasValue);
            Assert.IsFalse(epsdtReferral.IsPresent);
        }
    }
}