// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RPI_I01 (Message) - 
    /// </summary>
    public interface RPI_I01 :
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
        /// UAC
        /// </summary>
        Segment<UAC> UAC { get; }

        /// <summary>
        /// MSA
        /// </summary>
        Segment<MSA> MSA { get; }

        /// <summary>
        /// PROVIDER
        /// </summary>
        GroupList<RPI_I01_PROVIDER> Provider { get; }

        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// NK1
        /// </summary>
        SegmentList<NK1> NK1 { get; }

        /// <summary>
        /// GUARANTOR_INSURANCE
        /// </summary>
        Group<RPI_I01_GUARANTOR_INSURANCE> GuarantorInsurance { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}