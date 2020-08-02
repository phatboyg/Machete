namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W05Map :
        X12SegmentMap<W05, X12Entity>
    {
        public W05Map()
        {
            Id = "W05";
            Name = "Shipping Order Identification";
            
            Value(x => x.OrderStatusCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.DepositorOrderNumber, 2, x => x.MinLength(1).MaxLength(22).IsRequired());
            Value(x => x.PurchaseOrderNumber, 3, x => x.MinLength(1).MaxLength(22));
            Value(x => x.LinkSequenceNumber, 4, x => x.FixedLength(6));
            Value(x => x.MasterReferenceNumber, 5, x => x.MinLength(1).MaxLength(22));
            Value(x => x.TransactionTypeCode, 6, x => x.FixedLength(2));
            Value(x => x.ActionCode, 7, x => x.MinLength(1).MaxLength(2));
            Value(x => x.PurchaseOrderTypeCode, 8, x => x.FixedLength(2));
        }
    }
}