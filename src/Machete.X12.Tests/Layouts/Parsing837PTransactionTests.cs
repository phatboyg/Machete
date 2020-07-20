namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing837PTransactionTests :
        X12MacheteTestHarness<X12v5010, X12Entity>
    {
        [Test]
        public void Can_parse_loop_2010BA_when_loops_2010AB_and_2010AC_missing()
        {
            const string message =
                @"ISA*00*          *00*          *ZZ*123456789012345*ZZ*123456789012346*061015*1705*>*00501*000010216*0*T*:~
GS*HC*1234567890*9876543210*20061015*1705*20213*X*005010X222A1~
ST*837*000017712*005010X222A1~
BHT*0019*00*000017712*20050208*1112*CH~
NM1*41*2*AAA AMBULANCE SERVICE*****46*376985369~
PER*IC*LISA SMITH*TE*3037752536~
NM1*40*2*MEDICARE B*****46*123245~
HL*1**20*1~
PRV*BI*PXC*3416L0300X~
NM1*85*2*AAA AMBULANCE SERVICE*****XX*2366554859~
N3*12202 AIRPORT WAY~
N4*BROOMFIELD*CO*800210021~
REF*EI*376985369~
HL*2*1*22*0~
SBR*P*18*******MB~
NM1*IL*1*JONES*SARAH*A***MI*012345678A~
N3*1129 REINDEER ROAD~
N4*CARR*CO*80612~
DMG*D8*19630729*F~
NM1*PR*2*MEDICARE PART B*****PI*123245~
N3*PO BOX 3543~
N4*BALTIMORE*MD*666013543~
CLM*051068*766.50***41:B:1*Y*A*Y*Y*P*OA~
DTP*439*D8*20050208~
CR1*LB*275**A*DH*21****PATIENT IMOBILIZED~
CRC*07*Y*04*06*09~
CRC*07*N*05*07*08~
HI*BK:8628*BF:E8888*BF:9592*BF:8540~
NM1*PW*2~
N3*1129 REINDEER ROAD~
N4*CARR*CO*80612~
NM1*45*2~
N3*10005 BANNOCK ST~
N4*CHEYENNE*WY*82009~
LX*1~
SV1*HC:A0427:RH*700*UN*1***1:2:3:4**Y~
DTP*472*D8*20050208~
QTY*PT*2~
REF*6R*1001~
NTE*ADD*CARDIAC EMERGENCY~
LX*2~
SV1*HC:A0425:RH*8.20*UN*21***1:2:3:4**Y~
DTP*472*D8*20050208~
QTY*PT*2~
REF*6R*1002~
LX*3~
SV1*HC:A0422:RH*46*UN*1***1:2:3:4**Y~
DTP*472*D8*20050208~
REF*6R*1003~
LX*4~
SV1*HC:A0382:RH*12.30*UN*1***1:2:3:4**Y~
DTP*472*D8*20050208~
REF*6R*1004~SE*52*000017712~
GE*1*20213~
IEA*1*000010216~";
 
            var parsed = Parser.Parse(message);
            
            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = parsed.CreateQuery(layout);

            var queryResult = parsed.Query(query);

            var genderCode = queryResult
                .Select(x => x.Transactions)[0]
                .Select(x => x.Loop2000B)[0]
                .Select(x => x.Loop2010BA)
                .Select(x => x.DemographicInformation)
                .Select(x => x.GenderCode)
                .ValueOrDefault();

            Assert.AreEqual("F", genderCode);
        }

        [Test]
        public void Can_parse_loop_2010BA_when_loop_2010AB_and_2010AC_missing()
        {
            const string message =
                @"ISA*00*          *00*          *ZZ*123456789012345*ZZ*123456789012346*061015*1705*>*00501*000010216*0*T*:~
GS*HC*1234567890*9876543210*20061015*1705*20213*X*005010X222A1~
ST*837*000017712*005010X222A1~
BHT*0019*00*000017712*20050208*1112*CH~
NM1*41*2*AAA AMBULANCE SERVICE*****46*376985369~
PER*IC*LISA SMITH*TE*3037752536~
NM1*40*2*MEDICARE B*****46*123245~
HL*1**20*1~
PRV*BI*PXC*3416L0300X~
NM1*85*2*AAA AMBULANCE SERVICE*****XX*2366554859~
N3*12202 AIRPORT WAY~
N4*BROOMFIELD*CO*800210021~
REF*EI*376985369~
NM1*87*2~
N3*2345 OCEAN BLVD~
N4*MIAMI*FL*33111~
HL*2*1*22*0~
SBR*P*18*******MB~
NM1*IL*1*JONES*SARAH*A***MI*012345678A~
N3*1129 REINDEER ROAD~
N4*CARR*CO*80612~
DMG*D8*19630729*F~
NM1*PR*2*MEDICARE PART B*****PI*123245~
N3*PO BOX 3543~
N4*BALTIMORE*MD*666013543~
CLM*051068*766.50***41:B:1*Y*A*Y*Y*P*OA~
DTP*439*D8*20050208~
CR1*LB*275**A*DH*21****PATIENT IMOBILIZED~
CRC*07*Y*04*06*09~
CRC*07*N*05*07*08~
HI*BK:8628*BF:E8888*BF:9592*BF:8540~
NM1*PW*2~
N3*1129 REINDEER ROAD~
N4*CARR*CO*80612~
NM1*45*2~
N3*10005 BANNOCK ST~
N4*CHEYENNE*WY*82009~
LX*1~
SV1*HC:A0427:RH*700*UN*1***1:2:3:4**Y~
DTP*472*D8*20050208~
QTY*PT*2~
REF*6R*1001~
NTE*ADD*CARDIAC EMERGENCY~
LX*2~
SV1*HC:A0425:RH*8.20*UN*21***1:2:3:4**Y~
DTP*472*D8*20050208~
QTY*PT*2~
REF*6R*1002~
LX*3~
SV1*HC:A0422:RH*46*UN*1***1:2:3:4**Y~
DTP*472*D8*20050208~
REF*6R*1003~
LX*4~
SV1*HC:A0382:RH*12.30*UN*1***1:2:3:4**Y~
DTP*472*D8*20050208~
REF*6R*1004~SE*52*000017712~
GE*1*20213~
IEA*1*000010216~";
 
            var parsed = Parser.Parse(message);
            
            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = parsed.CreateQuery(layout);

            var queryResult = parsed.Query(query);

            var genderCode = queryResult
                .Select(x => x.Transactions)[0]
                .Select(x => x.Loop2000B)[0]
                .Select(x => x.Loop2010BA)
                .Select(x => x.DemographicInformation)
                .Select(x => x.GenderCode)
                .ValueOrDefault();

            Assert.AreEqual("F", genderCode);
        }

        [Test]
        public void Can_parse_loop_2010BA_when_loop_2010AC_and_2010AB_missing()
        {
            const string message =
                @"ISA*00*          *00*          *ZZ*123456789012345*ZZ*123456789012346*061015*1705*>*00501*000010216*0*T*:~
GS*HC*1234567890*9876543210*20061015*1705*20213*X*005010X222A1~
ST*837*000017712*005010X222A1~
BHT*0019*00*000017712*20050208*1112*CH~
NM1*41*2*AAA AMBULANCE SERVICE*****46*376985369~
PER*IC*LISA SMITH*TE*3037752536~
NM1*40*2*MEDICARE B*****46*123245~
HL*1**20*1~
PRV*BI*PXC*3416L0300X~
NM1*85*2*AAA AMBULANCE SERVICE*****XX*2366554859~
N3*12202 AIRPORT WAY~
N4*BROOMFIELD*CO*800210021~
REF*EI*376985369~
NM1*PE*2~
N3*2345 OCEAN BLVD~
N4*MIAMI*FL*33111~
REF*EI*376985369~
HL*2*1*22*0~
SBR*P*18*******MB~
NM1*IL*1*JONES*SARAH*A***MI*012345678A~
N3*1129 REINDEER ROAD~
N4*CARR*CO*80612~
DMG*D8*19630729*F~
NM1*PR*2*MEDICARE PART B*****PI*123245~
N3*PO BOX 3543~
N4*BALTIMORE*MD*666013543~
CLM*051068*766.50***41:B:1*Y*A*Y*Y*P*OA~
DTP*439*D8*20050208~
CR1*LB*275**A*DH*21****PATIENT IMOBILIZED~
CRC*07*Y*04*06*09~
CRC*07*N*05*07*08~
HI*BK:8628*BF:E8888*BF:9592*BF:8540~
NM1*PW*2~
N3*1129 REINDEER ROAD~
N4*CARR*CO*80612~
NM1*45*2~
N3*10005 BANNOCK ST~
N4*CHEYENNE*WY*82009~
LX*1~
SV1*HC:A0427:RH*700*UN*1***1:2:3:4**Y~
DTP*472*D8*20050208~
QTY*PT*2~
REF*6R*1001~
NTE*ADD*CARDIAC EMERGENCY~
LX*2~
SV1*HC:A0425:RH*8.20*UN*21***1:2:3:4**Y~
DTP*472*D8*20050208~
QTY*PT*2~
REF*6R*1002~
LX*3~
SV1*HC:A0422:RH*46*UN*1***1:2:3:4**Y~
DTP*472*D8*20050208~
REF*6R*1003~
LX*4~
SV1*HC:A0382:RH*12.30*UN*1***1:2:3:4**Y~
DTP*472*D8*20050208~
REF*6R*1004~SE*52*000017712~
GE*1*20213~
IEA*1*000010216~";
 
            var parsed = Parser.Parse(message);
            
            Assert.Multiple(() =>
            {
                Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

                var query = parsed.CreateQuery(layout);

                var queryResult = parsed.Query(query);

                var subscriber = queryResult
                    .Select(x => x.Transactions)[0]
                    .Select(x => x.Loop2000B)[0]
                    .Select(x => x.Loop2010BA);
            
                Assert.IsTrue(subscriber.HasValue, "Loop 2000B - SubscriberName");

                var demographics = subscriber
                    .Select(x => x.DemographicInformation);
            
                Assert.IsTrue(demographics.HasValue, "Loop 2010BA - DemographicInformation");

                var genderCode = demographics
                    .Select(x => x.GenderCode);
            
                Assert.IsTrue(genderCode.HasValue, "Loop 2010BA, DMG - GenderCode");
                Assert.AreEqual("F", genderCode.ValueOrDefault());
            });
        }

        [Test]
        public void Cannot_parse_loop_2300_when_MedicalRecordNumber_and_ClaimIdentifierForTransmissionIntermediaries_segments_out_of_order()
        {
            /*
             * The problem here is that segments 31 (ClaimIdentifierForTransmissionIntermediaries) and 32 (MedicalRecordNumber)
             * are swapped in loop 2300. To get this test to pass I put the segments in the proper order and made some changes to
             * the maps.
             */
            const string message =
                @"ISA*00*          *00*          *ZZ*123456789012345*ZZ*123456789012346*061015*1705*>*00501*041700102*0*T*:~
GS*HC*1234567890*9876543210*20061015*1705*041702*X*005010X222A1~
ST*837*0021*005010X222A1~
BHT*0019*00*0417002*20061015*1023*RP~
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
PAT*****D8*20200302~
NM1*IL*1*SMITH*TEDDY*JOHN*Dr*MR*MI*00221111~
N3*236 N MAIN ST~
N4*MIAMI*FL*33413~
DMG*D8*19430501*M~
REF*SY*77799866~
PER*IC*JERRY TOM*TE*5108882277*EX*231*EM*patientme@RELAY123.COM~
NM1*PR*2*ALLIANCE HEALTH AND LIFE INSURANCE*****PI*741234~
CLM*26462967*100***11:B:1*Y*A*Y*I~
DTP*431*D8*19981003~
REF*D9*17312345600006351~
REF*EA*439866~
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
SE*45*0021~
GE*1*041702~
IEA*1*041700102~";
 
            var parsed = Parser.Parse(message);
            
            Assert.Multiple(() =>
            {
                Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

                var query = parsed.CreateQuery(layout);

                var queryResult = parsed.Query(query);

                var patient = queryResult
                    .Select(x => x.Transactions)[0]
                    .Select(x => x.Loop2000C)[0];
                
                Assert.IsTrue(patient.HasValue, "Loop 2000C");

                string subscriber = queryResult
                    .Select(x => x.Transactions)[0]
                    .Select(x => x.Loop2000B)[0]
                    .Select(x => x.Loop2010BA)
                    .Select(x => x.Subscriber)
                    .Select(x => x.EntityIdentifierCode)
                    .ValueOrDefault();
                
                Assert.AreEqual("IL", subscriber, "Loop 2010BA");

                string payer = queryResult
                    .Select(x => x.Transactions)[0]
                    .Select(x => x.Loop2000B)[0]
                    .Select(x => x.Loop2010BB)
                    .Select(x => x.Payer)
                    .Select(x => x.EntityIdentifierCode)
                    .ValueOrDefault();
                
                Assert.AreEqual("PR", payer, "Loop 2010BB");
                
                var claimInfo = patient
                    .Select(x => x.Loop2300)[0];
                
                Assert.IsTrue(claimInfo.HasValue, "Loop 2300");

                string mrn = claimInfo
                    .Select(x => x.MedicalRecordNumber)
                    .Select(x => x.ReferenceIdentificationQualifier)
                    .ValueOrDefault();
                
                Assert.AreEqual("EA", mrn, "Loop 2300 - MRN Qualifier");

                string diagnosticTypeCode = claimInfo
                    .Select(x => x.HealthcareDiagnosisCode)
                    .Select(x => x.HealthCareCodeInformation1)
                    .Select(x => x.DiagnosisTypeCode)
                    .ValueOrDefault();
                
                Assert.AreEqual("BK", diagnosticTypeCode, "Loop 2300 - Healthcare Diagnostic Code");

                var serviceFacilityLocation = claimInfo
                    .Select(x => x.Loop2310C);
                
                Assert.IsTrue(serviceFacilityLocation.HasValue, "Loop 2310C");

                var facility = serviceFacilityLocation
                    .Select(x => x.ServiceFacilityLocation);
                
                Assert.IsTrue(facility.HasValue, "Loop 2310C");
                
                string organization = facility
                    .Select(x => x.LastNameOrOrganizationName)
                    .ValueOrDefault(); 
                
                Assert.AreEqual("KILDARE ASSOCIATES", organization, "Organization Name");
            });
        }
    }
}