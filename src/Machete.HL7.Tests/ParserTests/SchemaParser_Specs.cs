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
    public class Creating_a_schema :
        HL7MacheteTestHarness<MSHSegment, HL7Entity>
    {
        [Test]
        public void Should_use_the_factory_specified()
        {
            var schema = Machete.Schema.Factory.CreateHL7<HL7Entity>();
        }

        [Test]
        public void Should_parse_the_opening_segment()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            var text = new StringText(message);

            var result = Parser.Parse(text, new TextSpan(0, text.Length));
        }

        [Test]
        public async Task Should_parse_the_two_segments_in_a_row()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|
MSH|^~\&|LIFTLAB2||UBERMED2||201701131234||ORU^R01|K113|P|";

            using (var stream = new StringReader(message))
            {
                StreamText text = await new TextReaderStreamTextReader(stream, Environment.NewLine).Text;

                ParseResult<HL7Entity> result = await Parser.ParseStream(text, new TextSpan(0, text.Length));

                MSHSegment msh = null;
                Assert.IsTrue(result.TryGetEntity(0, out msh));

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

        [Test]
        public void Should_parse_the_opening_segment_and_return_the_first_entity()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            var text = new StringText(message);

            var result = Parser.Parse(text, new TextSpan(0, text.Length));

            MSHSegment msh = null;
            Assert.IsTrue(result.TryGetEntity(0, out msh));

            Assert.IsNotNull(msh);

            Assert.IsNotNull(msh.SendingApplication);
            Assert.IsTrue(msh.SendingApplication.IsPresent);
            Assert.IsTrue(msh.SendingApplication.HasValue);
            Assert.That(msh.SendingApplication.Value, Is.EqualTo("LIFTLAB"));

            Assert.IsNotNull(msh.ReceivingApplication);
            Assert.IsTrue(msh.ReceivingApplication.IsPresent);
            Assert.IsTrue(msh.ReceivingApplication.HasValue);
            Assert.That(msh.ReceivingApplication.Value, Is.EqualTo("UBERMED"));

            Assert.IsNotNull(msh.VersionId);
            Assert.IsTrue(msh.VersionId.IsPresent);
            Assert.IsFalse(msh.VersionId.HasValue);

            Assert.IsNotNull(msh.ContinuationPointer);
            Assert.IsFalse(msh.ContinuationPointer.IsPresent);

            Assert.IsNotNull(msh.ParsedText);
            Assert.IsTrue(msh.ParsedText.TryGetSlice(2, out var slice));
            Assert.That(slice.Text.ToString(), Is.EqualTo("LIFTLAB"));

            Assert.IsNotNull(msh.MessageType);
            Assert.IsTrue(msh.MessageType.IsPresent);
            Assert.IsTrue(msh.MessageType.HasValue);

            MSG messageType = msh.MessageType.Value;

            Assert.IsNotNull(messageType.MessageCode);
            Assert.IsTrue(messageType.MessageCode.IsPresent);
            Assert.IsTrue(messageType.MessageCode.HasValue);
            Assert.That(messageType.MessageCode.Value, Is.EqualTo("ORU"));
            Assert.IsNotNull(messageType.TriggerEvent);
            Assert.IsTrue(messageType.TriggerEvent.IsPresent);
            Assert.IsTrue(messageType.TriggerEvent.HasValue);
            Assert.That(messageType.TriggerEvent.Value, Is.EqualTo("R01"));
        }

        [Test]
        public void Should_return_false_on_an_empty_message()
        {
            const string message = @"";

            var result = Parser.Parse(message);

            Assert.That(result.HasResult, Is.False);
            Assert.That(result.RemainingSpan.Length, Is.EqualTo(0));
            Assert.That(result.RemainingSpan.Start, Is.EqualTo(0));
        }
        
        [Test]
        public void Should_properly_show_the_span_was_consumed_with_no_message()
        {
            const string message = "    ";

            var result = Parser.Parse(message);

            Assert.That(result.HasResult, Is.False);
            Assert.That(result.RemainingSpan.Length, Is.EqualTo(0));
            Assert.That(result.RemainingSpan.Start, Is.EqualTo(4));
        }
        
        [Test]
        public void Should_properly_show_the_span_was_consumed_with_no_message_and_blank_lines()
        {
            const string message = "    \n";

            var result = Parser.Parse(message);

            Assert.That(result.HasResult, Is.False);
            Assert.That(result.RemainingSpan.Length, Is.EqualTo(0));
            Assert.That(result.RemainingSpan.Start, Is.EqualTo(5));
        }
    }
}