// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// REL (Segment) - Clinical Relationship Segment
    /// </summary>
    public interface REL :
        HL7V26Segment
    {
        /// <summary>
        /// REL-1: Set ID -REL
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// REL-2: Relationship Type
        /// </summary>
        Value<CWE> RelationshipType { get; }

        /// <summary>
        /// REL-3: This Relationship Instance Identifier
        /// </summary>
        Value<EI> ThiRelationshipInstanceIdentifier { get; }

        /// <summary>
        /// REL-4: Source Information Instance Identifier
        /// </summary>
        Value<EI> SourceInformationInstanceIdentifier { get; }

        /// <summary>
        /// REL-5: Target Information Instance Identifier
        /// </summary>
        Value<EI> TargetInformationInstanceIdentifier { get; }

        /// <summary>
        /// REL-6: Asserting Entity Instance ID
        /// </summary>
        Value<EI> AssertingEntityInstanceId { get; }

        /// <summary>
        /// REL-7: Asserting Person
        /// </summary>
        Value<XCN> AssertingPerson { get; }

        /// <summary>
        /// REL-8: Asserting Organization
        /// </summary>
        Value<XON> AssertingOrganization { get; }

        /// <summary>
        /// REL-9: Assertor Address
        /// </summary>
        Value<XAD> AssertorAddress { get; }

        /// <summary>
        /// REL-10: Assertor Contact
        /// </summary>
        Value<XTN> AssertorContact { get; }

        /// <summary>
        /// REL-11: Assertion Date Range
        /// </summary>
        Value<DR> AssertionDateRange { get; }

        /// <summary>
        /// REL-12: Negation Indicator
        /// </summary>
        Value<string> NegationIndicator { get; }

        /// <summary>
        /// REL-13: Certainty of Relationship
        /// </summary>
        Value<CWE> CertaintyOfRelationship { get; }

        /// <summary>
        /// REL-14: Priority No
        /// </summary>
        Value<decimal> PriorityNumber { get; }

        /// <summary>
        /// REL-15: Priority  Sequence Number (rel preference for consideration)
        /// </summary>
        Value<decimal> PrioritySequenceNumber { get; }

        /// <summary>
        /// REL-16: Separability Indicator
        /// </summary>
        Value<string> SeparabilityIndicator { get; }
    }
}