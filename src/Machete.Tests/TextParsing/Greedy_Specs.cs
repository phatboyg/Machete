namespace Machete.Tests.TextParsing
{
    using NUnit.Framework;
    using Parsers.TextParsers;
    using Texts;


    [TestFixture]
    public class Greedy_Specs
    {
        [Test]
        public void Should_choose_the_greediest_one()
        {
            string subject = "Hello, World";

            TextParser first = new StringTextParser("Hello");


            var stringText = new StringText(subject);
            Assert.IsTrue(first.Parse(stringText, new TextSpan(0, stringText.Length)).HasValue, "First did not match");

//            Parser<string, string> second = from x in p.String("Hello")
//                from y in p.Char(',')
//                from ws in p.Whitespace()
//                from z in p.String("World")
//                select x + z;
//
//            Assert.IsTrue(second.ParseString(subject).HasValue, "Second did not match");
//
//            Parser<string, string> parser = p.Longest(first, second);
//
//            Result<string, string> result = parser.ParseString(subject);
//
//            Assert.IsTrue(result.HasValue, "Neither matched");
//
//            Assert.AreEqual("HelloWorld", result.Value, "Longest parser should have matched");
        }

        [Test]
        public void Should_support_a_run_of_characters()
        {
            string subject = "aaaabbbbccccdddd";

            var charParser = Parser.Factory.CreateText(x =>
                x.Char('a', 'b', 'c').ZeroOrMore()
            );

            var result = charParser.Parse(new StringText(subject));

            Assert.IsTrue(result.HasValue);
            Assert.That(result.Value.Length, Is.EqualTo(12));
        }

        [Test]
        public void Should_properly_express_the_span_upon_return()
        {
            string subject = "aaaabbbbccccdddd";

            var parser = Parser.Factory.CreateText(x =>
                from open in x.Char('a').ZeroOrMore()
                from bees in x.Char('b').ZeroOrMore()
                from close in x.Char('c').ZeroOrMore()
                select bees);

            var result = parser.Parse(subject);

            Assert.IsTrue(result.HasValue);

            Assert.That(result.Value.Start, Is.EqualTo(4));
            Assert.That(result.Value.Length, Is.EqualTo(4));
            Assert.That(result.Next.Start, Is.EqualTo(12));
            Assert.That(result.Next.Length, Is.EqualTo(4));

            var nextParser = Parser.Factory.CreateText(x => x.Char('d').ZeroOrMore());

            var nextResult = nextParser.Parse(subject, result.Next);

            Assert.IsTrue(nextResult.HasValue);
            Assert.That(nextResult.Value.Start, Is.EqualTo(12));
            Assert.That(nextResult.Value.Length, Is.EqualTo(4));
        }
    }
}