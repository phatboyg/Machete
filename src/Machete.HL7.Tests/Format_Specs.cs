namespace Machete.HL7.Tests
{
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using Segments;
    using Testing;


    [TestFixture]
    public class Formatting_an_HL7_segment :
        HL7MacheteTestHarness<TestHL7Entity, HL7Entity>
    {
        [Test, Explicit]
        public async Task Should_return_the_same_as_the_input()
        {
            const string message = @"MSH|^~\&|MACHETELAB||UBERMED||201701131234|||K113|P|";

            ParseResult<HL7Entity> entityResult = Parser.Parse(message);


            using (var memoryStream = new MemoryStream())
            {
                var formatted = await Formatter.FormatAsync(memoryStream, entityResult);

                var text = Encoding.UTF8.GetString(memoryStream.ToArray());

                Assert.That(text, Is.EqualTo(message));
            }
        }
    }
}