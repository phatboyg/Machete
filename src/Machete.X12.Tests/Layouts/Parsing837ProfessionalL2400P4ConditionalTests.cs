namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing837ProfessionalL2400P4ConditionalTests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test(Description = @"Condition : RepricedLineItemReferenceNumber => 9B,
            AdjustedRepricedLineItemReferenceNumber = 9D,
            PriorAuthorization = G1,
            LineItemControlNumber = 6R,
            MammographyCertificationNumber = EW,
            CLIANumber = X4,
            ReferringCLIAFacilityIdentification = F4,
            ImmunizationBatchNumber = BT,
            ReferralNumber => 9F"), Explicit("Issue #65")]
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
LX*1
SV1*HC:99211:25*12.25*UN*1*11**1:2:3**Y
PWK*OZ*FX***AC*DMN0012
PWK*OZ*AB***AC*DMN0012
CRC*07*Y*01
CRC*70*Y*65
CRC*09*N*ZV
DTP*472*RD8*20050314-20050325
REF*9B*444444
REF*9D*444444
REF*G1*444444
REF*6R*444444
REF*EW*444444
REF*X4*444444
REF*F4*444444
REF*BT*444444
REF*9F*444444
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

            var repricedLineItemReferenceNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.RepricedLineItemReferenceNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(repricedLineItemReferenceNumber != null);
            Assert.IsTrue(repricedLineItemReferenceNumber.HasValue);
            Assert.IsTrue(repricedLineItemReferenceNumber.IsPresent);
            Assert.AreEqual("9B", repricedLineItemReferenceNumber.ValueOrDefault());

            var adjustedRepricedLineItemReferenceNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.AdjustedRepricedLineItemReferenceNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(adjustedRepricedLineItemReferenceNumber != null);
            Assert.IsTrue(adjustedRepricedLineItemReferenceNumber.HasValue);
            Assert.IsTrue(adjustedRepricedLineItemReferenceNumber.IsPresent);
            Assert.AreEqual("9D", adjustedRepricedLineItemReferenceNumber.ValueOrDefault());

            var priorAuthorization = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.PriorAuthorization)[0]
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(priorAuthorization != null);
            Assert.IsTrue(priorAuthorization.HasValue);
            Assert.IsTrue(priorAuthorization.IsPresent);
            Assert.AreEqual("G1", priorAuthorization.ValueOrDefault());

            var lineItemControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LineItemControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(lineItemControlNumber != null);
            Assert.IsTrue(lineItemControlNumber.HasValue);
            Assert.IsTrue(lineItemControlNumber.IsPresent);
            Assert.AreEqual("6R", lineItemControlNumber.ValueOrDefault());

            var mammographyCertificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.MammographyCertificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(mammographyCertificationNumber != null);
            Assert.IsTrue(mammographyCertificationNumber.HasValue);
            Assert.IsTrue(mammographyCertificationNumber.IsPresent);
            Assert.AreEqual("EW", mammographyCertificationNumber.ValueOrDefault());

            var cliaNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.CLIANumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(cliaNumber != null);
            Assert.IsTrue(cliaNumber.HasValue);
            Assert.IsTrue(cliaNumber.IsPresent);
            Assert.AreEqual("X4", cliaNumber.ValueOrDefault());

            var referringCLIAFacilityIdentification = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.ReferringCLIAFacilityIdentification)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(referringCLIAFacilityIdentification != null);
            Assert.IsTrue(referringCLIAFacilityIdentification.HasValue);
            Assert.IsTrue(referringCLIAFacilityIdentification.IsPresent);
            Assert.AreEqual("F4", referringCLIAFacilityIdentification.ValueOrDefault());

            var immunizationBatchNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.ImmunizationBatchNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(immunizationBatchNumber != null);
            Assert.IsTrue(immunizationBatchNumber.HasValue);
            Assert.IsTrue(immunizationBatchNumber.IsPresent);
            Assert.AreEqual("BT", immunizationBatchNumber.ValueOrDefault());

            var referralNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.ReferralNumber)[0]
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(referralNumber != null);
            Assert.IsTrue(referralNumber.HasValue);
            Assert.IsTrue(referralNumber.IsPresent);
            Assert.AreEqual("9F", referralNumber.ValueOrDefault());
        }

        [Test(Description = @"Condition : RepricedLineItemReferenceNumber => 9B,
            AdjustedRepricedLineItemReferenceNumber = 9D,
            PriorAuthorization = [G1],
            LineItemControlNumber = 6R,
            MammographyCertificationNumber = EW,
            CLIANumber = X4,
            ReferringCLIAFacilityIdentification = F4,
            ImmunizationBatchNumber = BT,
            ReferralNumber => 9F"), Explicit("Issue #65")]
        public void Test()
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
LX*1
SV1*HC:99211:25*12.25*UN*1*11**1:2:3**Y
PWK*OZ*FX***AC*DMN0012
PWK*OZ*AB***AC*DMN0012
CRC*07*Y*01
CRC*70*Y*65
CRC*09*N*ZV
DTP*472*RD8*20050314-20050325
REF*9B*444444
REF*9D*444444
REF*G1*444444
REF*G1*444444
REF*G1*444444
REF*G1*444444
REF*6R*444444
REF*EW*444444
REF*X4*444444
REF*F4*444444
REF*BT*444444
REF*9F*444444
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

            var repricedLineItemReferenceNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.RepricedLineItemReferenceNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(repricedLineItemReferenceNumber != null);
            Assert.IsTrue(repricedLineItemReferenceNumber.HasValue);
            Assert.IsTrue(repricedLineItemReferenceNumber.IsPresent);
            Assert.AreEqual("9B", repricedLineItemReferenceNumber.ValueOrDefault());

            var adjustedRepricedLineItemReferenceNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.AdjustedRepricedLineItemReferenceNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(adjustedRepricedLineItemReferenceNumber != null);
            Assert.IsTrue(adjustedRepricedLineItemReferenceNumber.HasValue);
            Assert.IsTrue(adjustedRepricedLineItemReferenceNumber.IsPresent);
            Assert.AreEqual("9D", adjustedRepricedLineItemReferenceNumber.ValueOrDefault());

            var priorAuthorization = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.PriorAuthorization)[0]
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(priorAuthorization != null);
            Assert.IsTrue(priorAuthorization.HasValue);
            Assert.IsTrue(priorAuthorization.IsPresent);
            Assert.AreEqual("G1", priorAuthorization.ValueOrDefault());

            var lineItemControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LineItemControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(lineItemControlNumber != null);
            Assert.IsTrue(lineItemControlNumber.HasValue);
            Assert.IsTrue(lineItemControlNumber.IsPresent);
            Assert.AreEqual("6R", lineItemControlNumber.ValueOrDefault());

            var mammographyCertificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.MammographyCertificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(mammographyCertificationNumber != null);
            Assert.IsTrue(mammographyCertificationNumber.HasValue);
            Assert.IsTrue(mammographyCertificationNumber.IsPresent);
            Assert.AreEqual("EW", mammographyCertificationNumber.ValueOrDefault());

            var cliaNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.CLIANumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(cliaNumber != null);
            Assert.IsTrue(cliaNumber.HasValue);
            Assert.IsTrue(cliaNumber.IsPresent);
            Assert.AreEqual("X4", cliaNumber.ValueOrDefault());

            var referringCLIAFacilityIdentification = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.ReferringCLIAFacilityIdentification)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(referringCLIAFacilityIdentification != null);
            Assert.IsTrue(referringCLIAFacilityIdentification.HasValue);
            Assert.IsTrue(referringCLIAFacilityIdentification.IsPresent);
            Assert.AreEqual("F4", referringCLIAFacilityIdentification.ValueOrDefault());

            var immunizationBatchNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.ImmunizationBatchNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(immunizationBatchNumber != null);
            Assert.IsTrue(immunizationBatchNumber.HasValue);
            Assert.IsTrue(immunizationBatchNumber.IsPresent);
            Assert.AreEqual("BT", immunizationBatchNumber.ValueOrDefault());

            var referralNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.ReferralNumber)[0]
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(referralNumber != null);
            Assert.IsTrue(referralNumber.HasValue);
            Assert.IsTrue(referralNumber.IsPresent);
            Assert.AreEqual("9F", referralNumber.ValueOrDefault());
        }
    }
}