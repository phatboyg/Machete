// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PPP_PCB_PATHWAY (Group) - 
    /// </summary>
    public interface PPP_PCB_PATHWAY :
        HL7Template
    {
        /// <summary>
        /// PTH
        /// </summary>
        Segment<PTH> PTH { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// VAR
        /// </summary>
        SegmentList<VAR> VAR { get; }

        /// <summary>
        /// PATHWAY_ROLE
        /// </summary>
        GroupList<PPP_PCB_PATHWAY_ROLE> PathwayRole { get; }

        /// <summary>
        /// PROBLEM
        /// </summary>
        GroupList<PPP_PCB_PROBLEM> Problem { get; }
    }
}