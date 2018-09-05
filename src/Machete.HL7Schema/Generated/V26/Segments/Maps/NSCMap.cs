// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NSC (SegmentMap) - Application Status Change
    /// </summary>
    public class NSCMap :
        HL7V26SegmentMap<NSC>
    {
        public NSCMap()
        {
            Id = "NSC";

            Name = "Application Status Change";

            Value(x => x.ApplicationChangeType, 1, x => {x.Required = true;});
            Value(x => x.CurrentCPU, 2);
            Value(x => x.CurrentFileServer, 3);
            Entity(x => x.CurrentApplication, 4);
            Entity(x => x.CurrentFacility, 5);
            Value(x => x.NewCPU, 6);
            Value(x => x.NewFileServer, 7);
            Entity(x => x.NewApplication, 8);
            Entity(x => x.NewFacility, 9);
        }
    }
}