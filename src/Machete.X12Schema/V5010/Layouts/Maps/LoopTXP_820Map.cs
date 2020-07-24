namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopTXP_820Map :
        X12LayoutMap<LoopTXP_820, X12Entity>
    {
        public LoopTXP_820Map()
        {
            Id = "Loop_TXP_820";
            Name = "Loop TXP";
            
            Segment(x => x.TaxPayment, 0);
            Segment(x => x.TaxInformation, 1);
        }
    }
}