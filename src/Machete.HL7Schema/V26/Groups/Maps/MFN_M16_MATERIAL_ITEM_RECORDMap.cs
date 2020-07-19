// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M16_MATERIAL_ITEM_RECORD (GroupMap) - 
    /// </summary>
    public class MFN_M16_MATERIAL_ITEM_RECORDMap :
        HL7V26LayoutMap<MFN_M16_MATERIAL_ITEM_RECORD>
    {
        public MFN_M16_MATERIAL_ITEM_RECORDMap()
        {
            Segment(x => x.MFE, 0, x => x.Required = true);
            Segment(x => x.ITM, 1, x => x.Required = true);
            Segment(x => x.NTE, 2);
            Layout(x => x.Sterilization, 3);
            Layout(x => x.PurchasingVendor, 4);
            Layout(x => x.MaterialLocation, 5);
        }
    }
}