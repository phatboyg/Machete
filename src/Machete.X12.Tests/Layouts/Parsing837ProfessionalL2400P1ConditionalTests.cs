namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing837ProfessionalL2400P1ConditionalTests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test(Description = @"Condition : LineSupplementalInformation => AA,
            DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator => AB"), Explicit("Issue #65")]
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
PWK*OZ*AA***AC*DMN0012
PWK*OZ*AB***AC*DMN0012
DTP*472*RD8*20050314-20050325
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

            var lineSupplementalInformation = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LineSupplementalInformation)[0]
                .Select(x => x.ReportTransmissionCode);

            Assume.That(lineSupplementalInformation != null);
            Assert.IsTrue(lineSupplementalInformation.HasValue);
            Assert.AreEqual("AA", lineSupplementalInformation.ValueOrDefault());

            var durableMedicalEquipmentCertificateOfMedicalNecessityIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator)
                .Select(x => x.ReportTransmissionCode);

            Assume.That(durableMedicalEquipmentCertificateOfMedicalNecessityIndicator != null);
            Assert.IsTrue(durableMedicalEquipmentCertificateOfMedicalNecessityIndicator.HasValue);
            Assert.AreEqual("AB", durableMedicalEquipmentCertificateOfMedicalNecessityIndicator.ValueOrDefault());
        }

        [Test(Description = @"Condition : LineSupplementalInformation => BM,
            DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator => AB"), Explicit("Issue #65")]
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
PWK*OZ*BM***AC*DMN0012
PWK*OZ*AB***AC*DMN0012
DTP*472*RD8*20050314-20050325
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

            var lineSupplementalInformation = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LineSupplementalInformation)[0]
                .Select(x => x.ReportTransmissionCode);

            Assume.That(lineSupplementalInformation != null);
            Assert.IsTrue(lineSupplementalInformation.HasValue);
            Assert.AreEqual("BM", lineSupplementalInformation.ValueOrDefault());

            var durableMedicalEquipmentCertificateOfMedicalNecessityIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator)
                .Select(x => x.ReportTransmissionCode);

            Assume.That(durableMedicalEquipmentCertificateOfMedicalNecessityIndicator != null);
            Assert.IsTrue(durableMedicalEquipmentCertificateOfMedicalNecessityIndicator.HasValue);
            Assert.AreEqual("AB", durableMedicalEquipmentCertificateOfMedicalNecessityIndicator.ValueOrDefault());
        }

        [Test(Description = @"Condition : LineSupplementalInformation => EL,
            DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator => AB"), Explicit("Issue #65")]
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
PWK*OZ*EL***AC*DMN0012
PWK*OZ*AB***AC*DMN0012
DTP*472*RD8*20050314-20050325
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

            var lineSupplementalInformation = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LineSupplementalInformation)[0]
                .Select(x => x.ReportTransmissionCode);

            Assume.That(lineSupplementalInformation != null);
            Assert.IsTrue(lineSupplementalInformation.HasValue);
            Assert.AreEqual("EL", lineSupplementalInformation.ValueOrDefault());

            var durableMedicalEquipmentCertificateOfMedicalNecessityIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator)
                .Select(x => x.ReportTransmissionCode);

            Assume.That(durableMedicalEquipmentCertificateOfMedicalNecessityIndicator != null);
            Assert.IsTrue(durableMedicalEquipmentCertificateOfMedicalNecessityIndicator.HasValue);
            Assert.AreEqual("AB", durableMedicalEquipmentCertificateOfMedicalNecessityIndicator.ValueOrDefault());
        }

        [Test(Description = @"Condition : LineSupplementalInformation => EM,
            DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator => AB"), Explicit("Issue #65")]
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
PWK*OZ*EM***AC*DMN0012
PWK*OZ*AB***AC*DMN0012
DTP*472*RD8*20050314-20050325
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

            var lineSupplementalInformation = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LineSupplementalInformation)[0]
                .Select(x => x.ReportTransmissionCode);

            Assume.That(lineSupplementalInformation != null);
            Assert.IsTrue(lineSupplementalInformation.HasValue);
            Assert.AreEqual("EM", lineSupplementalInformation.ValueOrDefault());

            var durableMedicalEquipmentCertificateOfMedicalNecessityIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator)
                .Select(x => x.ReportTransmissionCode);

            Assume.That(durableMedicalEquipmentCertificateOfMedicalNecessityIndicator != null);
            Assert.IsTrue(durableMedicalEquipmentCertificateOfMedicalNecessityIndicator.HasValue);
            Assert.AreEqual("AB", durableMedicalEquipmentCertificateOfMedicalNecessityIndicator.ValueOrDefault());
        }

        [Test(Description = @"Condition : LineSupplementalInformation => FT,
            DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator => AB"), Explicit("Issue #65")]
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
PWK*OZ*FT***AC*DMN0012
PWK*OZ*AB***AC*DMN0012
DTP*472*RD8*20050314-20050325
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

            var lineSupplementalInformation = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LineSupplementalInformation)[0]
                .Select(x => x.ReportTransmissionCode);

            Assume.That(lineSupplementalInformation != null);
            Assert.IsTrue(lineSupplementalInformation.HasValue);
            Assert.AreEqual("FT", lineSupplementalInformation.ValueOrDefault());

            var durableMedicalEquipmentCertificateOfMedicalNecessityIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator)
                .Select(x => x.ReportTransmissionCode);

            Assume.That(durableMedicalEquipmentCertificateOfMedicalNecessityIndicator != null);
            Assert.IsTrue(durableMedicalEquipmentCertificateOfMedicalNecessityIndicator.HasValue);
            Assert.AreEqual("AB", durableMedicalEquipmentCertificateOfMedicalNecessityIndicator.ValueOrDefault());
        }

        [Test(Description = @"Condition : LineSupplementalInformation => FX,
            DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator => AB"), Explicit("Issue #65")]
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
DTP*472*RD8*20050314-20050325
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

            var lineSupplementalInformation = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LineSupplementalInformation)[0]
                .Select(x => x.ReportTransmissionCode);

            Assume.That(lineSupplementalInformation != null);
            Assert.IsTrue(lineSupplementalInformation.HasValue);
            Assert.AreEqual("FX", lineSupplementalInformation.ValueOrDefault());

            var durableMedicalEquipmentCertificateOfMedicalNecessityIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator)
                .Select(x => x.ReportTransmissionCode);

            Assume.That(durableMedicalEquipmentCertificateOfMedicalNecessityIndicator != null);
            Assert.IsTrue(durableMedicalEquipmentCertificateOfMedicalNecessityIndicator.HasValue);
            Assert.AreEqual("AB", durableMedicalEquipmentCertificateOfMedicalNecessityIndicator.ValueOrDefault());
        }

        [Test(Description = @"Condition : LineSupplementalInformation => [AA, BM, EL, EM, FT, FX],
            DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator => missing")]
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
PWK*OZ*AA***AC*DMN0012
PWK*OZ*BM***AC*DMN0012
PWK*OZ*EL***AC*DMN0012
PWK*OZ*EM***AC*DMN0012
PWK*OZ*FT***AC*DMN0012
PWK*OZ*FX***AC*DMN0012
DTP*472*RD8*20050314-20050325
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
                    .Select(x => x.ServiceLineNumber)[0]
                    .Select(x => x.LineSupplementalInformation)
                    .TryGetValue(i, out Segment<PWK> segment))
                    break;
                    
                var lineSupplementalInformation = segment.Select(x => x.ReportTransmissionCode);
                
                Assume.That(lineSupplementalInformation != null);
                Assert.IsTrue(lineSupplementalInformation.HasValue);
                Assert.That(lineSupplementalInformation.ValueOrDefault(),
                    Is.EqualTo("AA").Or.EqualTo("BM").Or.EqualTo("EL").Or.EqualTo("EM").Or.EqualTo("FT").Or.EqualTo("FX"));
            }

            var durableMedicalEquipmentCertificateOfMedicalNecessityIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator)
                .Select(x => x.ReportTransmissionCode);

            Assume.That(durableMedicalEquipmentCertificateOfMedicalNecessityIndicator != null);
            Assert.IsFalse(durableMedicalEquipmentCertificateOfMedicalNecessityIndicator.HasValue);
        }

        [Test(Description = @"Condition : LineSupplementalInformation => missing,
            DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator => AB"), Explicit("Issue #65")]
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
PWK*OZ*AB***AC*DMN0012
DTP*472*RD8*20050314-20050325
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

            var lineSupplementalInformation = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LineSupplementalInformation);

            Assume.That(lineSupplementalInformation != null);
            Assert.IsFalse(lineSupplementalInformation.HasValue);

            var durableMedicalEquipmentCertificateOfMedicalNecessityIndicator = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator)
                .Select(x => x.ReportTransmissionCode);

            Assume.That(durableMedicalEquipmentCertificateOfMedicalNecessityIndicator != null);
            Assert.IsTrue(durableMedicalEquipmentCertificateOfMedicalNecessityIndicator.HasValue);
            Assert.AreEqual("AB", durableMedicalEquipmentCertificateOfMedicalNecessityIndicator.ValueOrDefault());
        }
    }
}