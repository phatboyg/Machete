namespace Machete.X12.Tests.EntityFieldAccessTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class SelectValueTests :
        X12MacheteTestHarness<TestX12Entity, X12Entity>
    {
        [Test]
        public void Verify_can_safely_return_value_from_simple_field()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*837*987654*005010X223A3
MTS*ABC*X080^Y646^Z005*HF3:3^KFJ3:4^KF5:9
SE*43*987654
GE*1*1
IEA*1*000026531";

            ParseResult<X12Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from isa in q.Select<ISASegment>()
                from gs in q.Select<GSSegment>()
                from st in q.Select<STSegment>()
                from mts in q.Select<TestSegment>()
                select mts);

            var result = parsed.Query(query);

            Value<string> field = result.Select(x => x.Field1);

            Assert.IsNotNull(field);
            Assert.AreNotEqual(Value.Empty<string>(), field);
            Assert.AreNotEqual(Value.Missing<string>(), field);
            Assert.AreEqual("ABC", field.ValueOrDefault());
        }

        [Test]
        public void Verify_can_return_empty_value_from_simple_field()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*837*987654*005010X223A3
MTS**X080^Y646^Z005*HF3:3^KFJ3:4^KF5:9
SE*43*987654
GE*1*1
IEA*1*000026531";

            ParseResult<X12Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from isa in q.Select<ISASegment>()
                from gs in q.Select<GSSegment>()
                from st in q.Select<STSegment>()
                from mts in q.Select<TestSegment>()
                select mts);

            var result = parsed.Query(query);

            Value<string> field = result.Select(x => x.Field1);

            Assert.IsNotNull(field);
            Assert.IsFalse(field.HasValue);
            Assert.IsTrue(field.IsPresent);
            Assert.AreNotEqual(Value.Empty<string>(), field);
            Assert.AreNotEqual(Value.Missing<string>(), field);
        }
        
        [Test]
        public void Verify_can_return_empty_value_from_complex_field()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*837*987654*005010X223A3
MTS*ABC*X080^Y646^Z005*HF3:3^KFJ3:4^KF5:9*HF3:3
SE*43*987654
GE*1*1
IEA*1*000026531";

            ParseResult<X12Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from isa in q.Select<ISASegment>()
                from gs in q.Select<GSSegment>()
                from st in q.Select<STSegment>()
                from mts in q.Select<TestSegment>()
                select mts);

            var result = parsed.Query(query);

            Value<TestComponent> field = result.Select(x => x.Field4);
            Value<string> component = field.Select(x => x.Component1);

            Assert.IsNotNull(field);
            Assert.IsNotNull(component);
            Assert.AreNotEqual(Value.Empty<string>(), field);
            Assert.AreNotEqual(Value.Missing<string>(), field);
            Assert.AreNotEqual(Value.Empty<string>(), component);
        }
        
        [Test]
        public void Verify_can_safely_return_value_from_complex_field()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*837*987654*005010X223A3
MTS*ABC*X080^Y646^Z005*HF3:3^KFJ3:4^KF5:9*HF3:3
SE*43*987654
GE*1*1
IEA*1*000026531";

            ParseResult<X12Entity> parsed = Parser.Parse(message);

            var query = parsed.CreateQuery(q =>
                from isa in q.Select<ISASegment>()
                from gs in q.Select<GSSegment>()
                from st in q.Select<STSegment>()
                from mts in q.Select<TestSegment>()
                select mts);

            var result = parsed.Query(query);

            Value<TestComponent> field = result.Select(x => x.Field4);
            Value<string> component = field.Select(x => x.Component1);

            Assert.IsNotNull(field);
            Assert.IsNotNull(component);
            Assert.AreNotEqual(Value.Empty<string>(), field);
            Assert.AreNotEqual(Value.Missing<string>(), field);
            Assert.AreNotEqual(Value.Empty<string>(), component);
            Assert.AreNotEqual(Value.Missing<string>(), component);
            Assert.AreEqual("HF3", component.ValueOrDefault());
        }
    }
}