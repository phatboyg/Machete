// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RDR_RDR (Message) - 
    /// </summary>
    public interface RDR_RDR :
        HL7V26Layout
    {
        /// <summary>
        /// MSH
        /// </summary>
        Segment<MSH> MSH { get; }

        /// <summary>
        /// MSA
        /// </summary>
        Segment<MSA> MSA { get; }

        /// <summary>
        /// ERR
        /// </summary>
        SegmentList<ERR> ERR { get; }

        /// <summary>
        /// SFT
        /// </summary>
        SegmentList<SFT> SFT { get; }

        /// <summary>
        /// SFT2
        /// </summary>
        Segment<SFT> SFT2 { get; }

        /// <summary>
        /// UAC
        /// </summary>
        Segment<UAC> UAC { get; }

        /// <summary>
        /// DEFINITION
        /// </summary>
        LayoutList<RDR_RDR_DEFINITION> Definition { get; }

        /// <summary>
        /// RXC
        /// </summary>
        SegmentList<RXC> RXC { get; }

        /// <summary>
        /// DSC
        /// </summary>
        Segment<DSC> DSC { get; }

        /// <summary>
        /// RXD
        /// </summary>
        Segment<RXD> RXD { get; }

        /// <summary>
        /// RXR
        /// </summary>
        SegmentList<RXR> RXR { get; }

        /// <summary>
        /// RXC2
        /// </summary>
        SegmentList<RXC> RXC2 { get; }

        /// <summary>
        /// DSC2
        /// </summary>
        Segment<DSC> DSC2 { get; }
    }
}