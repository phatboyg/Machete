// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CX (ComponentMap) - Extended Composite ID with Check Digit
    /// </summary>
    public class CXMap :
        HL7V26ComponentMap<CX>
    {
        public CXMap()
        {
            Value(x => x.IdNumber, 0);
            Value(x => x.IdentifierCheckDigit, 1);
            Value(x => x.CheckDigitScheme, 2);
            Entity(x => x.AssigningAuthority, 3);
            Value(x => x.IdentifierTypeCode, 4);
            Entity(x => x.AssigningFacility, 5);
            Value(x => x.EffectiveDate, 6, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ExpirationDate, 7, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.AssigningJurisdiction, 8);
            Entity(x => x.AssigningAgencyOrDepartment, 9);
        }
    }
}