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

            TextParser first = new ConstantStringParser("Hello");


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
    }
}