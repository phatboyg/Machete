// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RQD (SegmentMap) - Requisition Detail
    /// </summary>
    public class RQDMap :
        HL7V26SegmentMap<RQD>
    {
        public RQDMap()
        {
            Id = "RQD";

            Name = "Requisition Detail";

            Value(x => x.RequisitionLineNumber, 1);
            Entity(x => x.ItemCodeInternal, 2);
            Entity(x => x.ItemCodeExternal, 3);
            Entity(x => x.HospitalItemCode, 4);
            Value(x => x.RequisitionQuantity, 5);
            Entity(x => x.RequisitionUnitOfMeasure, 6);
            Value(x => x.CostCenterAccountNumber, 7);
            Value(x => x.ItemNaturalAccountCode, 8);
            Entity(x => x.DeliverToId, 9);
            Value(x => x.DateNeeded, 10, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
        }
    }
}