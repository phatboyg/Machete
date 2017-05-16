// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SDR_S31 (Message) - 
    /// </summary>
    public interface SDR_S31 :
        HL7Layout
    {
        /// <summary>
        /// MSH
        /// </summary>
        Segment<MSH> MSH { get; }

        /// <summary>
        /// SFT
        /// </summary>
        SegmentList<SFT> SFT { get; }

        /// <summary>
        /// UAC
        /// </summary>
        Segment<UAC> UAC { get; }

        /// <summary>
        /// SDD
        /// </summary>
        Segment<SDD> SDD { get; }

        /// <summary>
        /// SCD
        /// </summary>
        SegmentList<SCD> SCD { get; }
    }
}