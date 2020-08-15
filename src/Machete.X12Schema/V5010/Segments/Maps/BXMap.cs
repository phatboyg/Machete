namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class BXMap :
        X12SegmentMap<BX, X12Entity>
    {
        public BXMap()
        {
            Id = "BX";
            Name = "General Shipment Information";
            
            Value(x => x.TransactionSetPurposeCode, 1, x=> x.FixedLength(2));

            Value(x => x.TransportationMethodCode, 2, x => x.MinLength(1).MaxLength(2));
            
            Value(x => x.ShipmentMethodOfPayment, 3, x => x.FixedLength(2));
            
            Value(x => x.ShipmentIdentificationNumber, 4, x=> x.MinLength(1).MaxLength(30));

            Value(x => x.StandardCarrierAlphaCode, 5, x => x.MinLength(2).MaxLength(4));
            
            Value(x => x.WeightUnitCode, 6, x => x.FixedLength(1));
            
            Value(x => x.ShipmentQualifier, 7, x => x.FixedLength(1));
            
            Value(x => x.SectionSevenCode, 8, x => x.FixedLength(1));
            
            Value(x => x.CapacityLoadCode, 9, x => x.FixedLength(1));
            
            Value(x => x.StatusReportRequestCode, 10, x => x.FixedLength(1));
            
            Value(x => x.CustomsDocumentationHandlingCode, 11, x => x.FixedLength(2));
            
            Value(x => x.ConfidentialBillingRequestCode, 12, x => x.FixedLength(1));
            
            Value(x => x.GoodsAndServicesTaxReasonCode, 13, x => x.FixedLength(1));
            
            Value(x => x.ApplicationType, 14, x => x.FixedLength(2));
        }
    }
}