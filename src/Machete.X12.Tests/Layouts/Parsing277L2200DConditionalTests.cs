namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing277L2200DConditionalTests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test(Description = "Condition : PatientControlNumber => EJ, InstitutionalTypeOfBill => BLT, MedicalRecordIdentificationNumber => EA, ClaimIdentificationNumber => D9")]
        public void Test1()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*SM123456
REF*BLT*111
REF*EA*111
REF*D9*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*SM123456
REF*BLT*111
REF*EA*111
REF*D9*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*SM123456
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";

            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var patientControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.PatientControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(patientControlNumber.HasValue);
            Assert.IsTrue(patientControlNumber.IsPresent);
            Assert.AreEqual("EJ", patientControlNumber.ValueOrDefault());

            var institutionalTypeOfBill = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.InstitutionalTypeOfBill)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(institutionalTypeOfBill.HasValue);
            Assert.IsTrue(institutionalTypeOfBill.IsPresent);
            Assert.AreEqual("BLT", institutionalTypeOfBill.ValueOrDefault());

            var medicalRecordIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.MedicalRecordIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(medicalRecordIdentificationNumber.HasValue);
            Assert.IsTrue(medicalRecordIdentificationNumber.IsPresent);
            Assert.AreEqual("EA", medicalRecordIdentificationNumber.ValueOrDefault());

            var claimIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(claimIdentificationNumber.HasValue);
            Assert.IsTrue(claimIdentificationNumber.IsPresent);
            Assert.AreEqual("D9", claimIdentificationNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : PatientControlNumber => EJ, InstitutionalTypeOfBill => missing, MedicalRecordIdentificationNumber => missing, ClaimIdentificationNumber => missing")]
        public void Test2()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*SM123456
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*JO234567
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*SM123456
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var patientControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.PatientControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(patientControlNumber.HasValue);
            Assert.IsTrue(patientControlNumber.IsPresent);
            Assert.AreEqual("EJ", patientControlNumber.ValueOrDefault());

            var institutionalTypeOfBill = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.InstitutionalTypeOfBill)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(institutionalTypeOfBill.HasValue);
            Assert.IsFalse(institutionalTypeOfBill.IsPresent);

            var medicalRecordIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.MedicalRecordIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(medicalRecordIdentificationNumber.HasValue);
            Assert.IsFalse(medicalRecordIdentificationNumber.IsPresent);

            var claimIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(claimIdentificationNumber.HasValue);
            Assert.IsFalse(claimIdentificationNumber.IsPresent);
        }
        
        [Test(Description = "Condition : PatientControlNumber => EJ, InstitutionalTypeOfBill => BLT, MedicalRecordIdentificationNumber => missing, ClaimIdentificationNumber => missing")]
        public void Test3()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*SM123456
REF*BLT*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*SM123456
REF*BLT*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*SM123456
REF*BLT*111
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var patientControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.PatientControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(patientControlNumber.HasValue);
            Assert.IsTrue(patientControlNumber.IsPresent);
            Assert.AreEqual("EJ", patientControlNumber.ValueOrDefault());

            var institutionalTypeOfBill = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.InstitutionalTypeOfBill)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(institutionalTypeOfBill.HasValue);
            Assert.IsTrue(institutionalTypeOfBill.IsPresent);
            Assert.AreEqual("BLT", institutionalTypeOfBill.ValueOrDefault());

            var medicalRecordIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.MedicalRecordIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(medicalRecordIdentificationNumber.HasValue);
            Assert.IsFalse(medicalRecordIdentificationNumber.IsPresent);

            var claimIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(claimIdentificationNumber.HasValue);
            Assert.IsFalse(claimIdentificationNumber.IsPresent);
        }
        
        [Test(Description = "Condition : PatientControlNumber => EJ, InstitutionalTypeOfBill => BLT, MedicalRecordIdentificationNumber => EA, ClaimIdentificationNumber => missing")]
        public void Test4()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*JO234567
REF*BLT*111
REF*EA*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*JO234567
REF*BLT*111
REF*EA*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*JO234567
REF*BLT*111
REF*EA*111
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var patientControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.PatientControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(patientControlNumber.HasValue);
            Assert.IsTrue(patientControlNumber.IsPresent);
            Assert.AreEqual("EJ", patientControlNumber.ValueOrDefault());

            var institutionalTypeOfBill = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.InstitutionalTypeOfBill)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(institutionalTypeOfBill.HasValue);
            Assert.IsTrue(institutionalTypeOfBill.IsPresent);
            Assert.AreEqual("BLT", institutionalTypeOfBill.ValueOrDefault());

            var medicalRecordIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.MedicalRecordIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(medicalRecordIdentificationNumber.HasValue);
            Assert.IsTrue(medicalRecordIdentificationNumber.IsPresent);
            Assert.AreEqual("EA", medicalRecordIdentificationNumber.ValueOrDefault());

            var claimIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(claimIdentificationNumber.HasValue);
            Assert.IsFalse(claimIdentificationNumber.IsPresent);
        }
        
        [Test(Description = "Condition : PatientControlNumber => EJ, InstitutionalTypeOfBill => BLT, MedicalRecordIdentificationNumber => missing, ClaimIdentificationNumber => D9")]
        public void Test5()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*JO234567
REF*BLT*111
REF*D9*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*JO234567
REF*BLT*111
REF*D9*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*JO234567
REF*BLT*111
REF*D9*111
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var patientControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.PatientControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(patientControlNumber.HasValue);
            Assert.IsTrue(patientControlNumber.IsPresent);
            Assert.AreEqual("EJ", patientControlNumber.ValueOrDefault());

            var institutionalTypeOfBill = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.InstitutionalTypeOfBill)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(institutionalTypeOfBill.HasValue);
            Assert.IsTrue(institutionalTypeOfBill.IsPresent);
            Assert.AreEqual("BLT", institutionalTypeOfBill.ValueOrDefault());

            var medicalRecordIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.MedicalRecordIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(medicalRecordIdentificationNumber.HasValue);
            Assert.IsFalse(medicalRecordIdentificationNumber.IsPresent);

            var claimIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(claimIdentificationNumber.HasValue);
            Assert.IsTrue(claimIdentificationNumber.IsPresent);
            Assert.AreEqual("D9", claimIdentificationNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : PatientControlNumber => EJ, InstitutionalTypeOfBill => missing, MedicalRecordIdentificationNumber => EA, ClaimIdentificationNumber => D9")]
        public void Test6()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*JO234567
REF*EA*111
REF*D9*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*JO234567
REF*EA*111
REF*D9*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*JO234567
REF*EA*111
REF*D9*111
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var patientControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.PatientControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(patientControlNumber.HasValue);
            Assert.IsTrue(patientControlNumber.IsPresent);
            Assert.AreEqual("EJ", patientControlNumber.ValueOrDefault());

            var institutionalTypeOfBill = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.InstitutionalTypeOfBill)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(institutionalTypeOfBill.HasValue);
            Assert.IsFalse(institutionalTypeOfBill.IsPresent);

            var medicalRecordIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.MedicalRecordIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(medicalRecordIdentificationNumber.HasValue);
            Assert.IsTrue(medicalRecordIdentificationNumber.IsPresent);
            Assert.AreEqual("EA", medicalRecordIdentificationNumber.ValueOrDefault());

            var claimIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(claimIdentificationNumber.HasValue);
            Assert.IsTrue(claimIdentificationNumber.IsPresent);
            Assert.AreEqual("D9", claimIdentificationNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : PatientControlNumber => EJ, InstitutionalTypeOfBill => missing, MedicalRecordIdentificationNumber => missing, ClaimIdentificationNumber => D9")]
        public void Test7()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*JO234567
REF*D9*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*JO234567
REF*D9*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*JO234567
REF*D9*111
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var patientControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.PatientControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(patientControlNumber.HasValue);
            Assert.IsTrue(patientControlNumber.IsPresent);
            Assert.AreEqual("EJ", patientControlNumber.ValueOrDefault());

            var institutionalTypeOfBill = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.InstitutionalTypeOfBill)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(institutionalTypeOfBill.HasValue);
            Assert.IsFalse(institutionalTypeOfBill.IsPresent);

            var medicalRecordIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.MedicalRecordIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(medicalRecordIdentificationNumber.HasValue);
            Assert.IsFalse(medicalRecordIdentificationNumber.IsPresent);

            var claimIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(claimIdentificationNumber.HasValue);
            Assert.IsTrue(claimIdentificationNumber.IsPresent);
            Assert.AreEqual("D9", claimIdentificationNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : PatientControlNumber => EJ, InstitutionalTypeOfBill => missing, MedicalRecordIdentificationNumber => EA, ClaimIdentificationNumber => missing")]
        public void Test8()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*JO234567
REF*EA*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*JO234567
REF*EA*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*JO234567
REF*EA*111
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var patientControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.PatientControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(patientControlNumber.HasValue);
            Assert.IsTrue(patientControlNumber.IsPresent);
            Assert.AreEqual("EJ", patientControlNumber.ValueOrDefault());

            var institutionalTypeOfBill = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.InstitutionalTypeOfBill)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(institutionalTypeOfBill.HasValue);
            Assert.IsFalse(institutionalTypeOfBill.IsPresent);

            var medicalRecordIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.MedicalRecordIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(medicalRecordIdentificationNumber.HasValue);
            Assert.IsTrue(medicalRecordIdentificationNumber.IsPresent);
            Assert.AreEqual("EA", medicalRecordIdentificationNumber.ValueOrDefault());

            var claimIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(claimIdentificationNumber.HasValue);
            Assert.IsFalse(claimIdentificationNumber.IsPresent);
        }
        
        [Test(Description = "Condition : PatientControlNumber => EJ, InstitutionalTypeOfBill => missing, MedicalRecordIdentificationNumber => missing, ClaimIdentificationNumber => missing")]
        public void Test9()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EJ*SM123456
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EJ*JO234567
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EJ*SM123456
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var patientControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.PatientControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(patientControlNumber.HasValue);
            Assert.IsTrue(patientControlNumber.IsPresent);
            Assert.AreEqual("EJ", patientControlNumber.ValueOrDefault());

            var institutionalTypeOfBill = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.InstitutionalTypeOfBill)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(institutionalTypeOfBill.HasValue);
            Assert.IsFalse(institutionalTypeOfBill.IsPresent);

            var medicalRecordIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.MedicalRecordIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(medicalRecordIdentificationNumber.HasValue);
            Assert.IsFalse(medicalRecordIdentificationNumber.IsPresent);

            var claimIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(claimIdentificationNumber.HasValue);
            Assert.IsFalse(claimIdentificationNumber.IsPresent);
        }
        
        [Test(Description = "Condition : PatientControlNumber => missing, InstitutionalTypeOfBill => BLT, MedicalRecordIdentificationNumber => EA, ClaimIdentificationNumber => D9")]
        public void Test10()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*BLT*111
REF*EA*111
REF*D9*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*BLT*111
REF*EA*111
REF*D9*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*BLT*111
REF*EA*111
REF*D9*111
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var patientControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.PatientControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(patientControlNumber.HasValue);
            Assert.IsFalse(patientControlNumber.IsPresent);

            var institutionalTypeOfBill = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.InstitutionalTypeOfBill)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(institutionalTypeOfBill.HasValue);
            Assert.IsTrue(institutionalTypeOfBill.IsPresent);
            Assert.AreEqual("BLT", institutionalTypeOfBill.ValueOrDefault());

            var medicalRecordIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.MedicalRecordIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(medicalRecordIdentificationNumber.HasValue);
            Assert.IsTrue(medicalRecordIdentificationNumber.IsPresent);
            Assert.AreEqual("EA", medicalRecordIdentificationNumber.ValueOrDefault());

            var claimIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(claimIdentificationNumber.HasValue);
            Assert.IsTrue(claimIdentificationNumber.IsPresent);
            Assert.AreEqual("D9", claimIdentificationNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : PatientControlNumber => missing, InstitutionalTypeOfBill => missing, MedicalRecordIdentificationNumber => EA, ClaimIdentificationNumber => D9")]
        public void Test11()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*EA*111
REF*D9*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*EA*111
REF*D9*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*EA*111
REF*D9*111
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var patientControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.PatientControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(patientControlNumber.HasValue);
            Assert.IsFalse(patientControlNumber.IsPresent);

            var institutionalTypeOfBill = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.InstitutionalTypeOfBill)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(institutionalTypeOfBill.HasValue);
            Assert.IsFalse(institutionalTypeOfBill.IsPresent);

            var medicalRecordIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.MedicalRecordIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(medicalRecordIdentificationNumber.HasValue);
            Assert.IsTrue(medicalRecordIdentificationNumber.IsPresent);
            Assert.AreEqual("EA", medicalRecordIdentificationNumber.ValueOrDefault());

            var claimIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(claimIdentificationNumber.HasValue);
            Assert.IsTrue(claimIdentificationNumber.IsPresent);
            Assert.AreEqual("D9", claimIdentificationNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : PatientControlNumber => missing, InstitutionalTypeOfBill => missing, MedicalRecordIdentificationNumber => missing, ClaimIdentificationNumber => D9")]
        public void Test12()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*D9*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*D9*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*D9*111
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var patientControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.PatientControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(patientControlNumber.HasValue);
            Assert.IsFalse(patientControlNumber.IsPresent);

            var institutionalTypeOfBill = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.InstitutionalTypeOfBill)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(institutionalTypeOfBill.HasValue);
            Assert.IsFalse(institutionalTypeOfBill.IsPresent);

            var medicalRecordIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.MedicalRecordIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(medicalRecordIdentificationNumber.HasValue);
            Assert.IsFalse(medicalRecordIdentificationNumber.IsPresent);

            var claimIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(claimIdentificationNumber.HasValue);
            Assert.IsTrue(claimIdentificationNumber.IsPresent);
            Assert.AreEqual("D9", claimIdentificationNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : PatientControlNumber => missing, InstitutionalTypeOfBill => missing, MedicalRecordIdentificationNumber => missing, ClaimIdentificationNumber => missing")]
        public void Test13()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var patientControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.PatientControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(patientControlNumber.HasValue);
            Assert.IsFalse(patientControlNumber.IsPresent);

            var institutionalTypeOfBill = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.InstitutionalTypeOfBill)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(institutionalTypeOfBill.HasValue);
            Assert.IsFalse(institutionalTypeOfBill.IsPresent);

            var medicalRecordIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.MedicalRecordIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(medicalRecordIdentificationNumber.HasValue);
            Assert.IsFalse(medicalRecordIdentificationNumber.IsPresent);

            var claimIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(claimIdentificationNumber.HasValue);
            Assert.IsFalse(claimIdentificationNumber.IsPresent);
        }
        
        [Test(Description = "Condition : PatientControlNumber => missing, InstitutionalTypeOfBill => BLT, MedicalRecordIdentificationNumber => EA, ClaimIdentificationNumber => missing")]
        public void Test14()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*BLT*SM123456
REF*EA*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*BLT*SM123456
REF*EA*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*BLT*SM123456
REF*EA*111
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var patientControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.PatientControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(patientControlNumber.HasValue);
            Assert.IsFalse(patientControlNumber.IsPresent);

            var institutionalTypeOfBill = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.InstitutionalTypeOfBill)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(institutionalTypeOfBill.HasValue);
            Assert.IsTrue(institutionalTypeOfBill.IsPresent);
            Assert.AreEqual("BLT", institutionalTypeOfBill.ValueOrDefault());

            var medicalRecordIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.MedicalRecordIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(medicalRecordIdentificationNumber.HasValue);
            Assert.IsTrue(medicalRecordIdentificationNumber.IsPresent);
            Assert.AreEqual("EA", medicalRecordIdentificationNumber.ValueOrDefault());

            var claimIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(claimIdentificationNumber.HasValue);
            Assert.IsFalse(claimIdentificationNumber.IsPresent);
        }
        
        [Test(Description = "Condition : PatientControlNumber => missing, InstitutionalTypeOfBill => BLT, MedicalRecordIdentificationNumber => missing, ClaimIdentificationNumber => D9")]
        public void Test15()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*BLT*111
REF*D9*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*BLT*111
REF*D9*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*BLT*111
REF*D9*111
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var patientControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.PatientControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(patientControlNumber.HasValue);
            Assert.IsFalse(patientControlNumber.IsPresent);

            var institutionalTypeOfBill = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.InstitutionalTypeOfBill)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(institutionalTypeOfBill.HasValue);
            Assert.IsTrue(institutionalTypeOfBill.IsPresent);
            Assert.AreEqual("BLT", institutionalTypeOfBill.ValueOrDefault());

            var medicalRecordIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.MedicalRecordIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(medicalRecordIdentificationNumber.HasValue);
            Assert.IsFalse(medicalRecordIdentificationNumber.IsPresent);

            var claimIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(claimIdentificationNumber.HasValue);
            Assert.IsTrue(claimIdentificationNumber.IsPresent);
            Assert.AreEqual("D9", claimIdentificationNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : PatientControlNumber => missing, InstitutionalTypeOfBill => BLT, MedicalRecordIdentificationNumber => missing, ClaimIdentificationNumber => missing")]
        public void Test16()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*BLT*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*BLT*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*BLT*111
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var patientControlNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.PatientControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(patientControlNumber.HasValue);
            Assert.IsFalse(patientControlNumber.IsPresent);

            var institutionalTypeOfBill = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.InstitutionalTypeOfBill)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(institutionalTypeOfBill.HasValue);
            Assert.IsTrue(institutionalTypeOfBill.IsPresent);
            Assert.AreEqual("BLT", institutionalTypeOfBill.ValueOrDefault());

            var medicalRecordIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.MedicalRecordIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(medicalRecordIdentificationNumber.HasValue);
            Assert.IsFalse(medicalRecordIdentificationNumber.IsPresent);

            var claimIdentificationNumber = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimIdentificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(claimIdentificationNumber.HasValue);
            Assert.IsFalse(claimIdentificationNumber.IsPresent);
        }
        
        [Test(Description = "Condition : ClaimServiceDate => 472, ResponseDueDate => 106")]
        public void Test17()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*BLT*111
DTP*472*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*BLT*111
DTP*472*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*BLT*111
DTP*472*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var claimServiceDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimServiceDate)
                .Select(x => x.DateTimeQualifier);
            
            Assert.IsTrue(claimServiceDate.HasValue);
            Assert.IsTrue(claimServiceDate.IsPresent);
            Assert.AreEqual("472", claimServiceDate.ValueOrDefault());

            var responseDueDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ResponseDueDate)
                .Select(x => x.DateTimeQualifier);
            
            Assert.IsTrue(responseDueDate.HasValue);
            Assert.IsTrue(responseDueDate.IsPresent);
            Assert.AreEqual("106", responseDueDate.ValueOrDefault());
        }
        
        [Test(Description = "Condition : ClaimServiceDate => unknown, ResponseDueDate => 106")]
        public void Test18()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*BLT*111
DTP*050*RD8*20070131-20070204
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*BLT*111
DTP*050*RD8*20070201-20070205
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*BLT*111
DTP*050*D8*20070201
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsFalse(transactions.HasValue);
        }
        
        [Test(Description = "Condition : ClaimServiceDate => 472, ResponseDueDate => unknown")]
        public void Test19()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*BLT*111
DTP*472*RD8*20070131-20070204
DTP*050*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*BLT*111
DTP*472*RD8*20070201-20070205
DTP*050*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*BLT*111
DTP*472*D8*20070201
DTP*050*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsFalse(transactions.HasValue);
        }
        
        [Test(Description = "Condition : ClaimServiceDate => 472, ResponseDueDate => missing")]
        public void Test20()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*BLT*111
DTP*472*RD8*20070131-20070204
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*BLT*111
DTP*472*RD8*20070201-20070205
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*BLT*111
DTP*472*D8*20070201
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var claimServiceDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimServiceDate)
                .Select(x => x.DateTimeQualifier);
            
            Assert.IsTrue(claimServiceDate.HasValue);
            Assert.IsTrue(claimServiceDate.IsPresent);
            Assert.AreEqual("472", claimServiceDate.ValueOrDefault());

            var responseDueDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ResponseDueDate)
                .Select(x => x.DateTimeQualifier);
            
            Assert.IsFalse(responseDueDate.HasValue);
            Assert.IsFalse(responseDueDate.IsPresent);
        }
        
        [Test(Description = "Condition : ClaimServiceDate => missing, ResponseDueDate => 106")]
        public void Test21()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*BLT*111
DTP*106*D8*20070206
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*BLT*111
DTP*106*D8*20070206
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*BLT*111
DTP*106*D8*20070206
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var claimServiceDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimServiceDate)
                .Select(x => x.DateTimeQualifier);
            
            Assert.IsFalse(claimServiceDate.HasValue);
            Assert.IsFalse(claimServiceDate.IsPresent);

            var responseDueDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ResponseDueDate)
                .Select(x => x.DateTimeQualifier);
            
            Assert.IsTrue(responseDueDate.HasValue);
            Assert.IsTrue(responseDueDate.IsPresent);
            Assert.AreEqual("106", responseDueDate.ValueOrDefault());
        }
        
        [Test(Description = "Condition : ClaimServiceDate => missing, ResponseDueDate => missing")]
        public void Test22()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*277*0001*005010X228
BHT*0085*08*277PEND123*20070210*1635*NO
HL*1**20*1
NM1*PR*2*ABC INSURANCE*****PI*12345
HL*2*1*21*1
NM1*41*2*XYZ SERVICE*****46*X67E
HL*3*2*19*1
NM1*1P*2*HOME HOSPITAL*****XX*1666666661
HL*4*3*PT
NM1*QC*1*SMITH*FRED****MI*123456789A
TRN*1*05347006051
STC*P3:317*20070208**8513.88
REF*BLT*111
HL*5*3*PT
NM1*QC*1*JONES*MARY****MI*234567890A
TRN*1*0529675341
STC*P1:20*20070210**7599
REF*BLT*111
HL*7*6*PT
NM1*QC*1*MANN*JOSEPH****MI*345678901
TRN*1*051681010827
STC*P2:247*20070208**150
REF*BLT*111
SE*35*0001
GE*1*1
IEA*1*176073292";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HISN277, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transactions)[0];
            
            Assert.IsTrue(transactions.HasValue);

            var claimServiceDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ClaimServiceDate)
                .Select(x => x.DateTimeQualifier);
            
            Assert.IsFalse(claimServiceDate.HasValue);
            Assert.IsFalse(claimServiceDate.IsPresent);

            var responseDueDate = transactions
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.PayerClaimControlNumber)[0]
                .Select(x => x.ResponseDueDate)
                .Select(x => x.DateTimeQualifier);
            
            Assert.IsFalse(responseDueDate.HasValue);
            Assert.IsFalse(responseDueDate.IsPresent);
        }
    }
}