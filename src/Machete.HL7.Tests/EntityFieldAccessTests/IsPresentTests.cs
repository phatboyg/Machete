namespace Machete.HL7.Tests.EntityFieldAccessTests
{
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;


    [TestFixture]
    public class IsPresentTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public void Should_detect_data_is_present_in_complex_field()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234|||K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSH>()
                select msh);

            var result = entityResult.Query(query);
            
            Assert.IsNotNull(result.Select(x => x.MessageType));
            Assert.IsTrue(result.Select(x => x.MessageType).IsPresent);
        }
        
        [Test]
        public void Should_detect_data_is_not_present_in_complex_field()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSH>()
                select msh);

            var result = entityResult.Query(query);
            
            Assert.IsNotNull(result.Select(x => x.MessageType));
            Assert.IsFalse(result.Select(x => x.MessageType).IsPresent);
        }
        
        [Test]
        public void Should_detect_data_is_present_with_field_of_whitespace()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||   |K113|P|";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSH>()
                select msh);

            var result = entityResult.Query(query);
            
            Assert.IsNotNull(result.Select(x => x.MessageType));
            Assert.IsTrue(result.Select(x => x.MessageType).IsPresent);
        }
        
        [Test]
        public void Should_detect_data_is_present_in_simple_field()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234|SECURE1";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSH>()
                select msh);

            var result = entityResult.Query(query);
            
            Assert.IsNotNull(result.Select(x => x.Security));
            Assert.IsTrue(result.Select(x => x.Security).IsPresent);
        }
        
        [Test]
        public void Should_detect_data_is_not_present_in_simple_field()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSH>()
                select msh);

            var result = entityResult.Query(query);
            
            Assert.IsNotNull(result.Select(x => x.Security));
            Assert.IsFalse(result.Select(x => x.Security).IsPresent);
        }
    }
}