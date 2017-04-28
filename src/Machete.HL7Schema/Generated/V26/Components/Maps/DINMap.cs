// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DIN (ComponentMap) - Date and Institution Name
    /// </summary>
    public class DINMap :
        HL7ComponentMap<DIN>
    {
        public DINMap()
        {
            Value(x => x.Date, 1, x => {x.Format = "LONGDATETIME1";});
            Entity(x => x.InstitutionName, 2);
        }
    }
}