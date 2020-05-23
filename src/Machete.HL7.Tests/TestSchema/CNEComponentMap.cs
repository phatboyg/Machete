namespace Machete.HL7.Tests.TestSchema
{
    public class CNEComponentMap :
        HL7ComponentMap<CNEComponent, HL7Component>
    {
        public CNEComponentMap()
        {
            Value(x => x.Identifier, 0);
            Value(x => x.Text, 1);
            Value(x => x.NameOfCodingSystem, 2);
            Value(x => x.AlternateIdentifier, 3);
            Value(x => x.AlternateText, 4);
            Value(x => x.NameOfAlternateCodingSystem, 5);
            Value(x => x.CodingSystemVersionId, 6);
            Value(x => x.AlternateCodingSystemVersionId, 7);
            Value(x => x.OriginalText, 8);
        }
    }
}