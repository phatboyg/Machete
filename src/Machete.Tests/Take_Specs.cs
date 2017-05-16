namespace Machete.Tests
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using Parsers;


    [TestFixture]
    public class Specifying_a_take_query_argument
    {
        [Test]
        public void Should_only_take_that_many_elements()
        {
            var subject = new[] {1, 2, 3, 4, 5};

            var anyParser = new AnyParser<int>();

            Parser<int, IReadOnlyList<int>> query = (from x in anyParser
                select x).Take(2);

            Result<Cursor<int>, IReadOnlyList<int>> result = query.Execute(subject);

            Assert.IsTrue(result.HasValue);
            Assert.AreEqual(2, result.Value.Count);
        }
    }
}