namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing837ProfessionalL2330BConditionalTests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test(Description = @"Condition : SecondaryIdentification => 2U,
            PriorAuthorizationNumber => G1,
            ReferralNumber => 9F,
            ClaimAdjustmentIndicator => T4,
            ClaimControlNumber => F8"), Explicit("Issue #65")]
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
NM1*77*2*KILDARE ASSOCIATES*****XX*1581234567
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
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*2U*98765
REF*G1*AB333-Y5
REF*9F*12345
REF*T4*Y
REF*F8*R555588
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
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("2U", secondaryIdentification.ValueOrDefault());

            var priorAuthorizationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.PriorAuthorizationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(priorAuthorizationNumber != null);
            Assert.IsTrue(priorAuthorizationNumber.HasValue);
            Assert.IsTrue(priorAuthorizationNumber.IsPresent);
            Assert.AreEqual("G1", priorAuthorizationNumber.ValueOrDefault());

            var referralNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ReferralNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(referralNumber != null);
            Assert.IsTrue(referralNumber.HasValue);
            Assert.IsTrue(referralNumber.IsPresent);
            Assert.AreEqual("9F", referralNumber.ValueOrDefault());

            var claimAdjustmentIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ClaimAdjustmentIndicator)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(claimAdjustmentIndicator != null);
            Assert.IsTrue(claimAdjustmentIndicator.HasValue);
            Assert.IsTrue(claimAdjustmentIndicator.IsPresent);
            Assert.AreEqual("T4", claimAdjustmentIndicator.ValueOrDefault());

            var claimControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ClaimControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(claimControlNumber != null);
            Assert.IsTrue(claimControlNumber.HasValue);
            Assert.IsTrue(claimControlNumber.IsPresent);
            Assert.AreEqual("F8", claimControlNumber.ValueOrDefault());
        }

        [Test(Description = @"Condition : SecondaryIdentification => 2U,
            PriorAuthorizationNumber => missing,
            ReferralNumber => missing,
            ClaimAdjustmentIndicator => missing,
            ClaimControlNumber => missing"), Explicit("Issue #65")]
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
NM1*77*2*KILDARE ASSOCIATES*****XX*1581234567
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
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*2U*98765
REF*2U*98765
REF*2U*98765
REF*2U*98765
REF*2U*98765
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
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("2U", secondaryIdentification.ValueOrDefault());

            var priorAuthorizationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.PriorAuthorizationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(priorAuthorizationNumber != null);
            Assert.IsFalse(priorAuthorizationNumber.HasValue);
            Assert.IsFalse(priorAuthorizationNumber.IsPresent);

            var referralNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ReferralNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(referralNumber != null);
            Assert.IsFalse(referralNumber.HasValue);
            Assert.IsFalse(referralNumber.IsPresent);

            var claimAdjustmentIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ClaimAdjustmentIndicator)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(claimAdjustmentIndicator != null);
            Assert.IsFalse(claimAdjustmentIndicator.HasValue);
            Assert.IsFalse(claimAdjustmentIndicator.IsPresent);

            var claimControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ClaimControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(claimControlNumber != null);
            Assert.IsFalse(claimControlNumber.HasValue);
            Assert.IsFalse(claimControlNumber.IsPresent);
        }

        [Test(Description = @"Condition : SecondaryIdentification => [2U|EI|FY|NF],
            PriorAuthorizationNumber => missing,
            ReferralNumber => missing,
            ClaimAdjustmentIndicator => missing,
            ClaimControlNumber => missing")]
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
NM1*IL*1*SMITH*JACK****MI*T55TY666
N3*236 N MAIN ST
N4*MIAMI*FL*33111
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*2U*98765
REF*NF*98765
REF*2U*98765
REF*FY*98765
REF*2U*98765
REF*EI*98765
REF*2U*98765
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
                    .Select(x => x.OtherSubscriberInfo)[0]
                    .Select(x => x.OtherPayerName)
                    .Select(x => x.SecondaryIdentification)
                    .TryGetValue(i, out var segment))
                    break;

                var secondaryIdentification = segment.Select(x => x.ReferenceIdentificationQualifier);

                Assume.That(secondaryIdentification != null);
                Assert.IsTrue(secondaryIdentification.HasValue);
                Assert.IsTrue(secondaryIdentification.IsPresent);
                Assert.That(secondaryIdentification.ValueOrDefault(), Is.EqualTo("2U").Or.EqualTo("EI").Or.EqualTo("FY").Or.EqualTo("NF"));
            }

            var priorAuthorizationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.PriorAuthorizationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(priorAuthorizationNumber != null);
            Assert.IsFalse(priorAuthorizationNumber.HasValue);
            Assert.IsFalse(priorAuthorizationNumber.IsPresent);

            var referralNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ReferralNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(referralNumber != null);
            Assert.IsFalse(referralNumber.HasValue);
            Assert.IsFalse(referralNumber.IsPresent);

            var claimAdjustmentIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ClaimAdjustmentIndicator)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(claimAdjustmentIndicator != null);
            Assert.IsFalse(claimAdjustmentIndicator.HasValue);
            Assert.IsFalse(claimAdjustmentIndicator.IsPresent);

            var claimControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ClaimControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(claimControlNumber != null);
            Assert.IsFalse(claimControlNumber.HasValue);
            Assert.IsFalse(claimControlNumber.IsPresent);
        }

        [Test(Description = @"Condition : SecondaryIdentification => [2U],
            PriorAuthorizationNumber => missing,
            ReferralNumber => missing,
            ClaimAdjustmentIndicator => missing,
            ClaimControlNumber => missing")]
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
NM1*IL*1*SMITH*JACK****MI*T55TY666
N3*236 N MAIN ST
N4*MIAMI*FL*33111
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*2U*98765
REF*2U*98765
REF*2U*98765
REF*2U*98765
REF*2U*98765
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
                    .Select(x => x.OtherSubscriberInfo)[0]
                    .Select(x => x.OtherPayerName)
                    .Select(x => x.SecondaryIdentification)
                    .TryGetValue(i, out var segment))
                    break;

                var secondaryIdentification = segment.Select(x => x.ReferenceIdentificationQualifier);

                Assume.That(secondaryIdentification != null);
                Assert.IsTrue(secondaryIdentification.HasValue);
                Assert.IsTrue(secondaryIdentification.IsPresent);
                Assert.AreEqual("2U", secondaryIdentification.ValueOrDefault());
            }

            var priorAuthorizationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.PriorAuthorizationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(priorAuthorizationNumber != null);
            Assert.IsFalse(priorAuthorizationNumber.HasValue);
            Assert.IsFalse(priorAuthorizationNumber.IsPresent);

            var referralNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ReferralNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(referralNumber != null);
            Assert.IsFalse(referralNumber.HasValue);
            Assert.IsFalse(referralNumber.IsPresent);

            var claimAdjustmentIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ClaimAdjustmentIndicator)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(claimAdjustmentIndicator != null);
            Assert.IsFalse(claimAdjustmentIndicator.HasValue);
            Assert.IsFalse(claimAdjustmentIndicator.IsPresent);

            var claimControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ClaimControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(claimControlNumber != null);
            Assert.IsFalse(claimControlNumber.HasValue);
            Assert.IsFalse(claimControlNumber.IsPresent);
        }

        [Test(Description = @"Condition : SecondaryIdentification => missing,
            PriorAuthorizationNumber => G1,
            ReferralNumber => 9F,
            ClaimAdjustmentIndicator => T4,
            ClaimControlNumber => F8"), Explicit("Issue #65")]
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
NM1*IL*1*SMITH*JACK****MI*T55TY666
N3*236 N MAIN ST
N4*MIAMI*FL*33111
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*G1*AB333-Y5
REF*9F*12345
REF*T4*Y
REF*F8*R555588
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
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(secondaryIdentification != null);
            Assert.IsFalse(secondaryIdentification.HasValue);
            Assert.IsFalse(secondaryIdentification.IsPresent);

            var priorAuthorizationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.PriorAuthorizationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(priorAuthorizationNumber != null);
            Assert.IsTrue(priorAuthorizationNumber.HasValue);
            Assert.IsTrue(priorAuthorizationNumber.IsPresent);
            Assert.AreEqual("G1", priorAuthorizationNumber.ValueOrDefault());

            var referralNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ReferralNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(referralNumber != null);
            Assert.IsTrue(referralNumber.HasValue);
            Assert.IsTrue(referralNumber.IsPresent);
            Assert.AreEqual("9F", referralNumber.ValueOrDefault());

            var claimAdjustmentIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ClaimAdjustmentIndicator)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(claimAdjustmentIndicator != null);
            Assert.IsTrue(claimAdjustmentIndicator.HasValue);
            Assert.IsTrue(claimAdjustmentIndicator.IsPresent);
            Assert.AreEqual("T4", claimAdjustmentIndicator.ValueOrDefault());

            var claimControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ClaimControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(claimControlNumber != null);
            Assert.IsTrue(claimControlNumber.HasValue);
            Assert.IsTrue(claimControlNumber.IsPresent);
            Assert.AreEqual("F8", claimControlNumber.ValueOrDefault());
        }

        [Test(Description = @"Condition : SecondaryIdentification => missing,
            PriorAuthorizationNumber => missing,
            ReferralNumber => missing,
            ClaimAdjustmentIndicator => missing,
            ClaimControlNumber => missing"), Explicit("Issue #65")]
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
NM1*IL*1*SMITH*JACK****MI*T55TY666
N3*236 N MAIN ST
N4*MIAMI*FL*33111
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
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
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(secondaryIdentification != null);
            Assert.IsFalse(secondaryIdentification.HasValue);
            Assert.IsFalse(secondaryIdentification.IsPresent);

            var priorAuthorizationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.PriorAuthorizationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(priorAuthorizationNumber != null);
            Assert.IsFalse(priorAuthorizationNumber.HasValue);
            Assert.IsFalse(priorAuthorizationNumber.IsPresent);

            var referralNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ReferralNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(referralNumber != null);
            Assert.IsFalse(referralNumber.HasValue);
            Assert.IsFalse(referralNumber.IsPresent);

            var claimAdjustmentIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ClaimAdjustmentIndicator)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(claimAdjustmentIndicator != null);
            Assert.IsFalse(claimAdjustmentIndicator.HasValue);
            Assert.IsFalse(claimAdjustmentIndicator.IsPresent);

            var claimControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OtherSubscriberInfo)[0]
                .Select(x => x.OtherPayerName)
                .Select(x => x.ClaimControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(claimControlNumber != null);
            Assert.IsFalse(claimControlNumber.HasValue);
            Assert.IsFalse(claimControlNumber.IsPresent);
        }
    }
}