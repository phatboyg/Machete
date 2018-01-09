namespace Machete.HL7.Tests.ParserTests
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using Testing;
    using TestSchema;
    using Texts;


    [TestFixture]
    public class NextParsingTests :
        HL7MacheteTestHarness<MSHSegment, HL7Entity>
    {
        [Test]
        public async Task Should_parse_the_two_segments_in_a_row()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|
MSH|^~\&|LIFTLAB2||UBERMED2||201701131234||ORU^R01|K113|P|";

            using (var stream = new StringReader(message))
            {
                StreamText text = await new TextReaderStreamTextReader(stream, Environment.NewLine).Text;

                ParseResult<HL7Entity> result = await Parser.ParseStream(text, new TextSpan(0, text.Length));

                Assert.IsTrue(result.TryGetEntity(0, out MSHSegment msh));

                Assert.IsNotNull(msh);

                Assert.IsNotNull(msh.SendingApplication);
                Assert.IsTrue(msh.SendingApplication.IsPresent);
                Assert.IsTrue(msh.SendingApplication.HasValue);
                Assert.That(msh.SendingApplication.Value, Is.EqualTo("LIFTLAB"));

                result = await result.NextAsync();

                Assert.IsTrue(result.TryGetEntity(0, out msh));

                Assert.IsNotNull(msh);

                Assert.IsNotNull(msh.SendingApplication);
                Assert.IsTrue(msh.SendingApplication.IsPresent);
                Assert.IsTrue(msh.SendingApplication.HasValue);
                Assert.That(msh.SendingApplication.Value, Is.EqualTo("LIFTLAB2"));
            }
        }
    }
}