namespace Machete.Tests.TextParsing
{
    using NUnit.Framework;


    [TestFixture]
    public class Int32ValueTypeParserTests
    {
        [Test]
        public void Should_match_an_integer()
        {
            string text = "123 456 789";

            var parser = Parser.Factory.CreateText(x =>
                x.Int32()
            );

            var result = parser.Parse(text);

            Assert.IsTrue(result.HasResult);

            Assert.AreEqual(123, result.Result);
        }

        [Test]
        public void Should_match_digits()
        {
            string text = "123 456 789";

            var parser = Parser.Factory.CreateText(x =>
                x.Char(char.IsDigit).OneOrMore()
            );

            var result = parser.Parse(text);

            Assert.IsTrue(result.HasResult);

            Assert.AreEqual(3, result.Result.Length);
        }

        [Test]
        public void Should_match_a_series_of_integers()
        {
            string text = "123 456 789";

            var parser = Parser.Factory.CreateText(x =>
                from a in x.Int32()
                from ws in x.Whitespace()
                from b in x.Int32()
                from ws2 in x.Whitespace()
                from c in x.Int32()
                select new {a, b, c}
            );

            var result = parser.Parse(text);

            Assert.IsTrue(result.HasResult);

            Assert.AreEqual(123, result.Result.a);
            Assert.AreEqual(456, result.Result.b);
            Assert.AreEqual(789, result.Result.c);
        }
    }
}