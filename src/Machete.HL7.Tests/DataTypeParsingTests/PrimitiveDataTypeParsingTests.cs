namespace Machete.HL7.Tests.DataTypeParsingTests
{
    using System;
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class PrimitiveDataTypeParsingTests :
        HL7MacheteTestHarness<MSHSegment, HL7Entity>
    {
        [Test]
        public void Should_throw_ValueEmpty_exception_when_decimal_field_missing()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
DT1|||||||||||
PID|1||60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|x|abc
NTE|2|y|abc
NTE|3|z|abc";

            var parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt1 in q.Select<DataTypeSegment>()
                from pid in q.Select<PIDSegment>()
                select dt1);

            Assert.Throws<ValueEmptyException>(() =>
            {
                decimal value = result.Select(x => x.DecimalField).Value;
            });
        }
        
        [Test]
        public void Should_throw_ValueEmpty_exception_when_DateTimeOffset_field_missing()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
DT1|||||||||||
PID|1||60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|x|abc
NTE|2|y|abc
NTE|3|z|abc";

            var parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt1 in q.Select<DataTypeSegment>()
                from pid in q.Select<PIDSegment>()
                select dt1);

            Assert.Throws<ValueEmptyException>(() =>
            {
                DateTimeOffset value = result.Select(x => x.DateTimeOffsetField).Value;
            });
        }
        
        [Test]
        public void Should_throw_ValueEmpty_exception_when_DateTime_field_missing()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
DT1|||||||||||
PID|1||60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|x|abc
NTE|2|y|abc
NTE|3|z|abc";

            var parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt1 in q.Select<DataTypeSegment>()
                from pid in q.Select<PIDSegment>()
                select dt1);

            Assert.Throws<ValueEmptyException>(() =>
            {
                decimal value = result.Select(x => x.DecimalField).Value;
            });
        }
        
        [Test]
        public void Should_throw_ValueEmpty_exception_when_Integer_field_missing()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
DT1|||||||||||
PID|1||60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|x|abc
NTE|2|y|abc
NTE|3|z|abc";

            var parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt1 in q.Select<DataTypeSegment>()
                from pid in q.Select<PIDSegment>()
                select dt1);

            Assert.Throws<ValueEmptyException>(() =>
            {
                int value = result.Select(x => x.IntegerField).Value;
            });
        }
        
        [Test]
        public void Should_throw_ValueEmpty_exception_when_Boolean_field_missing()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
DT1|||||||||||
PID|1||60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|x|abc
NTE|2|y|abc
NTE|3|z|abc";

            var parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt1 in q.Select<DataTypeSegment>()
                from pid in q.Select<PIDSegment>()
                select dt1);

            Assert.Throws<ValueEmptyException>(() =>
            {
                bool value = result.Select(x => x.BooleanField).Value;
            });
        }
        
        [Test]
        public void Should_throw_ValueEmpty_exception_when_Long_field_missing()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
DT1|||||||||||
PID|1||60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|x|abc
NTE|2|y|abc
NTE|3|z|abc";

            var parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt1 in q.Select<DataTypeSegment>()
                from pid in q.Select<PIDSegment>()
                select dt1);

            Assert.Throws<ValueEmptyException>(() =>
            {
                long value = result.Select(x => x.LongField).Value;
            });
        }
        
        [Test]
        public void Should_throw_ValueEmpty_exception_when_Guid_field_missing()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
DT1|||||||||||
PID|1||60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|x|abc
NTE|2|y|abc
NTE|3|z|abc";

            var parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt1 in q.Select<DataTypeSegment>()
                from pid in q.Select<PIDSegment>()
                select dt1);

            Assert.Throws<ValueEmptyException>(() =>
            {
                Guid value = result.Select(x => x.GuidField).Value;
            });
        }
        
        [Test]
        public void Should_throw_ValueEmpty_exception_when_FT_field_missing()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
DT1|||||||||||
PID|1||60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|x|abc
NTE|2|y|abc
NTE|3|z|abc";

            var parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt1 in q.Select<DataTypeSegment>()
                from pid in q.Select<PIDSegment>()
                select dt1);

            Assert.Throws<ValueEmptyException>(() =>
            {
                FT value = result.Select(x => x.FTField).Value;
            });
        }
        
        [Test]
        public void Should_throw_ValueEmpty_exception_when_TX_field_missing()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
DT1|||||||||||
PID|1||60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1|x|abc
NTE|2|y|abc
NTE|3|z|abc";

            var parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt1 in q.Select<DataTypeSegment>()
                from pid in q.Select<PIDSegment>()
                select dt1);

            Assert.Throws<ValueEmptyException>(() =>
            {
                TX value = result.Select(x => x.TXField).Value;
            });
        }
    }
}