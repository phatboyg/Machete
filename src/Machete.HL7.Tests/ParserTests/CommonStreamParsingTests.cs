namespace Machete.HL7.Tests.ParserTests
{
    using System;
    using System.Threading.Tasks;
    using HL7Schema.V26;
    using NUnit.Framework;
    using Testing;
    using Texts;


    [TestFixture]
    public class CommonStreamParsingTests :
        HL7MacheteTestHarness<MSH, HL7Entity>
    {
        [Test]
        public async Task Should_navigate_the_blocks_when_crossed()
        {
            const string block1 = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ORU^R01";
            const string block2 = @"|K113|P|";
            const string nl = "\n";
            const string block3 = @"MSH|^~\&|LIFTLAB||UBERMED||201701131234||ADT^A04";
            const string block4 = @"|K113|P|";

            var first = await new StringStreamTextReader(new[] {block1, block2, nl, block3, block4}, Environment.NewLine).Text;

            ParseResult<HL7Entity> result = await Parser.ParseStream(first, new TextSpan(0, first.Length));
            
            while (result.TryGetEntity(0, out MSH msh))
            {
                Console.WriteLine(msh.MessageType.Select(x => x.TriggerEvent).ValueOrDefault("not-present"));

                result = await result.NextAsync();
            }
        }
    }
}