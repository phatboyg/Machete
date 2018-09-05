// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PYE (SegmentMap) - Payee Information
    /// </summary>
    public class PYEMap :
        HL7V26SegmentMap<PYE>
    {
        public PYEMap()
        {
            Id = "PYE";

            Name = "Payee Information";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Value(x => x.PayeeType, 2, x => x.IsRequired());
            Value(x => x.PayeeRelationshipToInvoicePatient, 3);
            Entity(x => x.PayeeIdentificationList, 4);
            Entity(x => x.PayeePersonName, 5);
            Entity(x => x.PayeeAddress, 6);
            Value(x => x.PaymentMethod, 7);
        }
    }
}