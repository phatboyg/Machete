// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E01 (Message) - 
    /// </summary>
    public interface EHC_E01 :
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
        SegmentList<UAC> UAC { get; }

        /// <summary>
        /// IVC
        /// </summary>
        Segment<IVC> IVC { get; }

        /// <summary>
        /// PYE
        /// </summary>
        Segment<PYE> PYE { get; }

        /// <summary>
        /// CTD
        /// </summary>
        SegmentList<CTD> CTD { get; }

        /// <summary>
        /// AUT
        /// </summary>
        Segment<AUT> AUT { get; }

        /// <summary>
        /// LOC
        /// </summary>
        SegmentList<LOC> LOC { get; }

        /// <summary>
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }

        /// <summary>
        /// PRODUCT_SERVICE_SECTION
        /// </summary>
        GroupList<EHC_E01_PRODUCT_SERVICE_SECTION> ProductServiceSection { get; }
    }
}