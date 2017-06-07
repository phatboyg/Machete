// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PMU_B08 (Message) - 
    /// </summary>
    public interface PMU_B08 :
        HL7V26Layout
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
        /// EVN
        /// </summary>
        Segment<EVN> EVN { get; }

        /// <summary>
        /// STF
        /// </summary>
        Segment<STF> STF { get; }

        /// <summary>
        /// PRA
        /// </summary>
        Segment<PRA> PRA { get; }

        /// <summary>
        /// CER
        /// </summary>
        SegmentList<CER> CER { get; }
    }
}