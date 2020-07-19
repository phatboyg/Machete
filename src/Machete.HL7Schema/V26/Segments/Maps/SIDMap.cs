// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SID (SegmentMap) - Substance Identifier
    /// </summary>
    public class SIDMap :
        HL7V26SegmentMap<SID>
    {
        public SIDMap()
        {
            Id = "SID";

            Name = "Substance Identifier";

            Entity(x => x.ApplicationMethodIdentifier, 1);
            Value(x => x.SubstanceLotNumber, 2);
            Value(x => x.SubstanceContainerIdentifier, 3);
            Entity(x => x.SubstanceManufacturerIdentifier, 4);
        }
    }
}