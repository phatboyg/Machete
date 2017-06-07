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
        HL7V26ComponentMap<SPD>
    {
        public SPDMap()
        {
            Value(x => x.SpecialtyName, 0);
            Value(x => x.GoverningBoard, 1);
            Value(x => x.EligibleOrCertified, 2);
            Value(x => x.DateOfCertification, 3, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
        }
    }
}