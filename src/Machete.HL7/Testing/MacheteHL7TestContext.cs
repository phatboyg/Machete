namespace Machete.HL7.Testing
{
    using System;
    using Machete.Testing;


    public class MacheteHL7TestContext<TSchemaVersion> :
        BaseMacheteTestContext,
        MacheteTestContext<HL7Entity>
    {
        readonly Lazy<ISchema<HL7Entity>> _schema;
        readonly Lazy<IParser<HL7Entity>> _parser;

        protected MacheteHL7TestContext(ISchema<HL7Entity> schema)
        {
            _schema = new Lazy<ISchema<HL7Entity>>(() => schema ?? Machete.Schema.Factory.LoadHL7<TSchemaVersion>());
            _parser = new Lazy<IParser<HL7Entity>>(() => Machete.Parser.Factory.CreateHL7(Schema));
        }

        protected MacheteHL7TestContext()
        {
            _schema = new Lazy<ISchema<HL7Entity>>(() => Machete.Schema.Factory.LoadHL7<TSchemaVersion>());
            _parser = new Lazy<IParser<HL7Entity>>(() => Machete.Parser.Factory.CreateHL7(Schema));
        }

        public ISchema<HL7Entity> Schema => _schema.Value;
        public IParser<HL7Entity> Parser => _parser.Value;
    }
}