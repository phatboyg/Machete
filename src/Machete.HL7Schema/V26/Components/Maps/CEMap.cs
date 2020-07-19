namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CE (ComponentMap) - Coded Element
    /// </summary>
    public class CEMap :
        HL7V26ComponentMap<CE>
    {
        public CEMap()
        {
            Value(x => x.Identifier, 0);
            Value(x => x.Text, 1);
            Value(x => x.NameOfCodingSystem, 2);
            Value(x => x.AlternateIdentifier, 3);
            Value(x => x.AlternateText, 4);
            Value(x => x.NameOfAlternateCodingSystem, 5);
        }
    }
}