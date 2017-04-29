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
        HL7TemplateMap<MFN_M16_MATERIAL_ITEM_RECORD>
    {
        public MFN_M16_MATERIAL_ITEM_RECORDMap()
        {
            Segment(x => x.MFE, 0, x => x.Required = true);
            Segment(x => x.ITM, 1, x => x.Required = true);
            Segments(x => x.NTE, 2);
            Groups(x => x.Sterilization, 3);
            Groups(x => x.PurchasingVendor, 4);
            Groups(x => x.MaterialLocation, 5);
        }
    }
}