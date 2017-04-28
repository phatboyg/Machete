// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M01 (Message) - 
    /// </summary>
    public interface MFN_M01 :
        HL7Template
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
        /// MFI
        /// </summary>
        Segment<MFI> MFI { get; }

        /// <summary>
        /// MF
        /// </summary>
        GroupList<MFN_M01_MF> Mf { get; }
    }
}