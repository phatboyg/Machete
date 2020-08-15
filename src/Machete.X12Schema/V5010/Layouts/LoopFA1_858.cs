namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopFA1_858 :
        X12Layout
    {
        Segment<FA1> TypeOfFinancialAccountingData { get; }
        
        SegmentList<FA2> AccountingData { get; }
        
        Segment<L10> WeightInformation { get; }
    }
}