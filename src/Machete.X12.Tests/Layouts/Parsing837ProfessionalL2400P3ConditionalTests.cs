namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing837ProfessionalL2400P3ConditionalTests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test(Description = @"Condition : ServiceDate => 472,
            PrescriptionDate = 471,
            CertificationRevisionDate = 607,
            BeginTherapyDate = 463,
            LastCertificationDate = 461,
            LastSeenDate = 304,
            TestDate = 738,
            ShippedDate = 011,
            LastXRayDate = 455,
            InitialTreatmentDate => 454")]
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
DTP*471*RD8*20050314-20050325
DTP*607*RD8*20050314-20050325
DTP*463*RD8*20050314-20050325
DTP*461*RD8*20050314-20050325
DTP*304*RD8*20050314-20050325
DTP*738*RD8*20050314-20050325
DTP*011*RD8*20050314-20050325
DTP*455*RD8*20050314-20050325
DTP*454*RD8*20050314-20050325
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

            var serviceDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.ServiceDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(serviceDate != null);
            Assert.IsTrue(serviceDate.HasValue);
            Assert.IsTrue(serviceDate.IsPresent);
            Assert.AreEqual("472", serviceDate.ValueOrDefault());

            var prescriptionDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.PrescriptionDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(prescriptionDate != null);
            Assert.IsTrue(prescriptionDate.HasValue);
            Assert.IsTrue(prescriptionDate.IsPresent);
            Assert.AreEqual("471", prescriptionDate.ValueOrDefault());

            var certificationRevisionDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.CertificationRevisionDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(certificationRevisionDate != null);
            Assert.IsTrue(certificationRevisionDate.HasValue);
            Assert.IsTrue(certificationRevisionDate.IsPresent);
            Assert.AreEqual("607", certificationRevisionDate.ValueOrDefault());

            var beginTherapyDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.BeginTherapyDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(beginTherapyDate != null);
            Assert.IsTrue(beginTherapyDate.HasValue);
            Assert.IsTrue(beginTherapyDate.IsPresent);
            Assert.AreEqual("463", beginTherapyDate.ValueOrDefault());

            var lastCertificationDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LastCertificationDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(lastCertificationDate != null);
            Assert.IsTrue(lastCertificationDate.HasValue);
            Assert.IsTrue(lastCertificationDate.IsPresent);
            Assert.AreEqual("461", lastCertificationDate.ValueOrDefault());

            var lastSeenDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LastSeenDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(lastSeenDate != null);
            Assert.IsTrue(lastSeenDate.HasValue);
            Assert.IsTrue(lastSeenDate.IsPresent);
            Assert.AreEqual("304", lastSeenDate.ValueOrDefault());

            var testDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.TestDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(testDate != null);
            Assert.IsTrue(testDate.HasValue);
            Assert.IsTrue(testDate.IsPresent);
            Assert.AreEqual("738", testDate.ValueOrDefault());

            var shippedDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.ShippedDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(shippedDate != null);
            Assert.IsTrue(shippedDate.HasValue);
            Assert.IsTrue(shippedDate.IsPresent);
            Assert.AreEqual("011", shippedDate.ValueOrDefault());

            var lastXRayDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LastXRayDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(lastXRayDate != null);
            Assert.IsTrue(lastXRayDate.HasValue);
            Assert.IsTrue(lastXRayDate.IsPresent);
            Assert.AreEqual("455", lastXRayDate.ValueOrDefault());

            var initialTreatmentDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.InitialTreatmentDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(initialTreatmentDate != null);
            Assert.IsTrue(initialTreatmentDate.HasValue);
            Assert.IsTrue(initialTreatmentDate.IsPresent);
            Assert.AreEqual("454", initialTreatmentDate.ValueOrDefault());
        }

        [Test(Description = @"Condition : ServiceDate => 472,
            PrescriptionDate = missing,
            CertificationRevisionDate = missing,
            BeginTherapyDate = missing,
            LastCertificationDate = missing,
            LastSeenDate = missing,
            TestDate = missing,
            ShippedDate = missing,
            LastXRayDate = missing,
            InitialTreatmentDate => 454")]
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
PWK*OZ*FX***AC*DMN0012
PWK*OZ*AB***AC*DMN0012
CRC*07*Y*01
CRC*70*Y*65
CRC*09*N*ZV
DTP*472*RD8*20050314-20050325
DTP*454*RD8*20050314-20050325
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

            var serviceDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.ServiceDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(serviceDate != null);
            Assert.IsTrue(serviceDate.HasValue);
            Assert.IsTrue(serviceDate.IsPresent);
            Assert.AreEqual("472", serviceDate.ValueOrDefault());

            var prescriptionDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.PrescriptionDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(prescriptionDate != null);
            Assert.IsFalse(prescriptionDate.HasValue);
            Assert.IsFalse(prescriptionDate.IsPresent);

            var certificationRevisionDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.CertificationRevisionDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(certificationRevisionDate != null);
            Assert.IsFalse(certificationRevisionDate.HasValue);
            Assert.IsFalse(certificationRevisionDate.IsPresent);

            var beginTherapyDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.BeginTherapyDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(beginTherapyDate != null);
            Assert.IsFalse(beginTherapyDate.HasValue);
            Assert.IsFalse(beginTherapyDate.IsPresent);

            var lastCertificationDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LastCertificationDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(lastCertificationDate != null);
            Assert.IsFalse(lastCertificationDate.HasValue);
            Assert.IsFalse(lastCertificationDate.IsPresent);

            var lastSeenDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LastSeenDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(lastSeenDate != null);
            Assert.IsFalse(lastSeenDate.HasValue);
            Assert.IsFalse(lastSeenDate.IsPresent);

            var testDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.TestDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(testDate != null);
            Assert.IsFalse(testDate.HasValue);
            Assert.IsFalse(testDate.IsPresent);

            var shippedDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.ShippedDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(shippedDate != null);
            Assert.IsFalse(shippedDate.HasValue);
            Assert.IsFalse(shippedDate.IsPresent);

            var lastXRayDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LastXRayDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(lastXRayDate != null);
            Assert.IsFalse(lastXRayDate.HasValue);
            Assert.IsFalse(lastXRayDate.IsPresent);

            var initialTreatmentDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.InitialTreatmentDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(initialTreatmentDate != null);
            Assert.IsTrue(initialTreatmentDate.HasValue);
            Assert.IsTrue(initialTreatmentDate.IsPresent);
            Assert.AreEqual("454", initialTreatmentDate.ValueOrDefault());
        }

        [Test(Description = @"Condition : ServiceDate => 472,
            PrescriptionDate = missing,
            CertificationRevisionDate = missing,
            BeginTherapyDate = missing,
            LastCertificationDate = missing,
            LastSeenDate = missing,
            TestDate = missing,
            ShippedDate = 011,
            LastXRayDate = missing,
            InitialTreatmentDate => 454")]
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
PWK*OZ*FX***AC*DMN0012
PWK*OZ*AB***AC*DMN0012
CRC*07*Y*01
CRC*70*Y*65
CRC*09*N*ZV
DTP*472*RD8*20050314-20050325
DTP*011*RD8*20050314-20050325
DTP*454*RD8*20050314-20050325
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

            var serviceDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.ServiceDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(serviceDate != null);
            Assert.IsTrue(serviceDate.HasValue);
            Assert.IsTrue(serviceDate.IsPresent);
            Assert.AreEqual("472", serviceDate.ValueOrDefault());

            var prescriptionDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.PrescriptionDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(prescriptionDate != null);
            Assert.IsFalse(prescriptionDate.HasValue);
            Assert.IsFalse(prescriptionDate.IsPresent);

            var certificationRevisionDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.CertificationRevisionDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(certificationRevisionDate != null);
            Assert.IsFalse(certificationRevisionDate.HasValue);
            Assert.IsFalse(certificationRevisionDate.IsPresent);

            var beginTherapyDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.BeginTherapyDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(beginTherapyDate != null);
            Assert.IsFalse(beginTherapyDate.HasValue);
            Assert.IsFalse(beginTherapyDate.IsPresent);

            var lastCertificationDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LastCertificationDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(lastCertificationDate != null);
            Assert.IsFalse(lastCertificationDate.HasValue);
            Assert.IsFalse(lastCertificationDate.IsPresent);

            var lastSeenDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LastSeenDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(lastSeenDate != null);
            Assert.IsFalse(lastSeenDate.HasValue);
            Assert.IsFalse(lastSeenDate.IsPresent);

            var testDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.TestDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(testDate != null);
            Assert.IsFalse(testDate.HasValue);
            Assert.IsFalse(testDate.IsPresent);

            var shippedDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.ShippedDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(shippedDate != null);
            Assert.IsTrue(shippedDate.HasValue);
            Assert.IsTrue(shippedDate.IsPresent);
            Assert.AreEqual("011", shippedDate.ValueOrDefault());

            var lastXRayDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LastXRayDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(lastXRayDate != null);
            Assert.IsFalse(lastXRayDate.HasValue);
            Assert.IsFalse(lastXRayDate.IsPresent);

            var initialTreatmentDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.InitialTreatmentDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(initialTreatmentDate != null);
            Assert.IsTrue(initialTreatmentDate.HasValue);
            Assert.IsTrue(initialTreatmentDate.IsPresent);
            Assert.AreEqual("454", initialTreatmentDate.ValueOrDefault());
        }

        [Test(Description = @"Condition : ServiceDate => 472,
            PrescriptionDate = missing,
            CertificationRevisionDate = missing,
            BeginTherapyDate = missing,
            LastCertificationDate = missing,
            LastSeenDate = missing,
            TestDate = missing,
            ShippedDate = missing,
            LastXRayDate = missing,
            InitialTreatmentDate => missing")]
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
PWK*OZ*FX***AC*DMN0012
PWK*OZ*AB***AC*DMN0012
CRC*07*Y*01
CRC*70*Y*65
CRC*09*N*ZV
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

            var serviceDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.ServiceDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(serviceDate != null);
            Assert.IsTrue(serviceDate.HasValue);
            Assert.IsTrue(serviceDate.IsPresent);
            Assert.AreEqual("472", serviceDate.ValueOrDefault());

            var prescriptionDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.PrescriptionDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(prescriptionDate != null);
            Assert.IsFalse(prescriptionDate.HasValue);
            Assert.IsFalse(prescriptionDate.IsPresent);

            var certificationRevisionDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.CertificationRevisionDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(certificationRevisionDate != null);
            Assert.IsFalse(certificationRevisionDate.HasValue);
            Assert.IsFalse(certificationRevisionDate.IsPresent);

            var beginTherapyDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.BeginTherapyDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(beginTherapyDate != null);
            Assert.IsFalse(beginTherapyDate.HasValue);
            Assert.IsFalse(beginTherapyDate.IsPresent);

            var lastCertificationDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LastCertificationDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(lastCertificationDate != null);
            Assert.IsFalse(lastCertificationDate.HasValue);
            Assert.IsFalse(lastCertificationDate.IsPresent);

            var lastSeenDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LastSeenDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(lastSeenDate != null);
            Assert.IsFalse(lastSeenDate.HasValue);
            Assert.IsFalse(lastSeenDate.IsPresent);

            var testDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.TestDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(testDate != null);
            Assert.IsFalse(testDate.HasValue);
            Assert.IsFalse(testDate.IsPresent);

            var shippedDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.ShippedDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(shippedDate != null);
            Assert.IsFalse(shippedDate.HasValue);
            Assert.IsFalse(shippedDate.IsPresent);

            var lastXRayDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.LastXRayDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(lastXRayDate != null);
            Assert.IsFalse(lastXRayDate.HasValue);
            Assert.IsFalse(lastXRayDate.IsPresent);

            var initialTreatmentDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.ServiceLineNumber)[0]
                .Select(x => x.InitialTreatmentDate)
                .Select(x => x.DateTimeQualifier);

            Assume.That(initialTreatmentDate != null);
            Assert.IsFalse(initialTreatmentDate.HasValue);
            Assert.IsFalse(initialTreatmentDate.IsPresent);
        }
    }
}