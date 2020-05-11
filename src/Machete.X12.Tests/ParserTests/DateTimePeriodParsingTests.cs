namespace Machete.X12.Tests.ParserTests
{
    using System;
    using System.Globalization;
    using NUnit.Framework;
    using Testing;
    using Texts;
    using X12Schema.V5010;


    [TestFixture]
    public class DateTimePeriodParsingTests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test]
        public void Verify_can_parse_DateTimePeriod_when_yyyymmdd_format()
        {
            const string message =
                @"ISA*00*          *00*          *ZZ*123456789012345*ZZ*123456789012346*061015*1705*>*00501*000010216*0*T*:~
GS*HC*1234567890*9876543210*20061015*1705*20213*X*005010X222A1~
ST*837*0021*005010X222A1~
BHT*0019*00*0123*20061015*1023*RP~
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
NM1*IL*1*SMITH*TED****MI*00221111~
N3*236 N MAIN ST~
N4*MIAMI*FL*33413~
DMG*D8*19430501*M~
NM1*PR*2*ALLIANCE HEALTH AND LIFE INSURANCE*****PI*741234~
CLM*26462967*100***11:B:1*Y*A*Y*I~
DTP*431*D8*19981003~
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
SE*41*0021~
GE*1*20213~
IEA*1*000010216~";
 
            var parsed = Parser.Parse(message);
            
            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = parsed.CreateQuery(layout);

            var queryResult = parsed.Query(query);

            var dateOfBirth = queryResult
                .Select(x => x.Transactions)[0]
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.SubscriberName)
                .Select(x => x.DemographicInformation)
                .Select(x => x.DateOfBirth);

            Assert.IsTrue(dateOfBirth.HasValue);
            Assert.IsTrue(dateOfBirth.IsPresent);
            Assert.AreEqual("19430501", dateOfBirth.ValueOrDefault().ToString());
        }

        [Test]
        public void Verify_can_parse_DateTimePeriod_range()
        {
            const string message =
                @"ISA*00*          *00*          *ZZ*123456789012345*ZZ*123456789012346*061015*1705*>*00501*000010216*0*T*:~
GS*HC*1234567890*9876543210*20061015*1705*20213*X*005010X222A1~
ST*837*0021*005010X222A1~
BHT*0019*00*0123*20061015*1023*RP~
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
NM1*IL*1*SMITH*TED****MI*00221111~
N3*236 N MAIN ST~
N4*MIAMI*FL*33413~
DMG*D8*19430501-19700501*M~
NM1*PR*2*ALLIANCE HEALTH AND LIFE INSURANCE*****PI*741234~
CLM*26462967*100***11:B:1*Y*A*Y*I~
DTP*431*D8*19981003~
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
SE*41*0021~
GE*1*20213~
IEA*1*000010216~";
 
            var parsed = Parser.Parse(message);
            
            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = parsed.CreateQuery(layout);

            var queryResult = parsed.Query(query);

            var dateOfBirth = queryResult
                .Select(x => x.Transactions)[0]
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.SubscriberName)
                .Select(x => x.DemographicInformation)
                .Select(x => x.DateOfBirth);

            Assert.IsTrue(dateOfBirth.HasValue);
            Assert.IsTrue(dateOfBirth.IsPresent);
            
            DateTimePeriod dateTimePeriod = dateOfBirth.ValueOrDefault();
            
            var text = new StringText(dateTimePeriod.ToString());
            
            Assert.AreEqual("19430501-19700501", dateTimePeriod.ToString());
            Assert.IsTrue(dateTimePeriod.TryGetDateTimeRange(out var dateRange));
            
            string[] dateTimePatterns = {
                "yyyyMMdd",
                "MMddyyyy",
                "yyyyMMd",
                "yy",
                "MMYYYY"
            };

            DateTime.TryParseExact("19430501", dateTimePatterns, CultureInfo.InvariantCulture, DateTimeStyles.AllowInnerWhite, out var startDate);
            Assert.AreEqual(startDate, dateRange.StartDate.Date);

            DateTime.TryParseExact("19700501", dateTimePatterns, CultureInfo.InvariantCulture, DateTimeStyles.AllowInnerWhite, out var endDate);
            Assert.AreEqual(endDate, dateRange.EndDate.Date);
            
            Assert.AreEqual("19430501", text.ToString(dateRange.StartSpan));
            Assert.AreEqual("19700501", text.ToString(dateRange.EndSpan));
        }

        [Test]
        public void Verify_can_parse_DateTimePeriod_missing_end()
        {
            const string message =
                @"ISA*00*          *00*          *ZZ*123456789012345*ZZ*123456789012346*061015*1705*>*00501*000010216*0*T*:~
GS*HC*1234567890*9876543210*20061015*1705*20213*X*005010X222A1~
ST*837*0021*005010X222A1~
BHT*0019*00*0123*20061015*1023*RP~
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
NM1*IL*1*SMITH*TED****MI*00221111~
N3*236 N MAIN ST~
N4*MIAMI*FL*33413~
DMG*D8*19430501*M~
NM1*PR*2*ALLIANCE HEALTH AND LIFE INSURANCE*****PI*741234~
CLM*26462967*100***11:B:1*Y*A*Y*I~
DTP*431*D8*19981003~
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
SE*41*0021~
GE*1*20213~
IEA*1*000010216~";
 
            var parsed = Parser.Parse(message);
            
            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = parsed.CreateQuery(layout);

            var queryResult = parsed.Query(query);

            var dateOfBirth = queryResult
                .Select(x => x.Transactions)[0]
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.SubscriberName)
                .Select(x => x.DemographicInformation)
                .Select(x => x.DateOfBirth);

            Assert.IsTrue(dateOfBirth.HasValue);
            Assert.IsTrue(dateOfBirth.IsPresent);
            
            DateTimePeriod dateTimePeriod = dateOfBirth.ValueOrDefault();
            
            var text = new StringText(dateTimePeriod.ToString());
            
            Assert.AreEqual("19430501", dateTimePeriod.ToString());
            Assert.IsFalse(dateTimePeriod.TryGetDateTimeRange(out var dateRange));
            Assert.AreEqual(string.Empty, text.ToString(dateRange.StartSpan));
            Assert.AreEqual(string.Empty, text.ToString(dateRange.EndSpan));
            Assert.AreEqual(default(DateTimeOffset), dateRange.StartDate);
            Assert.AreEqual(default(DateTimeOffset), dateRange.EndDate);
        }

        [Test]
        public void Verify_can_parse_DateTimePeriod_missing_start()
        {
            const string message =
                @"ISA*00*          *00*          *ZZ*123456789012345*ZZ*123456789012346*061015*1705*>*00501*000010216*0*T*:~
GS*HC*1234567890*9876543210*20061015*1705*20213*X*005010X222A1~
ST*837*0021*005010X222A1~
BHT*0019*00*0123*20061015*1023*RP~
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
NM1*IL*1*SMITH*TED****MI*00221111~
N3*236 N MAIN ST~
N4*MIAMI*FL*33413~
DMG*D8*-19430501*M~
NM1*PR*2*ALLIANCE HEALTH AND LIFE INSURANCE*****PI*741234~
CLM*26462967*100***11:B:1*Y*A*Y*I~
DTP*431*D8*19981003~
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
SE*41*0021~
GE*1*20213~
IEA*1*000010216~";
 
            var parsed = Parser.Parse(message);
            
            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = parsed.CreateQuery(layout);

            var queryResult = parsed.Query(query);

            var dateOfBirth = queryResult
                .Select(x => x.Transactions)[0]
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.SubscriberName)
                .Select(x => x.DemographicInformation)
                .Select(x => x.DateOfBirth);

            Assert.IsTrue(dateOfBirth.HasValue);
            Assert.IsTrue(dateOfBirth.IsPresent);
            
            DateTimePeriod dateTimePeriod = dateOfBirth.ValueOrDefault();
            
            var text = new StringText(dateTimePeriod.ToString());
            
            Assert.AreEqual("-19430501", dateTimePeriod.ToString());
            Assert.IsFalse(dateTimePeriod.TryGetDateTimeRange(out var dateRange));
            Assert.AreEqual(string.Empty, text.ToString(dateRange.StartSpan));
            Assert.AreEqual(string.Empty, text.ToString(dateRange.EndSpan));
            Assert.AreEqual(default(DateTimeOffset), dateRange.StartDate);
            Assert.AreEqual(default(DateTimeOffset), dateRange.EndDate);
        }

        [Test]
        public void Verify_does_not_throw_when_DateTimePeriod_missing()
        {
            const string message =
                @"ISA*00*          *00*          *ZZ*123456789012345*ZZ*123456789012346*061015*1705*>*00501*000010216*0*T*:~
GS*HC*1234567890*9876543210*20061015*1705*20213*X*005010X222A1~
ST*837*0021*005010X222A1~
BHT*0019*00*0123*20061015*1023*RP~
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
NM1*IL*1*SMITH*TED****MI*00221111~
N3*236 N MAIN ST~
N4*MIAMI*FL*33413~
DMG*D8**M~
NM1*PR*2*ALLIANCE HEALTH AND LIFE INSURANCE*****PI*741234~
CLM*26462967*100***11:B:1*Y*A*Y*I~
DTP*431*D8*19981003~
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
SE*41*0021~
GE*1*20213~
IEA*1*000010216~";
 
            var parsed = Parser.Parse(message);
            
            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = parsed.CreateQuery(layout);

            var queryResult = parsed.Query(query);

            var dateOfBirth = queryResult
                .Select(x => x.Transactions)[0]
                .Select(x => x.SubscriberDetail)[0]
                .Select(x => x.SubscriberName)
                .Select(x => x.DemographicInformation)
                .Select(x => x.DateOfBirth);

            Assert.IsFalse(dateOfBirth.HasValue);
            Assert.IsTrue(dateOfBirth.IsPresent);
            Assert.IsNull(dateOfBirth.ValueOrDefault());
        }
    }
}