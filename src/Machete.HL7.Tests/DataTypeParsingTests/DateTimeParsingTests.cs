namespace Machete.HL7.Tests.DataTypeParsingTests
{
    using System;
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class DateTimeParsingTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_parse_segment_optionally()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|
EVN|048|20180111|20180121|903";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.Query(q =>
                from msh in q.Select<MSH>()
                from evn in q.Select<EVN>()
                select evn);

            DateTime dateTime = new DateTime(2018, 1, 11);
            
            Assert.IsTrue(query.HasResult);
            Assert.AreEqual(dateTime, query.Select(x => x.RecordedDateTime).ToDateTime().ValueOrDefault());
        }
        
        [Test]
        public void Should_throw_exception_when_date()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|
EVN|048||20180121|903";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.Query(q =>
                from msh in q.Select<MSH>()
                from evn in q.Select<EVN>()
                select evn);
            //ValueMissingException

            Assert.IsTrue(query.HasResult);
            Assert.AreEqual(Value.Missing<DateTime>(), query.Select(x => x.RecordedDateTime).ToDateTime());
        }
        
//        [Test]
//        public void Should_throw_exception_when_date2()
//        {
//            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|
//EVN|048|01|20180121|903";
//
//            EntityResult<HL7Entity> entityResult = Parser.Parse(message);
//
//            var query = entityResult.Query(q =>
//                from msh in q.Select<MSH>()
//                from evn in q.Select<EVN>()
//                select evn);
//            //ValueMissingException
////            DateTimeOffset dateTimeOffset = DateTimeOffset.Parse("2017-12-22");
//
//            Assert.IsTrue(query.HasResult);
//            Assert.Throws<ValueConversionException>(() =>
//            {
//                query.Select(x => x.RecordedDateTime).ToDateTime();
//            });
//        }

    }
}