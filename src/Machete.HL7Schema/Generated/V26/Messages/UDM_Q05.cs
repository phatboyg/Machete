// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// UDM_Q05 (Message) - 
    /// </summary>
    public interface UDM_Q05 :
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
        /// URD
        /// </summary>
        Segment<URD> URD { get; }

        /// <summary>
        /// URS
        /// </summary>
        Segment<URS> URS { get; }

        /// <summary>
        /// DSP
        /// </summary>
        SegmentList<DSP> DSP { get; }

        /// <summary>
        /// DSC
        /// </summary>
        Segment<DSC> DSC { get; }
    }
}