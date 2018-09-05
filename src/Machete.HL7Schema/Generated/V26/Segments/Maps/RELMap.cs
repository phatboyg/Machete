// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// REL (SegmentMap) - Clinical Relationship Segment
    /// </summary>
    public class RELMap :
        HL7V26SegmentMap<REL>
    {
        public RELMap()
        {
            Id = "REL";

            Name = "Clinical Relationship Segment";

            Value(x => x.SetId, 1);
            Entity(x => x.RelationshipType, 2, x => {x.Required = true;});
            Entity(x => x.ThiRelationshipInstanceIdentifier, 3, x => {x.Required = true;});
            Entity(x => x.SourceInformationInstanceIdentifier, 4, x => {x.Required = true;});
            Entity(x => x.TargetInformationInstanceIdentifier, 5, x => {x.Required = true;});
            Entity(x => x.AssertingEntityInstanceId, 6);
            Entity(x => x.AssertingPerson, 7);
            Entity(x => x.AssertingOrganization, 8);
            Entity(x => x.AssertorAddress, 9);
            Entity(x => x.AssertorContact, 10);
            Entity(x => x.AssertionDateRange, 11);
            Value(x => x.NegationIndicator, 12);
            Entity(x => x.CertaintyOfRelationship, 13);
            Value(x => x.PriorityNumber, 14);
            Value(x => x.PrioritySequenceNumber, 15);
            Value(x => x.SeparabilityIndicator, 16);
        }
    }
}