// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ISD (SegmentMap) - Interaction Status Detail
    /// </summary>
    public class ISDMap :
        HL7V26SegmentMap<ISD>
    {
        public ISDMap()
        {
            Id = "ISD";

            Name = "Interaction Status Detail";

            Value(x => x.ReferenceInteractionNumber, 1, x => x.IsRequired());
            Entity(x => x.InteractionTypeIdentifier, 2);
            Entity(x => x.InteractionActiveState, 3, x => x.IsRequired());
        }
    }
}