namespace Machete.HL7.Tests.ValueConversionTests
{
    using System;
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class ConvertDateTimeOffsetTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public void Should_be_able_to_convert_DateTimeOffset_to_DateTime()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|
EVN|048|20180111|20180121|903";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var mshSegmentQuery = entityResult.CreateQuery(q =>
                from msh in q.Select<MSH>()
                from evn in q.Select<EVN>()
                select new {MSH = msh, EVN = evn});

            var query = entityResult.Query(mshSegmentQuery);

            Assert.IsTrue(query.HasResult);
            Assert.IsNotNull(query.Result.EVN);
            Assert.AreEqual(new DateTime(2018, 1, 11), query.Select(x => x.EVN).Select(x => x.RecordedDateTime).ToDateTime().ValueOrDefault());
        }

        [Test]
        public void Should_throw_ArgumentNullException_when_Value_is_null()
        {
            Value<DateTimeOffset> dt = null;

            Assert.Throws<ArgumentNullException>(() =>
            {
                DateTime actual = dt.ToDateTime().ValueOrDefault();
            });
        }
    }
}