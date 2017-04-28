// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SPS (ComponentMap) - Specimen Source
    /// </summary>
    public class SPSMap :
        HL7ComponentMap<SPS>
    {
        public SPSMap()
        {
            Entity(x => x.SpecimenSourceNameOrCode, 1);
            Entity(x => x.Additives, 2);
            Value(x => x.SpecimenCollectionMethod, 3);
            Entity(x => x.BodySite, 4);
            Entity(x => x.SiteModifier, 5);
            Entity(x => x.CollectionMethodModifierCode, 6);
            Entity(x => x.SpecimenRole, 7);
        }
    }
}