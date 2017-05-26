namespace Machete.HL7.Testing
{
    using Machete.Testing;


    public class HL7MacheteTestHarness<TVersion, TSchema> :
        MacheteTestHarness<TSchema>
        where TSchema : HL7Entity
        where TVersion : TSchema
    {
        protected override ISchema<TSchema> CreateSchema()
        {
            return Machete.Schema.Factory.CreateHL7<TSchema>(cfg => cfg.AddFromNamespaceContaining<TVersion>());
        }

        protected override IParser<TSchema> CreateParser(ISchema<TSchema> schema)
        {
            return Machete.Parser.Factory.CreateHL7(schema);
        }
    }
}