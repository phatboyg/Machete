namespace Machete.X12.Tests.EntityFieldAccessTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class TryGetValueTests :
        X12MacheteTestHarness<TestX12Entity, X12Entity>
    {
        [Test]
        public void Should_be_able_to_get_entity_of_repeatable_field()
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

            Assert.IsNotNull(result.Result);
            Assert.IsTrue(result.Select(x => x.Field3).TryGetValue(0, out Value<TestComponent> item));
            Assert.AreEqual("HF3", item.Select(x => x.Component1).ValueOrDefault());
            Assert.AreEqual(3, item.Select(x => x.Component2).ValueOrDefault());
        }

        [Test]
        public void Should_throw_ValueMissingException_exception_trying_to_access_out_of_range_data()
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

            Assert.IsNotNull(result.Result);
            Assert.IsFalse(result.Select(x => x.Field3).TryGetValue(5, out var item));
            
            Assert.Throws<ValueMissingException>(() =>
            {
                string component = item.Select(x => x.Component1).Value;
            });
        }

        [Test]
        public void Should_throw_SliceMissingException_exception_trying_to_access_empty_field()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*837*987654*005010X223A3
MTS*ABC*X080^Y646^Z005
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

            Assert.IsNotNull(result.Result);

            Assert.Throws<ValueMissingException>(() =>
            {
                bool foundValue = result.Select(x => x.Field3).TryGetValue(0, out Value<TestComponent> item);
                int number = item.Select(x => x.Component2).Value;
            });
        }

        [Test]
        public void Should_not_throw_exception_trying_to_access_field_providing_negative_index()
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

            Assert.IsNotNull(result.Result);
            Assert.IsFalse(result.Select(x => x.Field3).TryGetValue(-1, out var item));
        }

        [Test]
        public void Should_not_throw_exception_when_trying_to_access_out_of_bounds_field_pass_count()
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

            Assert.IsNotNull(result.Result);
            Assert.IsFalse(result.Select(x => x.Field3).TryGetValue(5, out Value<TestComponent> item));
        }
    }
}