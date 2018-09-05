// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDT (SegmentMap) - Table Row Data
    /// </summary>
    public class RDTMap :
        HL7V26SegmentMap<RDT>
    {
        public RDTMap()
        {
            Id = "RDT";

            Name = "Table Row Data";

            Value(x => x.ColumnValue, 1, x => x.IsRequired());
        }
    }
}