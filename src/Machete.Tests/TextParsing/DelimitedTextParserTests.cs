namespace Machete.Tests.TextParsing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Cursors;
    using NUnit.Framework;
    using TextParsers;
    using Texts;


    [TestFixture]
    public class DelimitedTextParserTests
    {
        [Test]
        public async Task Should_be_able_to_parse_lines_asynchronously_from_a_stream_and_split()
        {
            using (var stream = new StringReader(Text))
            {
                var first = await new TextReaderStreamTextReader(stream, Environment.NewLine).Text;

                var parser = new LineTextParser();
                TextCursor result = await StreamTextCursor.ParseText(first, new TextSpan(0, first.Length), parser);
                while (result.HasCurrent)
                {
                    Console.WriteLine(result.Current);

                    var fields = _toListParser.Parse(result.Current, result.CurrentSpan);

                    Assert.That(fields.HasResult, Is.True);
                    Assert.That(fields.Result.Count, Is.EqualTo(5));

                    if (result.HasNext == false)
                        break;

                    result = await result.Next();
                }
            }
        }

        [Test]
        public void Should_be_able_to_parse_multiple_lines()
        {
            var parseText = new StringText(Text);

            var firstLine = _lineParser.Parse(parseText);

            Assert.IsTrue(firstLine.HasResult);

            Result<TextSpan, TextSpan> result = _parser.Parse(parseText, firstLine.Result);

            Assert.IsTrue(result.HasResult);
            Assert.That(parseText.ToString(result.Result), Is.EqualTo("1"));

            result = _parser.Parse(parseText, result.Next);

            Assert.IsTrue(result.HasResult);
            Assert.That(parseText.ToString(result.Result), Is.EqualTo("Sun"));

            result = _parser.Parse(parseText, result.Next);

            Assert.IsTrue(result.HasResult);
            Assert.That(parseText.ToString(result.Result), Is.EqualTo("Moon"));

            result = _parser.Parse(parseText, result.Next);

            Assert.IsTrue(result.HasResult);
            Assert.That(parseText.ToString(result.Result), Is.EqualTo("12.34"));
        }

        DelimitedTextParser _parser;
        LineTextParser _lineParser;
        ITextParser<IReadOnlyList<TextSpan>> _toListParser;

        const string Text = @"1,Sun,""Moon"",12.34,Bright
21,""Jupiter"",Planet,Large,Round";

        [OneTimeSetUp]
        public void Setup()
        {
            var parser = new DelimitedTextParser(',');
            _lineParser = new LineTextParser();

            _parser = parser;

            _toListParser = parser.ToList();
        }
    }
}