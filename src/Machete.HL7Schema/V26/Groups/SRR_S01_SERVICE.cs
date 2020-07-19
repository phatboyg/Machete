// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SRR_S01_SERVICE (Group) - 
    /// </summary>
    public interface SRR_S01_SERVICE :
        HL7V26Layout
    {
        /// <summary>
        /// AIS
        /// </summary>
        Segment<AIS> AIS { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}