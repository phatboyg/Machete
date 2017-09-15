namespace Machete.Tests.TextParsing
{
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using Texts;


    [TestFixture]
    public class Except_Specs
    {
        [Test]
        public void Should_match_up_to_the_except_match()
        {
            string subject = "aaaabbbbccccdddd";

            var charParser = Parser.Factory.CreateText(x =>
                x.Char().Except(x.Char('b')).ZeroOrMore()
            );

            var result = charParser.Parse(subject);

            Assert.IsTrue(result.HasValue);
            Assert.That(result.Value.Length, Is.EqualTo(4));
        }

        [Test]
        public void Should_match_up_to_the_except_match_for_one()
        {
            string subject = "abcd";

            var charParser = Parser.Factory.CreateText(x =>
                x.Char().Except(x.Char('b')).ZeroOrMore()
            );

            var result = charParser.Parse(subject);

            Assert.IsTrue(result.HasValue);
            Assert.That(result.Value.Length, Is.EqualTo(1));
        }

        [Test]
        public void Should_match_up_to_the_except_match_for_one_using_LINQ()
        {
            string subject = "abcd";

            TextParser charParser = Parser.Factory.CreateText(x =>
                from prefix in x.Char().Except(x.Char('b')).ZeroOrMore()
                select prefix
            );

            Result<TextSpan, TextSpan> result = charParser.Parse(subject);

            Assert.IsTrue(result.HasValue);
            Assert.That(result.Value.Length, Is.EqualTo(1));
            Assert.That(subject.Substring(result.Value.Start, result.Value.Length), Is.EqualTo("a"));
        }
    }
}