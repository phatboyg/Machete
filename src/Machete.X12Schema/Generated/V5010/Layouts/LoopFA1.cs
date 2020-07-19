namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopFA1 :
        X12Layout
    {
        Segment<FA1> TypeOfFinancialAccountingData { get; }
        
        SegmentList<FA2> AccountingData { get; }
    }
}