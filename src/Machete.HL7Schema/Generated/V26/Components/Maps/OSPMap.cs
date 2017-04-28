// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OSP (ComponentMap) - Occurrence Span Code and Date
    /// </summary>
    public class OSPMap :
        HL7ComponentMap<OSP>
    {
        public OSPMap()
        {
            Entity(x => x.OccurrenceSpanCode, 1);
            Value(x => x.OccurrenceSpanStartDate, 2, x => {x.Format = "LONGDATETIME2";});
            Value(x => x.OccurrenceSpanStopDate, 3, x => {x.Format = "LONGDATETIME3";});
        }
    }
}