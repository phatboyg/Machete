// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// GP2 (SegmentMap) - Grouping/Reimbursement - Procedure Line Item
    /// </summary>
    public class GP2Map :
        HL7V26SegmentMap<GP2>
    {
        public GP2Map()
        {
            Id = "GP2";

            Name = "Grouping/Reimbursement - Procedure Line Item";

            Value(x => x.RevenueCode, 1);
            Value(x => x.NumberOfServiceUnits, 2);
            Entity(x => x.Charge, 3);
            Value(x => x.ReimbursementActionCode, 4);
            Value(x => x.DenialOrRejectionCode, 5);
            Value(x => x.OCEEditCode, 6);
            Entity(x => x.AmbulatoryPaymentClassificationCode, 7);
            Value(x => x.ModifierEditCode, 8);
            Value(x => x.PaymentAdjustmentCode, 9);
            Value(x => x.PackagingStatusCode, 10);
            Entity(x => x.ExpectedCMSPaymentAmount, 11);
            Value(x => x.ReimbursementTypeCode, 12);
            Entity(x => x.CoPayAmount, 13);
            Value(x => x.PayRatePerServiceUnit, 14);
        }
    }
}