namespace Machete.X12.Testing
{
    using System.Linq;
    using Machete.Formatters;
    using Machete.Testing;
    using X12;


    public class X12MacheteTestHarness<TVersion, TSchema> :
        IMacheteTestHarness<TSchema>
        where TSchema : X12Entity
        where TVersion : TSchema
    {
        static readonly MacheteTestHarness<TSchema> _harness = new Harness();

        public ISchema<TSchema> Schema => _harness.Schema;
        public IEntityParser<TSchema> Parser => _harness.Parser;
        public IFormatter<TSchema> Formatter => _harness.Formatter;

        public string CleanupText(string text)
        {
            string cleaned = text
                .Replace("\r\n", "\r")
                .Replace("\n", "\r")
                .Replace("\r\r", "\r")
                .Trim('\r', '\n');

            string trimmed = string.Join("\r",
                cleaned.Split('\r').Select(line => line.TrimEnd('|')).ToArray());

            return trimmed;
        }


        class Harness :
            MacheteTestHarness<TSchema>
        {
            protected override ISchema<TSchema> CreateSchema()
            {
                return Machete.Schema.Factory.CreateX12<TSchema>(cfg => cfg.AddFromNamespaceContaining<TVersion>());
            }

            protected override IEntityParser<TSchema> CreateParser(ISchema<TSchema> schema)
            {
                return Machete.Parser.Factory.CreateX12(schema);
            }

            protected override IFormatter<TSchema> CreateFormatter(ISchema<TSchema> schema)
            {
                return Machete.Formatter.Factory.CreateX12(schema);
            }
        }
    }
}