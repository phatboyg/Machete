// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PRL (ComponentMap) - Parent Result Link
    /// </summary>
    public class PRLMap :
        HL7ComponentMap<PRL>
    {
        public PRLMap()
        {
            Entity(x => x.ParentObservationIdentifier, 0);
            Value(x => x.ParentObservationSubIdentifier, 1);
            Value(x => x.ParentObservationValueDescriptor, 2);
        }
    }
}