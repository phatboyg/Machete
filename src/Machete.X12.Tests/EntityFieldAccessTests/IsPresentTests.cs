namespace Machete.X12.Tests.EntityFieldAccessTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class IsPresentTests :
        X12MacheteTestHarness<TestX12Entity, X12Entity>
    {
        [Test]
        public void Should_detect_data_is_present_in_complex_field()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*837*987654*005010X223A3
MTS****KFJ3:4
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
            
            Assert.IsNotNull(result.Select(x => x.Field4));
            Assert.IsTrue(result.Select(x => x.Field4).IsPresent);
        }
        
        [Test]
        public void Should_detect_data_is_not_present_in_complex_field()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*837*987654*005010X223A3
MTS***
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
            
            Assert.IsNotNull(result.Select(x => x.Field4));
            Assert.IsFalse(result.Select(x => x.Field4).IsPresent);
        }
        
        [Test]
        public void Should_detect_data_is_present_with_field_of_whitespace()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*837*987654*005010X223A3
MTS*      ***
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
            
            Assert.IsNotNull(result.Select(x => x.Field1));
            Assert.IsTrue(result.Select(x => x.Field1).IsPresent);
        }
        
        [Test]
        public void Should_detect_data_is_present_in_simple_field()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*837*987654*005010X223A3
MTS*ABC***
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
            
            Assert.IsNotNull(result.Select(x => x.Field1));
            Assert.IsTrue(result.Select(x => x.Field1).IsPresent);
        }
        
        [Test]
        public void Should_detect_data_is_not_present_in_simple_field()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*837*987654*005010X223A3
MTS****
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
            
            Assert.IsNotNull(result.Select(x => x.Field5));
            Assert.IsFalse(result.Select(x => x.Field5).IsPresent);
        }
    }
}