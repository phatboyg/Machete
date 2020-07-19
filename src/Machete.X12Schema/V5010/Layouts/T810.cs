namespace Machete.X12Schema.V5010
{
    using Segments;
    using X12;


    public interface T810 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BIG> BeginningSegmentForInvoice { get; }
        
        SegmentList<NTE> NotesOrSpecialInstructions { get; }
        
        Segment<CUR> Currency { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<YNQ> YesNoQuestion { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        LayoutList<LoopN1> LoopN1 { get; }
        
        SegmentList<ITD> TermsOfSale { get; }
        
        SegmentList<DTM> DateTimeReference { get; }
        
        Segment<FOB> FOBRelatedInstructions { get; }
        
        SegmentList<PID> ProductOrItemDescription { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        SegmentList<PWK> Paperwork { get; }
        
        SegmentList<PKG> MarkingPackagingOrLoadingRequirements { get; }
        
        Segment<L7> TariffReference { get; }
        
        SegmentList<BAL> BalanceDetails { get; }
        
        Segment<INC> InstallmentInformation { get; }
        
        SegmentList<PAM> PeriodAmount { get; }
        
        Segment<CRC> ConditionsIndicator { get; }
        
        LayoutList<LoopLM> LoopLM { get; }
        
        Layout<LoopN9> LoopN9 { get; }
        
        LayoutList<LoopV1> LoopV1 { get; }
        
        Layout<LoopFA1> LoopFA1 { get; }
        
        LayoutList<LoopIT1> LoopIT1 { get; }
        
        Segment<TDS> TotalMonetaryValueSummary { get; }
        
        SegmentList<TXI> TaxInformation { get; }
        
        Segment<CAD> CarrierDetails { get; }
        
        SegmentList<AMT> MonetaryAmountInformation { get; }
        
        LayoutList<LoopSAC> LoopSAC { get; }
        
        LayoutList<LoopISS> LoopISS { get; }
        
        Segment<CTT> TransactionTotals { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}