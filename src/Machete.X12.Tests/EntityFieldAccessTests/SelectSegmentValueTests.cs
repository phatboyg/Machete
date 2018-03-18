namespace Machete.X12.Tests.EntityFieldAccessTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;
    using X12Schema.V5010;
    using X12Schema.V5010.Layouts;


    [TestFixture]
    public class SelectSegmentValueTests :
        X12MacheteTestHarness<TestX12Entity, X12Entity>
    {
        [Test]
        public void Test()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*837*987654*005010X223A3
MTS*ABC*X080^Y646^Z005
SE*43*987654
GE*1*1
IEA*1*000026531";

            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<TestX12Layout, X12Entity> layout));

            IParser<X12Entity, TestX12Layout> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, TestX12Layout> result = entityResult.Query(query);

            Assert.IsTrue(result.HasResult);
            
            var interchangeSegment = result.Select(x => x.InterchangeControlHeader);
            var transactionSetHeader = result.Select(x => x.TransactionSetHeader);
            var groupSegment = result.Select(x => x.FunctionalGroupHeader);
            
            Assert.IsNotNull(interchangeSegment);
            Assert.IsTrue(interchangeSegment.HasValue);
            Assert.IsTrue(groupSegment.HasValue);
            Assert.IsTrue(transactionSetHeader.HasValue);

            var segment = result.Select(x => x.TestSegment);
            
            Assert.IsTrue(segment.HasValue);
            
            var valueList = segment.Select(x => x.Field2);
            
            Assert.IsTrue(valueList.HasValue);
            string field = valueList[0].ValueOrDefault();
            
            Assert.AreEqual("X080", field);
        }
    }
}