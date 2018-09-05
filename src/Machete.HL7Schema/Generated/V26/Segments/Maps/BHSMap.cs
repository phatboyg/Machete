// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BHS (SegmentMap) - Batch Header
    /// </summary>
    public class BHSMap :
        HL7V26SegmentMap<BHS>
    {
        public BHSMap()
        {
            Id = "BHS";

            Name = "Batch Header";

            Value(x => x.BatchFieldSeparator, 1, x => x.IsRequired());
            Value(x => x.BatchEncodingCharacters, 2, x => x.IsRequired());
            Entity(x => x.BatchSendingApplication, 3);
            Entity(x => x.BatchSendingFacility, 4);
            Entity(x => x.BatchReceivingApplication, 5);
            Entity(x => x.BatchReceivingFacility, 6);
            Value(x => x.BatchCreationDateTime, 7, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.BatchSecurity, 8);
            Value(x => x.BatchNameIdType, 9);
            Value(x => x.BatchComment, 10);
            Value(x => x.BatchControlId, 11);
            Value(x => x.ReferenceBatchControlId, 12);
            Entity(x => x.BatchSendingNetworkAddress, 13);
            Entity(x => x.BatchReceivingNetworkAddress, 14);
        }
    }
}