namespace Machete.Tests.TextParsing
{
    using NUnit.Framework;


    [TestFixture]
    public class ExceptTextParserTests
    {
        [Test]
        public void Should_match_up_to_the_except_match()
        {
            string subject = "aaaabbbbccccdddd";

            var charParser = Parser.Factory.CreateText(x =>
                x.Char.Except(x.Char('b')).ZeroOrMore()
            );

            var result = charParser.Parse(subject);

            Assert.IsTrue(result.HasResult);
            Assert.That(result.Result.Length, Is.EqualTo(4));
        }

        [Test]
        public void Should_match_up_to_the_except_match_for_one()
        {
            string subject = "abcd";

            var charParser = Parser.Factory.CreateText(x =>
                x.Char.Except(x.Char('b')).ZeroOrMore()
            );

            var result = charParser.Parse(subject);

            Assert.IsTrue(result.HasResult);
            Assert.That(result.Result.Length, Is.EqualTo(1));
        }

        [Test]
        public void Should_match_up_to_the_except_match_for_one_using_LINQ()
        {
            string subject = "abcd";

            ITextParser charParser = Parser.Factory.CreateText(x =>
                from prefix in x.Char.Except(x.Char('b')).ZeroOrMore()
                select prefix
            );

            Result<TextSpan, TextSpan> result = charParser.Parse(subject);

            Assert.IsTrue(result.HasResult);
            Assert.That(result.Result.Length, Is.EqualTo(1));
            Assert.That(subject.Substring(result.Result.Start, result.Result.Length), Is.EqualTo("a"));
        }
    }
}