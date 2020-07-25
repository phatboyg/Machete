namespace Machete.X12.Tests
{
    using System;
    using System.Linq;
    using Configuration;
    using NUnit.Framework;
    using TestSchema;
    using X12Schema.V5010;
    using X12Schema.V5010.Maps;


    [TestFixture]
    public class SpecificationRegistrationTests
    {
        [Test]
        public void Test1()
        {
            var schema = CreateSchema2();
            
            schema.GetRegisteredLayouts().ToList().ForEach(x => Console.WriteLine(x.FullName));
        }

        [Test]
        public void Test3()
        {
            var schema = CreateSchema3();
            var parser = Parser.Factory.CreateX12(schema);
            
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
DTP*296*D8*20061109
DTP*435*D8*20061109
DTP*096*D8*20061109
DTP*090*D8*20061109
DTP*444*D8*20061109
DTP*050*D8*20061109
REF*4N*111222333444
REF*F5*111222333444
REF*EW*111222333444
REF*9F*111222333444
REF*G1*111222333444
REF*F8*111222333444
REF*X4*111222333444
REF*9A*111222333444
REF*9C*111222333444
REF*LX*111222333444
REF*D9*111222333444
REF*EA*111222333444
REF*P4*111222333444
REF*1J*111222333444
NM1*82*1*KILDARE*BEN****XX*6789012345
PRV*PE*PXC*1223P0221X
LX*1
SV3*AD:D3320*200****1
TOO*JP*5
SE*29*0002
IEA*1*176073292";

            var entityResult = parser.Parse(message);

            Assert.IsTrue(schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);

            var transactions = queryResult.Select(x => x.Transaction)[0];

            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var serviceAuthorizationExceptionCode = transactions
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.ServiceAuthorizationExceptionCode)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(serviceAuthorizationExceptionCode != null);
            Assert.IsTrue(serviceAuthorizationExceptionCode.HasValue);
            Assert.IsTrue(serviceAuthorizationExceptionCode.IsPresent);
            Assert.AreEqual("4N", serviceAuthorizationExceptionCode.ValueOrDefault());

            var mandatoryMedicareCrossoverIndicator = transactions
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.MandatoryMedicareCrossoverIndicator)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(mandatoryMedicareCrossoverIndicator != null);
            Assert.IsTrue(mandatoryMedicareCrossoverIndicator.HasValue);
            Assert.IsTrue(mandatoryMedicareCrossoverIndicator.IsPresent);
            Assert.AreEqual("F5", mandatoryMedicareCrossoverIndicator.ValueOrDefault());

            var mammographyCertificationNumber = transactions
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.MammographyCertificationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(mammographyCertificationNumber != null);
            Assert.IsTrue(mammographyCertificationNumber.HasValue);
            Assert.IsTrue(mammographyCertificationNumber.IsPresent);
            Assert.AreEqual("EW", mammographyCertificationNumber.ValueOrDefault());

            var referralNumber = transactions
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.ReferralNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(referralNumber != null);
            Assert.IsTrue(referralNumber.HasValue);
            Assert.IsTrue(referralNumber.IsPresent);
            Assert.AreEqual("9F", referralNumber.ValueOrDefault());

            var priorAuthorization = transactions
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.PriorAuthorization)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(priorAuthorization != null);
            Assert.IsTrue(priorAuthorization.HasValue);
            Assert.IsTrue(priorAuthorization.IsPresent);
            Assert.AreEqual("G1", priorAuthorization.ValueOrDefault());

            var payerClaimControlNumber = transactions
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.PayerClaimControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(payerClaimControlNumber != null);
            Assert.IsTrue(payerClaimControlNumber.HasValue);
            Assert.IsTrue(payerClaimControlNumber.IsPresent);
            Assert.AreEqual("F8", payerClaimControlNumber.ValueOrDefault());

            var cliaNumber = transactions
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.CLIANumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(cliaNumber != null);
            Assert.IsTrue(cliaNumber.HasValue);
            Assert.IsTrue(cliaNumber.IsPresent);
            Assert.AreEqual("X4", cliaNumber.ValueOrDefault());

            var repricedClaimNumber = transactions
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.RepricedClaimNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(repricedClaimNumber != null);
            Assert.IsTrue(repricedClaimNumber.HasValue);
            Assert.IsTrue(repricedClaimNumber.IsPresent);
            Assert.AreEqual("9A", repricedClaimNumber.ValueOrDefault());

            var adjustedRepricedClaimNumber = transactions
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.AdjustedRepricedClaimNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(adjustedRepricedClaimNumber != null);
            Assert.IsTrue(adjustedRepricedClaimNumber.HasValue);
            Assert.IsTrue(adjustedRepricedClaimNumber.IsPresent);
            Assert.AreEqual("9C", adjustedRepricedClaimNumber.ValueOrDefault());

            var investigationalDeviceExemptionNumber = transactions
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.InvestigationalDeviceExemptionNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(investigationalDeviceExemptionNumber != null);
            Assert.IsTrue(investigationalDeviceExemptionNumber.HasValue);
            Assert.IsTrue(investigationalDeviceExemptionNumber.IsPresent);
            Assert.AreEqual("LX", investigationalDeviceExemptionNumber.ValueOrDefault());

            var claimIdentifierForTransmissionIntermediaries = transactions
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.ClaimIdentifierForTransmissionIntermediaries)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(claimIdentifierForTransmissionIntermediaries != null);
            Assert.IsTrue(claimIdentifierForTransmissionIntermediaries.HasValue);
            Assert.IsTrue(claimIdentifierForTransmissionIntermediaries.IsPresent);
            Assert.AreEqual("D9", claimIdentifierForTransmissionIntermediaries.ValueOrDefault());

            var medicalRecordNumber = transactions
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.MedicalRecordNumber)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(medicalRecordNumber != null);
            Assert.IsTrue(medicalRecordNumber.HasValue);
            Assert.IsTrue(medicalRecordNumber.IsPresent);
            Assert.AreEqual("EA", medicalRecordNumber.ValueOrDefault());

            var demonstrationProjectIdentifier = transactions
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.DemonstrationProjectIdentifier)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(demonstrationProjectIdentifier != null);
            Assert.IsTrue(demonstrationProjectIdentifier.HasValue);
            Assert.IsTrue(demonstrationProjectIdentifier.IsPresent);
            Assert.AreEqual("P4", demonstrationProjectIdentifier.ValueOrDefault());

            var carePlanOversight = transactions
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.CarePlanOversight)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assume.That(carePlanOversight != null);
            Assert.IsTrue(carePlanOversight.HasValue);
            Assert.IsTrue(carePlanOversight.IsPresent);
            Assert.AreEqual("1J", carePlanOversight.ValueOrDefault());
        }
        
        ISchema<X12Entity> CreateSchema1()
        {
            return Machete.Schema.Factory.CreateX12<X12Entity>(cfg =>
            {
                cfg.AddFromNamespaceContaining<X12v5010>();
                cfg.AddFromNamespaceContaining<TestSpec>();
            });
        }
        
        ISchema<X12Entity> CreateSchema2()
        {
            return Machete.Schema.Factory.CreateX12<X12Entity>(cfg =>
            {
                cfg.AddFromNamespaceContaining<X12v5010>();
                cfg.Add(new TestX12LayoutMap());
            });
        }
        
        ISchema<X12Entity> CreateSchema3()
        {
            return Machete.Schema.Factory.CreateX12<X12Entity>(cfg =>
            {
                cfg.AddFromNamespaceContaining<X12v5010>();
                cfg.Override(new MyREFMap());
            });
        }
        
        class MyREFMap :
            X12SegmentMap<REF, X12Entity>
        {
            public MyREFMap()
            {
                Id = "REF";
                Name = "Reference Identification";
            
                Value(x => x.ReferenceIdentificationQualifier, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            }
        }
    }
}