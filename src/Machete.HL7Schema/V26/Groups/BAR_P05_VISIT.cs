// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// BAR_P05_VISIT (Group) - 
    /// </summary>
    public interface BAR_P05_VISIT :
        HL7V26Layout
    {
        /// <summary>
        /// PV1
        /// </summary>
        Segment<PV1> PV1 { get; }

        /// <summary>
        /// PV2
        /// </summary>
        Segment<PV2> PV2 { get; }

        /// <summary>
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }

        /// <summary>
        /// DB1
        /// </summary>
        SegmentList<DB1> DB1 { get; }

        /// <summary>
        /// OBX
        /// </summary>
        SegmentList<OBX> OBX { get; }

        /// <summary>
        /// AL1
        /// </summary>
        SegmentList<AL1> AL1 { get; }

        /// <summary>
        /// DG1
        /// </summary>
        SegmentList<DG1> DG1 { get; }

        /// <summary>
        /// DRG
        /// </summary>
        Segment<DRG> DRG { get; }

        /// <summary>
        /// PROCEDURE
        /// </summary>
        LayoutList<BAR_P05_PROCEDURE> Procedure { get; }

        /// <summary>
        /// GT1
        /// </summary>
        SegmentList<GT1> GT1 { get; }

        /// <summary>
        /// NK1
        /// </summary>
        SegmentList<NK1> NK1 { get; }

        /// <summary>
        /// INSURANCE
        /// </summary>
        LayoutList<BAR_P05_INSURANCE> Insurance { get; }

        /// <summary>
        /// ACC
        /// </summary>
        Segment<ACC> ACC { get; }

        /// <summary>
        /// UB1
        /// </summary>
        Segment<UB1> UB1 { get; }

        /// <summary>
        /// UB2
        /// </summary>
        Segment<UB2> UB2 { get; }

        /// <summary>
        /// ABS
        /// </summary>
        Segment<ABS> ABS { get; }

        /// <summary>
        /// BLC
        /// </summary>
        SegmentList<BLC> BLC { get; }

        /// <summary>
        /// RMI
        /// </summary>
        Segment<RMI> RMI { get; }
    }
}