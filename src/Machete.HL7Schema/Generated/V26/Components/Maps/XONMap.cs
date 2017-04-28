// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// XON (ComponentMap) - Extended Composite Name and Identification Number for Organizations
    /// </summary>
    public class XONMap :
        HL7ComponentMap<XON>
    {
        public XONMap()
        {
            Value(x => x.OrganizationName, 1);
            Value(x => x.OrganizationNameTypeCode, 2);
            Value(x => x.IdNumber, 3);
            Value(x => x.IdentifierCheckDigit, 4);
            Value(x => x.CheckDigitScheme, 5);
            Entity(x => x.AssigningAuthority, 6);
            Value(x => x.IdentifierTypeCode, 7);
            Entity(x => x.AssigningFacility, 8);
            Value(x => x.NameRepresentationCode, 9);
            Value(x => x.OrganizationIdentifier, 10);
        }
    }
}