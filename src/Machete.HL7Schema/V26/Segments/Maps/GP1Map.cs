// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// GP1 (SegmentMap) - Grouping/Reimbursement - Visit
    /// </summary>
    public class GP1Map :
        HL7V26SegmentMap<GP1>
    {
        public GP1Map()
        {
            Id = "GP1";

            Name = "Grouping/Reimbursement - Visit";

            Value(x => x.TypeOfBillCode, 1, x => x.IsRequired());
            Value(x => x.RevenueCode, 2);
            Value(x => x.OverallClaimDispositionCode, 3);
            Value(x => x.OCEEditPerVisitCode, 4);
            Entity(x => x.OutlierCost, 5);
        }
    }
}