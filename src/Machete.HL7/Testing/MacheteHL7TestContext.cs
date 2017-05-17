namespace Machete.HL7.Testing
{
    using Machete.Testing;

    public class MacheteHL7TestContext :
        BaseMacheteTestContext,
        MacheteTestContext<HL7Entity>
    {
        public MacheteHL7TestContext()
        {
        }

        public IParser<HL7Entity> Parser { get; }
    }
}