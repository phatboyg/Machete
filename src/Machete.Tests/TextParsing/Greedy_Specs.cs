namespace Machete.Tests.TextParsing
{
    using NUnit.Framework;
    using Texts;


    public class Greedy_Specs
    {
        [Test]
        public void Should_choose_the_greediest_one()
        {
            var subject = "Hello, World";

            var first = Parser.Factory.CreateText(x => x.String("Hello"));

            var stringText = new StringText(subject);

            Assert.IsTrue(first.Parse(stringText).HasResult, "First did not match");

            var second = Parser.Factory.CreateText(x =>
                from h in x.String("Hello")
                from y in x.Char(',')
                from ws in x.Whitespace()
                from w in x.String("World")
                select h + y + ws + w);

            Assert.IsTrue(second.Parse(stringText).HasResult, "Second did not match");

            var parser = Parser.Factory.CreateText(x => x.Longest(first, second));

            var result = parser.Parse(stringText);

            Assert.IsTrue(result.HasResult, "Neither matched");

            Assert.AreEqual("Hello, World", stringText.ToString(result.Result), "Longest parser should have matched");
        }

        [Test]
        public void Should_properly_express_the_span_upon_return()
        {
            var subject = "aaaabbbbccccdddd";

            var parser = Parser.Factory.CreateText(x =>
                from open in x.Char('a').ZeroOrMore()
                from bees in x.Char('b').ZeroOrMore()
                from close in x.Char('c').ZeroOrMore()
                select bees);

            var result = parser.Parse(subject);

            Assert.IsTrue(result.HasResult);

            Assert.That(result.Result.Start, Is.EqualTo(4));
            Assert.That(result.Result.Length, Is.EqualTo(4));
            Assert.That(result.Next.Start, Is.EqualTo(12));
            Assert.That(result.Next.Length, Is.EqualTo(4));

            var nextParser = Parser.Factory.CreateText(x => x.Char('d').ZeroOrMore());

            var nextResult = nextParser.Parse(subject, result.Next);

            Assert.IsTrue(nextResult.HasResult);
            Assert.That(nextResult.Result.Start, Is.EqualTo(12));
            Assert.That(nextResult.Result.Length, Is.EqualTo(4));
        }

        [Test]
        public void Should_support_a_run_of_characters()
        {
            var subject = "aaaabbbbccccdddd";

            var charParser = Parser.Factory.CreateText(x =>
                x.Char('a', 'b', 'c').ZeroOrMore()
            );

            var result = charParser.Parse(new StringText(subject));

            Assert.IsTrue(result.HasResult);
            Assert.That(result.Result.Length, Is.EqualTo(12));
        }
    }
}