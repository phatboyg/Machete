// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RMI (SegmentMap) - Risk Management Incident
    /// </summary>
    public class RMIMap :
        HL7SegmentMap<RMI>
    {
        public RMIMap()
        {
            Id = "RMI";

            Name = "Risk Management Incident";

            Entity(x => x.RiskManagementIncidentCode, 1);
            Value(x => x.DateTimeIncident, 2, x => {x.Format = "LONGDATETIME2";});
            Entity(x => x.IncidentTypeCode, 3);
        }
    }
}