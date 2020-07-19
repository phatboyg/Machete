// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RXR (SegmentMap) - Pharmacy/Treatment Route
    /// </summary>
    public class RXRMap :
        HL7V26SegmentMap<RXR>
    {
        public RXRMap()
        {
            Id = "RXR";

            Name = "Pharmacy/Treatment Route";

            Entity(x => x.Route, 1, x => x.IsRequired());
            Entity(x => x.AdministrationSite, 2);
            Entity(x => x.AdministrationDevice, 3);
            Entity(x => x.AdministrationMethod, 4);
            Entity(x => x.RoutingInstruction, 5);
            Entity(x => x.AdministrationSiteModifier, 6);
        }
    }
}