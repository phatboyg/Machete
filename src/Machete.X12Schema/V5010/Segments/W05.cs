namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W05 :
        X12Segment
    {
        Value<string> OrderStatusCode { get; }
        
        Value<string> DepositorOrderNumber { get; }
        
        Value<string> PurchaseOrderNumber { get; }
        
        Value<int> LinkSequenceNumber { get; }
        
        Value<string> MasterReferenceNumber { get; }
        
        Value<string> TransactionTypeCode { get; }
        
        Value<string> ActionCode { get; }
        
        Value<string> PurchaseOrderTypeCode { get; }
    }
}