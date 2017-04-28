// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SPD (ComponentMap) - Specialty Description
    /// </summary>
    public class SPDMap :
        HL7ComponentMap<SPD>
    {
        public SPDMap()
        {
            Value(x => x.SpecialtyName, 1);
            Value(x => x.GoverningBoard, 2);
            Value(x => x.EligibleOrCertified, 3);
            Value(x => x.DateOfCertification, 4, x => {x.Format = "LONGDATETIME4";});
        }
    }
}