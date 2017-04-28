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
            Map(x => x.MFE, 0, x => x.Required = true);
            Map(x => x.ITM, 1, x => x.Required = true);
            Map(x => x.NTE, 2);
            Map(x => x.Sterilization, 3);
            Map(x => x.PurchasingVendor, 4);
            Map(x => x.MaterialLocation, 5);
        }
    }
}