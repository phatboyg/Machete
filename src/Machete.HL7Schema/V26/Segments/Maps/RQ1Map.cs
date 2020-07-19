// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RQ1 (SegmentMap) - Requisition Detail-1
    /// </summary>
    public class RQ1Map :
        HL7V26SegmentMap<RQ1>
    {
        public RQ1Map()
        {
            Id = "RQ1";

            Name = "Requisition Detail-1";

            Value(x => x.AnticipatedPrice, 1);
            Entity(x => x.ManufacturerIdentifier, 2);
            Value(x => x.ManufacturerSCatalog, 3);
            Entity(x => x.VendorId, 4);
            Value(x => x.VendorCatalog, 5);
            Value(x => x.Taxable, 6);
            Value(x => x.SubstituteAllowed, 7);
        }
    }
}