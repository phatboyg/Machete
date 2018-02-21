namespace Machete.HL7.Tests.ParserTests
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;
    using Texts;


    [TestFixture]
    public class StreamTextParsingTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
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

                Assert.IsTrue(result.TryGetEntity(0, out MSH msh));
                Assert.IsNotNull(msh);
                Assert.IsNotNull(msh.SendingApplication);
                Assert.IsTrue(msh.SendingApplication.IsPresent);
                Assert.IsTrue(msh.SendingApplication.HasValue);
                Assert.AreEqual("LIFTLAB", msh.SendingApplication.Value.NamespaceId.Value);

                result = await result.NextAsync();

                Assert.IsTrue(result.TryGetEntity(0, out msh));
                Assert.IsNotNull(msh);
                Assert.IsNotNull(msh.SendingApplication);
                Assert.IsTrue(msh.SendingApplication.IsPresent);
                Assert.IsTrue(msh.SendingApplication.HasValue);
                Assert.AreEqual("LIFTLAB2", msh.SendingApplication.Value.NamespaceId.Value);
            }
        }

        [Test]
        public void Should_parse_the_opening_segment_and_return_the_first_entity()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            var text = new StringText(message);

            var result = Parser.Parse(text, new TextSpan(0, text.Length));

            Assert.IsTrue(result.TryGetEntity(0, out MSH msh));
            Assert.IsNotNull(msh);
            Assert.IsNotNull(msh.SendingApplication);
            Assert.IsTrue(msh.SendingApplication.IsPresent);
            Assert.IsTrue(msh.SendingApplication.HasValue);
            Assert.AreEqual("LIFTLAB", msh.SendingApplication.Value.NamespaceId.Value);
            Assert.IsNotNull(msh.ReceivingApplication);
            Assert.IsTrue(msh.ReceivingApplication.IsPresent);
            Assert.IsTrue(msh.ReceivingApplication.HasValue);
            Assert.AreEqual("UBERMED", msh.ReceivingApplication.Value.NamespaceId.Value);
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
            Assert.AreEqual("ORU", messageType.MessageCode.Value);
            Assert.IsNotNull(messageType.TriggerEvent);
            Assert.IsTrue(messageType.TriggerEvent.IsPresent);
            Assert.IsTrue(messageType.TriggerEvent.HasValue);
            Assert.AreEqual("R01", messageType.TriggerEvent.Value);
        }
    }
}