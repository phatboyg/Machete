namespace Machete.HL7.Testing
{
    using Machete.Testing;


    public class MacheteHL7TestContext :
        BaseMacheteTestContext,
        MacheteTestContext<HL7Entity>
    {
        protected MacheteHL7TestContext(ISchema<HL7Entity> schema)
        {
            Schema = schema ?? Machete.Schema.Factory.CreateHL7();
            Parser = Machete.Parser.Factory.CreateHL7(Schema);
        }

        public ISchema<HL7Entity> Schema { get; }
        public IParser<HL7Entity> Parser { get; }
    }
}