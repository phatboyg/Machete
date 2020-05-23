namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Layout2000CTests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test]
        public void Test1()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*123456789012345*ZZ*123456789012346*061015*1705*>*00501*041300304*0*T*:~
GS*HC*1234567890*9876543210*20061015*1705*0413104*X*005010X222A1~
ST*837*0021*005010X222A1~
BHT*0019*00*0413104*20061015*1023*RP~
NM1*41*2*PREMIER BILLING SERVICE*****46*TGJ23~
PER*IC*JERRY*TE*3055552222*EX*231~
NM1*40*2*AHLIC*****46*66783JJT~
HL*1**20*1~
PRV*BI*PXC*203BF0100Y~
NM1*85*2*BEN KILDARE SERVICE*****XX*9876543210~
N3*234 SEAWAY ST~
N4*MIAMI*FL*33111~
REF*EI*587654321~
NM1*87*2~
N3*2345 OCEAN BLVD~
N4*MIAMI*FL*33111~
HL*2*1*22*0~
SBR*P*18*12312-A******HM~
NM1*IL*1*SMITH*TEDDY****MI*00221111~
N3*236 N MAIN ST~
N4*MIAMI*FL*33413~
DMG*D8*19430501*M~
NM1*PR*2*ALLIANCE HEALTH AND LIFE INSURANCE*****PI*741234~
CLM*26462967*100***11:B:1*Y*A*Y*I~
DTP*431*D8*19981003~
REF*EA*439866~
REF*D9*17312345600006351~
HI*BK:0340*BF:V7389~
NM1*77*2*KILDARE ASSOCIATES*****XX*5812345679~
N3*2345 OCEAN BLVD~
N4*MIAMI*FL*33111~
LX*1~
SV1*HC:99213*40*UN*1***1~
DTP*472*D8*20061003~
LX*2~
SV1*HC:87072*15*UN*1***1~
DTP*472*D8*20061003~
LX*3~
SV1*HC:99214*35*UN*1***2~
DTP*472*D8*20061010~
LX*4~
SV1*HC:86663*10*UN*1***2~
DTP*472*D8*20061010~
SE*42*0021~
GE*1*0413104~
IEA*1*041300304~";

            var entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);

            string mrn = queryResult
                .Select(x => x.Transactions)[0]
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.MedicalRecordNumber)
                .Select(x => x.ReferenceIdentification)
                .ValueOrDefault();
            
            Assert.AreEqual("439866", mrn);
        }

        [Test]
        public void Test2()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*123456789012345*ZZ*123456789012346*061015*1705*>*00501*041300304*0*T*:~
GS*HC*1234567890*9876543210*20061015*1705*0413104*X*005010X222A1~
ST*837*0021*005010X222A1~
BHT*0019*00*0413104*20061015*1023*RP~
NM1*41*2*PREMIER BILLING SERVICE*****46*TGJ23~
PER*IC*JERRY*TE*3055552222*EX*231~
NM1*40*2*AHLIC*****46*66783JJT~
HL*1**20*1~
PRV*BI*PXC*203BF0100Y~
NM1*85*2*BEN KILDARE SERVICE*****XX*9876543210~
N3*234 SEAWAY ST~
N4*MIAMI*FL*33111~
REF*EI*587654321~
NM1*87*2~
N3*2345 OCEAN BLVD~
N4*MIAMI*FL*33111~
HL*2*1*22*0~
SBR*P*18*12312-A******HM~
NM1*IL*1*SMITH*TEDDY****MI*00221111~
N3*236 N MAIN ST~
N4*MIAMI*FL*33413~
DMG*D8*19430501*M~
NM1*PR*2*ALLIANCE HEALTH AND LIFE INSURANCE*****PI*741234~
CLM*26462967*100***11:B:1*Y*A*Y*I~
DTP*431*D8*19981003~
REF*EA*439866~
REF*D9*17312345600006351~
HI*BK:0340*BF:V7389~
NM1*77*2*KILDARE ASSOCIATES*****XX*5812345679~
N3*2345 OCEAN BLVD~
N4*MIAMI*FL*33111~
LX*1~
SV1*HC:99213*40*UN*1***1~
DTP*472*D8*20061003~
LX*2~
SV1*HC:87072*15*UN*1***1~
DTP*472*D8*20061003~
LX*3~
SV1*HC:99214*35*UN*1***2~
DTP*472*D8*20061010~
LX*4~
SV1*HC:86663*10*UN*1***2~
DTP*472*D8*20061010~
SE*42*0021~
GE*1*0413104~
IEA*1*041300304~";

            var entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837I, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);

            string mrn = queryResult
                .Select(x => x.Transactions)[0]
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimInformation)[0]
                .Select(x => x.MedicalRecordNumber)
                .Select(x => x.ReferenceIdentification)
                .ValueOrDefault();
            
            Assert.AreEqual("439866", mrn);
        }
    }
}