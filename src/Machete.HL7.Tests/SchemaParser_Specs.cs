namespace Machete.HL7.Tests
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using Segments;
    using Texts;


    [TestFixture]
    public class Creating_a_schema
    {
        ISchema<HL7Entity> _schema;
        IParser<HL7Entity> _parser;

        [OneTimeSetUp]
        public void Setup()
        {
            _schema = Schema.Factory.CreateHL7(cfg =>
            {
                cfg.Add(new MSGComponentMap());
                cfg.Add(new MSHSegmentMap());
            });

            _parser = Parser.Factory.CreateHL7(_schema);
        }

        [Test]
        public void Should_use_the_factory_specified()
        {
            var schema = Schema.Factory.CreateHL7();
        }

        [Test]
        public void Should_parse_the_opening_segment()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|";

            var text = new StringText(message);

            var result = _parser.Parse(text, new TextSpan(0, text.Length));
        }

        [Test]
        public async Task Should_parse_the_two_segments_in_a_row()
        {
            const string message = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01|K113|P|
MSH|^~\&|LIFTLAB2||UBERMED2||201701131234||ORU^R01|K113|P|";

            using (var stream = new StringReader(message))
            {
                StreamText text = await new TextReaderStreamTextReader(stream, Environment.NewLine).Text;

                ParsedResult<HL7Entity> result = await _parser.ParseAsync(text, new TextSpan(0, text.Length));

                MSHSegment msh = null;
                Assert.IsTrue(result.TryGetEntity(0, out msh));

                Assert.IsNotNull(msh);

                Assert.IsNotNull(msh.SendingApplication);
                Assert.IsTrue(msh.SendingApplication.IsPresent);
                Assert.IsTrue(msh.SendingApplication.HasValue);
                Assert.That(msh.SendingApplication.Value, Is.EqualTo("LIFTLAB"));

                result = await result.NextAsync(_parser);

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

            var result = _parser.Parse(text, new TextSpan(0, text.Length));

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
            Assert.IsFalse(msh.VersionId.IsPresent);
            Assert.IsFalse(msh.VersionId.HasValue);

            Assert.IsNotNull(msh.ContinuationPointer);
            Assert.IsFalse(msh.ContinuationPointer.IsPresent);

            Assert.IsNotNull(msh.Fields);
            Assert.IsTrue(msh.Fields.IsPresent);
            Assert.IsTrue(msh.Fields.HasValue);
            Assert.IsTrue(msh.Fields[0].HasValue);
            Assert.That(msh.Fields[0].Value, Is.EqualTo("LIFTLAB"));

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
        public void Should_fault_on_empty_message()
        {
            const string message = @"";

            var text = new StringText(message);

            Assert.That(() => _parser.Parse(text, new TextSpan(0, text.Length)), Throws.TypeOf<MacheteParserException>());
        }
    }
}