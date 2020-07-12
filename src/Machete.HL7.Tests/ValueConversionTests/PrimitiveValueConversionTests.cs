namespace Machete.HL7.Tests.ValueConversionTests
{
    using System;
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class PrimitiveValueConversionTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Verify_can_convert_string_data_type()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT|ABC";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual("ABC", result.Select(x => x.StringField).ValueOrDefault());
        }
        
        [Test]
        public void Verify_can_convert_negative_int_data_type()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||-2147483648";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(-2147483648, result.Select(x => x.IntField).ValueOrDefault());
        }
        
        [Test]
        public void Verify_can_convert_positive_int_data_type()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||2147483647";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(2147483647, result.Select(x => x.IntField).ValueOrDefault());
        }
        
        [Test]
        public void Verify_can_convert_negative_long_data_type()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT|||-9223372036854775808";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(-9223372036854775808, result.Select(x => x.LongField).ValueOrDefault());
        }
        
        [Test]
        public void Verify_can_convert_positive_long_data_type()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT|||9223372036854775807";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(9223372036854775807, result.Select(x => x.LongField).ValueOrDefault());
        }
        
        [Test]
        public void Verify_can_convert_negative_short_data_type()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT|||||||-32768";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(-32768, result.Select(x => x.ShortField).ValueOrDefault());
        }
        
        [Test]
        public void Verify_can_convert_positive_short_data_type()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT|||||||32767";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(32767, result.Select(x => x.ShortField).ValueOrDefault());
        }
        
        [Test]
        public void Verify_can_convert_guid_data_type()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT|||||682a2a36-7bd5-4a2a-a8f3-c953bb0c286d";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.AreEqual(Guid.Parse("682a2a36-7bd5-4a2a-a8f3-c953bb0c286d"), result.Select(x => x.GuidField).ValueOrDefault());
        }
        
        [Test]
        public void Verify_can_convert_true_boolean_data_type()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||||true";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.IsTrue(result.Select(x => x.BooleanField).ValueOrDefault());
        }
        
        [Test]
        public void Verify_can_convert_false_boolean_data_type()
        {
            const string message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
MDT||||||||false";
            
            ParseResult<HL7Entity> parse = Parser.Parse(message);

            var result = parse.Query(q =>
                from msh in q.Select<MSHSegment>()
                from dt in q.Select<MacheteDataTypeSegment>()
                select dt);

            Assert.That(result.HasResult, Is.True);
            Assert.IsFalse(result.Select(x => x.BooleanField).ValueOrDefault());
        }
    }
}