// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// LRL (SegmentMap) - Location Relationship
    /// </summary>
    public class LRLMap :
        HL7V26SegmentMap<LRL>
    {
        public LRLMap()
        {
            Id = "LRL";

            Name = "Location Relationship";

            Entity(x => x.PrimaryKeyValue, 1, x => x.IsRequired());
            Value(x => x.SegmentActionCode, 2);
            Entity(x => x.SegmentUniqueKey, 3);
            Entity(x => x.LocationRelationshipId, 4, x => x.IsRequired());
            Entity(x => x.OrganizationalLocationRelationshipValue, 5);
            Entity(x => x.PatientLocationRelationshipValue, 6);
        }
    }
}