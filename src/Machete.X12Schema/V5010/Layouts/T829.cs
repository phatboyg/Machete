namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T829 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<PCR> PaymentCancellationRequest { get; }
        
        Segment<TRN> Trace { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
        
        Segment<REF> ReferenceIdentification { get; }

        Segment<QTY> Quantity { get; }

        Segment<AMT> MonetaryAmount { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}