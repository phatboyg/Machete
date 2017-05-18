namespace Machete.Tests
{
    using NUnit.Framework;
    using Parsers;
    using Parsers.TextParsers;


    [TestFixture]
    public class Creating_a_text_parser
    {
        [Test]
        public void Should_be_similar_and_easy()
        {
            var parser = Parser.Factory.CreateText(x =>
                new CharParser(char.IsLetter)
            );
        }
    }
}