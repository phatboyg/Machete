// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MRG (SegmentMap) - Merge Patient Information
    /// </summary>
    public class MRGMap :
        HL7V26SegmentMap<MRG>
    {
        public MRGMap()
        {
            Id = "MRG";

            Name = "Merge Patient Information";

            Entity(x => x.PriorPatientIdentifierList, 1, x => x.IsRequired());
            Entity(x => x.PriorAlternatePatientId, 2);
            Entity(x => x.PriorPatientAccountNumber, 3);
            Entity(x => x.PriorPatientId, 4);
            Entity(x => x.PriorVisitNumber, 5);
            Entity(x => x.PriorAlternateVisitId, 6);
            Entity(x => x.PriorPatientName, 7);
        }
    }
}