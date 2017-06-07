// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DMI (SegmentMap) - DRG Master File Information
    /// </summary>
    public class DMIMap :
        HL7V26SegmentMap<DMI>
    {
        public DMIMap()
        {
            Id = "DMI";

            Name = "DRG Master File Information";

            Entity(x => x.DiagnosticRelatedGroup, 1);
            Entity(x => x.MajorDiagnosticCategory, 2);
            Entity(x => x.LowerAndUpperTrimPoints, 3);
            Value(x => x.AverageLengthOfStay, 4);
            Value(x => x.RelativeWeight, 5);
        }
    }
}