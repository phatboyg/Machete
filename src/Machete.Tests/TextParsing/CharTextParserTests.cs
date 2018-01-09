namespace Machete.Tests.TextParsing
{
    using System;
    using NUnit.Framework;
    using TextParsers;
    using Texts;


    [TestFixture]
    public class CharTextParserTests
    {
        [Test]
        public void Should_be_able_to_parse_single_char()
        {
            var text = new StringText("This is a test 12832");
            ITextParser textParser = Parser.Factory.CreateText(x => x.Char);
            var parser = new CharTextParser(textParser, x => !char.IsDigit(x));

            Result<TextSpan, TextSpan> result = parser.Parse(text);
            
            Assert.AreEqual("T", text.ToString(result.Result));
        }
        
        [Test]
        public void Should_throw_ArgumentNullException_when_condition_not_passed_in()
        {
            var textParser = Parser.Factory.CreateText(x => x.Char);

            Assert.Throws<ArgumentNullException>(() =>
            {
                var parser = new CharTextParser(textParser, null);
            });
        }
        
        [Test]
        public void Should_throw_ArgumentNullException_when_parser_not_passed_in()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var parser = new CharTextParser(null, x => !char.IsDigit(x));
            });
        }
    }
}