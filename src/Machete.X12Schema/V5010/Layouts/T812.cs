namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T812 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BCD> BeginningCreditOrDebitAdjustment { get; }
        
        Segment<CUR> Currency { get; }
        
        SegmentList<N9> ReferenceIdentification { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<ITD> TermsOfSale { get; }
        
        SegmentList<DTM> DateTimeReference { get; }
        
        Segment<FOB> FOBRelatedInstructions { get; }
        
        SegmentList<SHD> ShipmentDetail { get; }
        
        SegmentList<SAC> ServicePromotionAllowanceOrChargeInformation { get; }
        
        LayoutList<LoopN1_1_812> LoopN1 { get; }
        
        LayoutList<LoopLM> LoopLM { get; }
        
        LayoutList<LoopFA1> LoopFA1 { get; }
        
        LayoutList<LoopCDD_812> LoopCDD { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}