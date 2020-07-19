// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ECD (SegmentMap) - Equipment Command
    /// </summary>
    public class ECDMap :
        HL7V26SegmentMap<ECD>
    {
        public ECDMap()
        {
            Id = "ECD";

            Name = "Equipment Command";

            Value(x => x.ReferenceCommandNumber, 1, x => x.IsRequired());
            Entity(x => x.RemoteControlCommand, 2, x => x.IsRequired());
            Value(x => x.ResponseRequired, 3);
            Entity(x => x.RequestedCompletionTime, 4);
            Value(x => x.Parameters, 5);
        }
    }
}