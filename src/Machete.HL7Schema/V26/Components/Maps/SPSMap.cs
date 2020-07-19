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
        HL7V26ComponentMap<SPS>
    {
        public SPSMap()
        {
            Entity(x => x.SpecimenSourceNameOrCode, 0);
            Entity(x => x.Additives, 1);
            Value(x => x.SpecimenCollectionMethod, 2);
            Entity(x => x.BodySite, 3);
            Entity(x => x.SiteModifier, 4);
            Entity(x => x.CollectionMethodModifierCode, 5);
            Entity(x => x.SpecimenRole, 6);
        }
    }
}