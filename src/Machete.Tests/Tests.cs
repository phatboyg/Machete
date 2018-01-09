namespace Machete.Tests
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Cursors;
    using NUnit.Framework;
    using TextParsers;
    using Texts;


    [TestFixture]
    public class Using_a_text_parser
    {
        [Test]
        public void Should_parse_text_from_the_string()
        {
            var input = new StringText("Hello, World.");

            var parser = new SymbolTextParser(char.IsLetter, char.IsLetterOrDigit);

            var result = parser.Parse(input, new TextSpan(0, input.Length));

            Assert.IsTrue(result.HasResult);

            var text = input.GetSubText(result.Result);
            Assert.AreEqual("Hello", text.ToString());
        }

        [Test]
        public async Task Should_parse_a_file_line_by_line_async()
        {
            const string fileContent = @"Line 1.
Line 2.
Line 3.
Line 4.
Line 5.
Line 6.
Line 7.
Line 8.";

            using (var stream = new StringReader(fileContent))
            {
                var first = await new TextReaderStreamTextReader(stream, Environment.NewLine).Text;

                var parser = new LineTextParser();
                TextCursor result = await StreamTextCursor.ParseText(first, new TextSpan(0, first.Length), parser);
                while (result.HasCurrent)
                {
                    Console.WriteLine(result.Current);

                    if (result.HasNext == false)
                        break;

                    result = await result.Next();
                }


//                var span = await new ReadLineStreamTextSpanProvider(stream, Environment.NewLine).TextSpan;
//                while (span.CanExtend)
//                    span = await span.Extend();
//
//                Console.WriteLine(span.Text);
            }
        }
    }
}