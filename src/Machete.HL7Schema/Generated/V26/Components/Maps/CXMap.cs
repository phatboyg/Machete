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
        HL7ComponentMap<CX>
    {
        public CXMap()
        {
            Value(x => x.IdNumber, 1);
            Value(x => x.IdentifierCheckDigit, 2);
            Value(x => x.CheckDigitScheme, 3);
            Entity(x => x.AssigningAuthority, 4);
            Value(x => x.IdentifierTypeCode, 5);
            Entity(x => x.AssigningFacility, 6);
            Value(x => x.EffectiveDate, 7, x => {x.Format = "LONGDATETIME7";});
            Value(x => x.ExpirationDate, 8, x => {x.Format = "LONGDATETIME8";});
            Entity(x => x.AssigningJurisdiction, 9);
            Entity(x => x.AssigningAgencyOrDepartment, 10);
        }
    }
}