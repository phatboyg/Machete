// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DSP (SegmentMap) - Display Data
    /// </summary>
    public class DSPMap :
        HL7V26SegmentMap<DSP>
    {
        public DSPMap()
        {
            Id = "DSP";

            Name = "Display Data";

            Value(x => x.SetId, 1);
            Value(x => x.DisplayLevel, 2);
            Value(x => x.DataLine, 3, x => x.IsRequired());
            Value(x => x.LogicalBreakPoint, 4);
            Value(x => x.ResultId, 5);
        }
    }
}