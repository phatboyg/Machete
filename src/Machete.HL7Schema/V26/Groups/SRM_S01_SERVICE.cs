// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SRM_S01_SERVICE (Group) - 
    /// </summary>
    public interface SRM_S01_SERVICE :
        HL7V26Layout
    {
        /// <summary>
        /// AIS
        /// </summary>
        Segment<AIS> AIS { get; }

        /// <summary>
        /// APR
        /// </summary>
        Segment<APR> APR { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}