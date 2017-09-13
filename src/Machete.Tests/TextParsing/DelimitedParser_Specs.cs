namespace Machete.Tests.TextParsing
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Threading.Tasks;
    using Cursors;
    using NUnit.Framework;
    using NUnit.Framework.Internal;
    using Parsers.TextParsers;
    using Texts;


    [TestFixture]
    public class DelimitedParser_Specs
    {
        [Test]
        public async Task Should_be_able_to_parse_lines_asynchronously_from_a_stream_and_split()
        {
            using (var stream = new StringReader(Text))
            {
                var first = await new TextReaderStreamTextReader(stream, Environment.NewLine).Text;

                var parser = new LineParser();
                TextCursor result = await StreamTextCursor.ParseText(first, new TextSpan(0, first.Length), parser);
                while (result.HasValue)
                {
                    Console.WriteLine(result.Text);

                    var fields = _toListParser.Parse(result.Text, result.Span);

                    Assert.That(fields.HasValue, Is.True);
                    Assert.That(fields.Value.Count, Is.EqualTo(5));

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

            Assert.IsTrue(firstLine.HasValue);

            Result<TextSpan, TextSpan> result = _parser.Parse(parseText, firstLine.Value);

            Assert.IsTrue(result.HasValue);
            Assert.That(parseText.ToString(result.Value), Is.EqualTo("1"));

            result = _parser.Parse(parseText, result.Next);

            Assert.IsTrue(result.HasValue);
            Assert.That(parseText.ToString(result.Value), Is.EqualTo("Sun"));

            result = _parser.Parse(parseText, result.Next);

            Assert.IsTrue(result.HasValue);
            Assert.That(parseText.ToString(result.Value), Is.EqualTo("Moon"));

            result = _parser.Parse(parseText, result.Next);

            Assert.IsTrue(result.HasValue);
            Assert.That(parseText.ToString(result.Value), Is.EqualTo("12.34"));
        }

        DelimitedTextParser _parser;
        LineParser _lineParser;
        TextParser<IReadOnlyList<TextSpan>> _toListParser;

        const string Text = @"1,Sun,""Moon"",12.34,Bright
21,""Jupiter"",Planet,Large,Round";

        [OneTimeSetUp]
        public void Setup()
        {
            var parser = new DelimitedTextParser(',');
            _lineParser = new LineParser();

            _parser = parser;

            _toListParser = parser.ToList();
        }
    }
}