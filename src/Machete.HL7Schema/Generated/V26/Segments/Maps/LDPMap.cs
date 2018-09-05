// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// LDP (SegmentMap) - Location Department
    /// </summary>
    public class LDPMap :
        HL7V26SegmentMap<LDP>
    {
        public LDPMap()
        {
            Id = "LDP";

            Name = "Location Department";

            Entity(x => x.PrimaryKeyValue, 1, x => x.IsRequired());
            Entity(x => x.LocationDepartment, 2, x => x.IsRequired());
            Value(x => x.LocationService, 3);
            Entity(x => x.SpecialtyType, 4);
            Value(x => x.ValidPatientClasses, 5);
            Value(x => x.ActiveInactiveFlag, 6);
            Value(x => x.ActivationDate, 7, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.InactivationDate, 8, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.InactivatedReason, 9);
            Entity(x => x.VisitingHours, 10);
            Entity(x => x.ContactPhone, 11);
            Entity(x => x.LocationCostCenter, 12);
        }
    }
}