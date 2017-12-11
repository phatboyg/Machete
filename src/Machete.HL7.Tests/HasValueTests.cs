namespace Machete.HL7.Tests
{
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class HasValueTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public void Should_detect_field_has_no_value()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234|||K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSH>()
                select msh);

            var result = entityResult.Query(query);
            
            Assert.IsNotNull(result.Select(x => x.MessageType));
            Assert.IsTrue(result.Select(x => x.MessageType).HasValue);
        }
        
        [Test]
        public void Should_detect_component_field_has_no_value()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||^R01|K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSH>()
                select msh);

            var result = entityResult.Query(query);
            
            Assert.IsNotNull(result.Select(x => x.MessageType));
            Assert.IsTrue(result.Select(x => x.MessageType).HasValue);
            Assert.IsFalse(result.Select(x => x.MessageType).Select(x => x.MessageCode).HasValue);
        }
    }
}