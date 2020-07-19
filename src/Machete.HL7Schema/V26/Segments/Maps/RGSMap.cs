// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RGS (SegmentMap) - Resource Group
    /// </summary>
    public class RGSMap :
        HL7V26SegmentMap<RGS>
    {
        public RGSMap()
        {
            Id = "RGS";

            Name = "Resource Group";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Value(x => x.SegmentActionCode, 2);
            Entity(x => x.ResourceGroupId, 3);
        }
    }
}