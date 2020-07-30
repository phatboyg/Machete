namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T846 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }

        Segment<BIA> BeginningInventoryInvoice { get; }

        Segment<CUR> Currency { get; }

        SegmentList<DTM> DateOrTimeReference { get; }

        SegmentList<REF> ReferenceInformation { get; }

        SegmentList<PER> AdministrativeCommunicationsContact { get; }

        SegmentList<MEA> Measurements { get; }

        LayoutList<LoopN1_846> LoopN1 { get; }

        LayoutList<LoopLM_846> LoopLM { get; }

        LayoutList<LoopLIN_846> LoopLIN { get; }

        Segment<CTT> TransactionTotals { get; }

        Segment<SE> TransactionSetTrailer { get; }
    }
}