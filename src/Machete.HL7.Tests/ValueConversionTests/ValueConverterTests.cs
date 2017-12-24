namespace Machete.HL7.Tests.ValueConversionTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class ValueConverterTests :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test]
        public void Verify_can_apply_value_converter_on_simple_fields()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|
MS1|5101234567";

            EntityResult<HL7Entity> entityResult = Parser.Parse(message);

            var query = entityResult.CreateQuery(q =>
                from msh in q.Select<MSHSegment>()
                from zhx in q.Select<MacheteSample1Segment>()
                select zhx);

            var result = entityResult.Query(query);
            
            Assert.AreEqual("(510) 123-4567", result.Select(x => x.Phone).ValueOrDefault());
        }
        
//        [Test]
//        public void Verify_can_apply_value_converter_on_simple_fields()
//        {
//            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234||ORU^R01|K113|P|
//MS1|5101234567";
//
//            EntityResult<HL7Entity> entityResult = Parser.Parse(message);
//
//            var query = entityResult.CreateQuery(q =>
//                from msh in q.Select<MSHSegment>()
//                from zhx in q.Select<MacheteSample1Segment>()
//                select zhx);
//
//            var result = entityResult.Query(query);
//            
//            Assert.AreEqual("(510) 123-4567", result.Select(x => x.Phone).ValueOrDefault());
//        }

    }
}