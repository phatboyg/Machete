// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M16_MATERIAL_ITEM_RECORD (Group) - 
    /// </summary>
    public interface MFN_M16_MATERIAL_ITEM_RECORD :
        HL7V26Layout
    {
        /// <summary>
        /// MFE
        /// </summary>
        Segment<MFE> MFE { get; }

        /// <summary>
        /// ITM
        /// </summary>
        Segment<ITM> ITM { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// STERILIZATION
        /// </summary>
        LayoutList<MFN_M16_STERILIZATION> Sterilization { get; }

        /// <summary>
        /// PURCHASING_VENDOR
        /// </summary>
        LayoutList<MFN_M16_PURCHASING_VENDOR> PurchasingVendor { get; }

        /// <summary>
        /// MATERIAL_LOCATION
        /// </summary>
        LayoutList<MFN_M16_MATERIAL_LOCATION> MaterialLocation { get; }
    }
}