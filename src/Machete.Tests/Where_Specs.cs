namespace Machete.Tests
{
    using Machete.Parsers;
    using NUnit.Framework;


    [TestFixture]
    public class Querying_an_array_with_a_filter
    {
        [Test]
        public void Should_return_a_matching_element()
        {
            var subject = new[] {1, 2, 3, 4, 5};

            var anyParser = new AnyParser<int>();

            IParser<int, int> query = from x in anyParser
                where x == 1
                select x;

            Result<Cursor<int>, int> result = query.Execute(subject);

            Assert.IsTrue(result.HasResult);
            Assert.AreEqual(1, result.Result);
        }

        [Test]
        public void Should_not_return_an_unmatching_element()
        {
            var subject = new[] {1, 2, 3, 4, 5};

            var anyParser = new AnyParser<int>();

            IParser<int, int> query = from x in anyParser
                where x == 2
                where x != 1
                select x;

            Result<Cursor<int>, int> result = query.Execute(subject);

            Assert.IsFalse(result.HasResult);
        }
    }
}