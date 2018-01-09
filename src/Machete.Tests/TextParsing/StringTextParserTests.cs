namespace Machete.Tests.TextParsing
{
    using NUnit.Framework;
    using TextParsers;
    using Texts;


    [TestFixture]
    public class StringTextParserTests
    {
        [Test]
        public void Test()
        {
            string match = "";
            string rawText =
                "IN1|2|||MACHETE INC|1234 Fruitvale ave^^Oakland^CA^94601^USA||5101234567^^^^^510^1234567|074395|||||||A1|MACHETE^JOE||19890909|123 SEASAME STREET^^Oakland^CA^94600||||||||||||N|||||666889999|0||||||F||||T||60043^^^MACHETE^MRN";
            var text = new StringText(rawText);
//            var textParser = Parser.Factory.CreateText();
//            var parser = new StringTextParser(textParser, rawText);

//            Result<TextSpan, TextSpan> result = parser.Parse(text);
//            
//            Assert.AreEqual("T", text.ToString(result.Result));

        }
    }
}