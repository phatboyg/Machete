// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// TCD (SegmentMap) - Test Code Detail
    /// </summary>
    public class TCDMap :
        HL7V26SegmentMap<TCD>
    {
        public TCDMap()
        {
            Id = "TCD";

            Name = "Test Code Detail";

            Entity(x => x.UniversalServiceIdentifier, 1, x => {x.Required = true;});
            Entity(x => x.AutoDilutionFactor, 2);
            Entity(x => x.RerunDilutionFactor, 3);
            Entity(x => x.PreDilutionFactor, 4);
            Entity(x => x.EndogenousContentOfPreDilutionDiluent, 5);
            Value(x => x.AutomaticRepeatAllowed, 6);
            Value(x => x.ReflexAllowed, 7);
            Entity(x => x.AnalyteRepeatStatus, 8);
        }
    }
}