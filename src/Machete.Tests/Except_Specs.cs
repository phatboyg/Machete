namespace Machete.Tests
{
    using Machete.Parsers;
    using NUnit.Framework;
    using Parsers;


    [TestFixture]
    public class Using_an_except_parser
    {
        [Test]
        public void Should_not_match()
        {
            var values = new[] {1, 2, 3, 4, 5};

            var intParser = new AnyParser<int>();

            var parser = from x in intParser.Except(from y in intParser where y == 1 select y)
                select x;

            var result = parser.Execute(values);

            Assert.IsFalse(result.HasResult);
        }

        [Test]
        public void Should_match()
        {
            var values = new[] {2, 3, 4, 5};

            var intParser = new AnyParser<int>();

            var parser = from x in intParser.Except(from y in intParser where y == 1 select y)
                select x;

            var result = parser.Execute(values);

            Assert.IsTrue(result.HasResult);
        }
    }
}