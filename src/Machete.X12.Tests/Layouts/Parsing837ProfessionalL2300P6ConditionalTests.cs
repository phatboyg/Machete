namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing837ProfessionalL2300P6ConditionalTests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test(Description = @"Condition : OnsetOfCurrentIllnessDate => 431,
            InitialTreatmentDate => 454,
            LastSeenDate => 304,
            AcuteManifestationDate => 453,
            AccidentDate => 439,
            LastMensrualPeriod => 484,
            LastXRayDate => 455,
            HearingVisionPrescriptionDate => 471,
            DisabilityDates => 314,
            LastWorkedDate => 297,
            AuthorizedReturnToWork => missing,
            AdmissionDate => missing,
            DischargeDate => missing,
            AssumedRelinquishedCareDates => missing,
            PropertyAndCasualtyDateOfFirstContact => missing,
            RepricerReceivedDate => missing")]
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
DTP*454*D8*20061109
DTP*304*D8*20061109
DTP*453*D8*20061109
DTP*439*D8*20061109
DTP*484*D8*20061109
DTP*455*D8*20061109
DTP*471*D8*20061109
DTP*314*D8*20061109
DTP*297*D8*20061109
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

            var onsetOfCurrentIllnessDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OnsetOfCurrentIllnessDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(onsetOfCurrentIllnessDate != null);
            Assert.IsTrue(onsetOfCurrentIllnessDate.HasValue);
            Assert.IsTrue(onsetOfCurrentIllnessDate.IsPresent);
            Assert.AreEqual("431", onsetOfCurrentIllnessDate.ValueOrDefault());

            var initialTreatmentDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.InitialTreatmentDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(initialTreatmentDate != null);
            Assert.IsTrue(initialTreatmentDate.HasValue);
            Assert.IsTrue(initialTreatmentDate.IsPresent);
            Assert.AreEqual("454", initialTreatmentDate.ValueOrDefault());

            var lastSeenDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.LastSeenDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(lastSeenDate != null);
            Assert.IsTrue(lastSeenDate.HasValue);
            Assert.IsTrue(lastSeenDate.IsPresent);
            Assert.AreEqual("304", lastSeenDate.ValueOrDefault());

            var acuteManifestationDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AcuteManifestationDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(acuteManifestationDate != null);
            Assert.IsTrue(acuteManifestationDate.HasValue);
            Assert.IsTrue(acuteManifestationDate.IsPresent);
            Assert.AreEqual("453", acuteManifestationDate.ValueOrDefault());

            var accidentDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AccidentDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(accidentDate != null);
            Assert.IsTrue(accidentDate.HasValue);
            Assert.IsTrue(accidentDate.IsPresent);
            Assert.AreEqual("439", accidentDate.ValueOrDefault());

            var lastMensrualPeriod = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.LastMensrualPeriod)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(lastMensrualPeriod != null);
            Assert.IsTrue(lastMensrualPeriod.HasValue);
            Assert.IsTrue(lastMensrualPeriod.IsPresent);
            Assert.AreEqual("484", lastMensrualPeriod.ValueOrDefault());

            var lastXRayDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.LastXRayDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(lastXRayDate != null);
            Assert.IsTrue(lastXRayDate.HasValue);
            Assert.IsTrue(lastXRayDate.IsPresent);
            Assert.AreEqual("455", lastXRayDate.ValueOrDefault());

            var hearingVisionPrescriptionDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.HearingVisionPrescriptionDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(hearingVisionPrescriptionDate != null);
            Assert.IsTrue(hearingVisionPrescriptionDate.HasValue);
            Assert.IsTrue(hearingVisionPrescriptionDate.IsPresent);
            Assert.AreEqual("471", hearingVisionPrescriptionDate.ValueOrDefault());

            var disabilityDates = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.DisabilityDates)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(disabilityDates != null);
            Assert.IsTrue(disabilityDates.HasValue);
            Assert.IsTrue(disabilityDates.IsPresent);
            Assert.AreEqual("314", disabilityDates.ValueOrDefault());

            var lastWorkedDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.LastWorkedDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(lastWorkedDate != null);
            Assert.IsTrue(lastWorkedDate.HasValue);
            Assert.IsTrue(lastWorkedDate.IsPresent);
            Assert.AreEqual("297", lastWorkedDate.ValueOrDefault());

            var authorizedReturnToWork = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AuthorizedReturnToWork)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(authorizedReturnToWork != null);
            Assert.IsFalse(authorizedReturnToWork.HasValue);
            Assert.IsFalse(authorizedReturnToWork.IsPresent);

            var admissionDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AdmissionDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(admissionDate != null);
            Assert.IsFalse(admissionDate.HasValue);
            Assert.IsFalse(admissionDate.IsPresent);

            var dischargeDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.DischargeDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(dischargeDate != null);
            Assert.IsFalse(dischargeDate.HasValue);
            Assert.IsFalse(dischargeDate.IsPresent);

            var assumedRelinquishedCareDates = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AssumedRelinquishedCareDates)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(assumedRelinquishedCareDates != null);
            Assert.IsFalse(assumedRelinquishedCareDates.HasValue);
            Assert.IsFalse(assumedRelinquishedCareDates.IsPresent);

            var propertyAndCasualtyDateOfFirstContact = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.PropertyAndCasualtyDateOfFirstContact)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(propertyAndCasualtyDateOfFirstContact != null);
            Assert.IsFalse(propertyAndCasualtyDateOfFirstContact.HasValue);
            Assert.IsFalse(propertyAndCasualtyDateOfFirstContact.IsPresent);

            var repricerReceivedDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.RepricerReceivedDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(repricerReceivedDate != null);
            Assert.IsFalse(repricerReceivedDate.HasValue);
            Assert.IsFalse(repricerReceivedDate.IsPresent);
        }
        
        [Test(Description = @"Condition : OnsetOfCurrentIllnessDate => 431,
            InitialTreatmentDate => 454,
            LastSeenDate => 304,
            AcuteManifestationDate => 453,
            AccidentDate => 439,
            LastMensrualPeriod => 484,
            LastXRayDate => 455,
            HearingVisionPrescriptionDate => 471,
            DisabilityDates => 360,
            LastWorkedDate => 297,
            AuthorizedReturnToWork => missing,
            AdmissionDate => missing,
            DischargeDate => missing,
            AssumedRelinquishedCareDates => missing,
            PropertyAndCasualtyDateOfFirstContact => missing,
            RepricerReceivedDate => missing")]
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
DTP*454*D8*20061109
DTP*304*D8*20061109
DTP*453*D8*20061109
DTP*439*D8*20061109
DTP*484*D8*20061109
DTP*455*D8*20061109
DTP*471*D8*20061109
DTP*360*D8*20061109
DTP*297*D8*20061109
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

            var onsetOfCurrentIllnessDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OnsetOfCurrentIllnessDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(onsetOfCurrentIllnessDate != null);
            Assert.IsTrue(onsetOfCurrentIllnessDate.HasValue);
            Assert.IsTrue(onsetOfCurrentIllnessDate.IsPresent);
            Assert.AreEqual("431", onsetOfCurrentIllnessDate.ValueOrDefault());

            var initialTreatmentDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.InitialTreatmentDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(initialTreatmentDate != null);
            Assert.IsTrue(initialTreatmentDate.HasValue);
            Assert.IsTrue(initialTreatmentDate.IsPresent);
            Assert.AreEqual("454", initialTreatmentDate.ValueOrDefault());

            var lastSeenDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.LastSeenDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(lastSeenDate != null);
            Assert.IsTrue(lastSeenDate.HasValue);
            Assert.IsTrue(lastSeenDate.IsPresent);
            Assert.AreEqual("304", lastSeenDate.ValueOrDefault());

            var acuteManifestationDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AcuteManifestationDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(acuteManifestationDate != null);
            Assert.IsTrue(acuteManifestationDate.HasValue);
            Assert.IsTrue(acuteManifestationDate.IsPresent);
            Assert.AreEqual("453", acuteManifestationDate.ValueOrDefault());

            var accidentDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AccidentDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(accidentDate != null);
            Assert.IsTrue(accidentDate.HasValue);
            Assert.IsTrue(accidentDate.IsPresent);
            Assert.AreEqual("439", accidentDate.ValueOrDefault());

            var lastMensrualPeriod = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.LastMensrualPeriod)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(lastMensrualPeriod != null);
            Assert.IsTrue(lastMensrualPeriod.HasValue);
            Assert.IsTrue(lastMensrualPeriod.IsPresent);
            Assert.AreEqual("484", lastMensrualPeriod.ValueOrDefault());

            var lastXRayDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.LastXRayDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(lastXRayDate != null);
            Assert.IsTrue(lastXRayDate.HasValue);
            Assert.IsTrue(lastXRayDate.IsPresent);
            Assert.AreEqual("455", lastXRayDate.ValueOrDefault());

            var hearingVisionPrescriptionDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.HearingVisionPrescriptionDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(hearingVisionPrescriptionDate != null);
            Assert.IsTrue(hearingVisionPrescriptionDate.HasValue);
            Assert.IsTrue(hearingVisionPrescriptionDate.IsPresent);
            Assert.AreEqual("471", hearingVisionPrescriptionDate.ValueOrDefault());

            var disabilityDates = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.DisabilityDates)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(disabilityDates != null);
            Assert.IsTrue(disabilityDates.HasValue);
            Assert.IsTrue(disabilityDates.IsPresent);
            Assert.AreEqual("360", disabilityDates.ValueOrDefault());

            var lastWorkedDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.LastWorkedDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(lastWorkedDate != null);
            Assert.IsTrue(lastWorkedDate.HasValue);
            Assert.IsTrue(lastWorkedDate.IsPresent);
            Assert.AreEqual("297", lastWorkedDate.ValueOrDefault());

            var authorizedReturnToWork = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AuthorizedReturnToWork)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(authorizedReturnToWork != null);
            Assert.IsFalse(authorizedReturnToWork.HasValue);
            Assert.IsFalse(authorizedReturnToWork.IsPresent);

            var admissionDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AdmissionDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(admissionDate != null);
            Assert.IsFalse(admissionDate.HasValue);
            Assert.IsFalse(admissionDate.IsPresent);

            var dischargeDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.DischargeDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(dischargeDate != null);
            Assert.IsFalse(dischargeDate.HasValue);
            Assert.IsFalse(dischargeDate.IsPresent);

            var assumedRelinquishedCareDates = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AssumedRelinquishedCareDates)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(assumedRelinquishedCareDates != null);
            Assert.IsFalse(assumedRelinquishedCareDates.HasValue);
            Assert.IsFalse(assumedRelinquishedCareDates.IsPresent);

            var propertyAndCasualtyDateOfFirstContact = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.PropertyAndCasualtyDateOfFirstContact)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(propertyAndCasualtyDateOfFirstContact != null);
            Assert.IsFalse(propertyAndCasualtyDateOfFirstContact.HasValue);
            Assert.IsFalse(propertyAndCasualtyDateOfFirstContact.IsPresent);

            var repricerReceivedDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.RepricerReceivedDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(repricerReceivedDate != null);
            Assert.IsFalse(repricerReceivedDate.HasValue);
            Assert.IsFalse(repricerReceivedDate.IsPresent);
        }
        
        [Test(Description = @"Condition : OnsetOfCurrentIllnessDate => 431,
            InitialTreatmentDate => 454,
            LastSeenDate => 304,
            AcuteManifestationDate => 453,
            AccidentDate => 439,
            LastMensrualPeriod => 484,
            LastXRayDate => 455,
            HearingVisionPrescriptionDate => 471,
            DisabilityDates => 361,
            LastWorkedDate => 297,
            AuthorizedReturnToWork => missing,
            AdmissionDate => missing,
            DischargeDate => missing,
            AssumedRelinquishedCareDates => missing,
            PropertyAndCasualtyDateOfFirstContact => missing,
            RepricerReceivedDate => missing")]
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
DTP*454*D8*20061109
DTP*304*D8*20061109
DTP*453*D8*20061109
DTP*439*D8*20061109
DTP*484*D8*20061109
DTP*455*D8*20061109
DTP*471*D8*20061109
DTP*361*D8*20061109
DTP*297*D8*20061109
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

            var onsetOfCurrentIllnessDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.OnsetOfCurrentIllnessDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(onsetOfCurrentIllnessDate != null);
            Assert.IsTrue(onsetOfCurrentIllnessDate.HasValue);
            Assert.IsTrue(onsetOfCurrentIllnessDate.IsPresent);
            Assert.AreEqual("431", onsetOfCurrentIllnessDate.ValueOrDefault());

            var initialTreatmentDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.InitialTreatmentDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(initialTreatmentDate != null);
            Assert.IsTrue(initialTreatmentDate.HasValue);
            Assert.IsTrue(initialTreatmentDate.IsPresent);
            Assert.AreEqual("454", initialTreatmentDate.ValueOrDefault());

            var lastSeenDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.LastSeenDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(lastSeenDate != null);
            Assert.IsTrue(lastSeenDate.HasValue);
            Assert.IsTrue(lastSeenDate.IsPresent);
            Assert.AreEqual("304", lastSeenDate.ValueOrDefault());

            var acuteManifestationDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AcuteManifestationDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(acuteManifestationDate != null);
            Assert.IsTrue(acuteManifestationDate.HasValue);
            Assert.IsTrue(acuteManifestationDate.IsPresent);
            Assert.AreEqual("453", acuteManifestationDate.ValueOrDefault());

            var accidentDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AccidentDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(accidentDate != null);
            Assert.IsTrue(accidentDate.HasValue);
            Assert.IsTrue(accidentDate.IsPresent);
            Assert.AreEqual("439", accidentDate.ValueOrDefault());

            var lastMensrualPeriod = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.LastMensrualPeriod)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(lastMensrualPeriod != null);
            Assert.IsTrue(lastMensrualPeriod.HasValue);
            Assert.IsTrue(lastMensrualPeriod.IsPresent);
            Assert.AreEqual("484", lastMensrualPeriod.ValueOrDefault());

            var lastXRayDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.LastXRayDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(lastXRayDate != null);
            Assert.IsTrue(lastXRayDate.HasValue);
            Assert.IsTrue(lastXRayDate.IsPresent);
            Assert.AreEqual("455", lastXRayDate.ValueOrDefault());

            var hearingVisionPrescriptionDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.HearingVisionPrescriptionDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(hearingVisionPrescriptionDate != null);
            Assert.IsTrue(hearingVisionPrescriptionDate.HasValue);
            Assert.IsTrue(hearingVisionPrescriptionDate.IsPresent);
            Assert.AreEqual("471", hearingVisionPrescriptionDate.ValueOrDefault());

            var disabilityDates = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.DisabilityDates)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(disabilityDates != null);
            Assert.IsTrue(disabilityDates.HasValue);
            Assert.IsTrue(disabilityDates.IsPresent);
            Assert.AreEqual("361", disabilityDates.ValueOrDefault());

            var lastWorkedDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.LastWorkedDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(lastWorkedDate != null);
            Assert.IsTrue(lastWorkedDate.HasValue);
            Assert.IsTrue(lastWorkedDate.IsPresent);
            Assert.AreEqual("297", lastWorkedDate.ValueOrDefault());

            var authorizedReturnToWork = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AuthorizedReturnToWork)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(authorizedReturnToWork != null);
            Assert.IsFalse(authorizedReturnToWork.HasValue);
            Assert.IsFalse(authorizedReturnToWork.IsPresent);

            var admissionDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AdmissionDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(admissionDate != null);
            Assert.IsFalse(admissionDate.HasValue);
            Assert.IsFalse(admissionDate.IsPresent);

            var dischargeDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.DischargeDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(dischargeDate != null);
            Assert.IsFalse(dischargeDate.HasValue);
            Assert.IsFalse(dischargeDate.IsPresent);

            var assumedRelinquishedCareDates = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.AssumedRelinquishedCareDates)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(assumedRelinquishedCareDates != null);
            Assert.IsFalse(assumedRelinquishedCareDates.HasValue);
            Assert.IsFalse(assumedRelinquishedCareDates.IsPresent);

            var propertyAndCasualtyDateOfFirstContact = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.PropertyAndCasualtyDateOfFirstContact)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(propertyAndCasualtyDateOfFirstContact != null);
            Assert.IsFalse(propertyAndCasualtyDateOfFirstContact.HasValue);
            Assert.IsFalse(propertyAndCasualtyDateOfFirstContact.IsPresent);

            var repricerReceivedDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.RepricerReceivedDate)
                .Select(x => x.DateTimeQualifier);
            
            Assume.That(repricerReceivedDate != null);
            Assert.IsFalse(repricerReceivedDate.HasValue);
            Assert.IsFalse(repricerReceivedDate.IsPresent);
        }
    }
}