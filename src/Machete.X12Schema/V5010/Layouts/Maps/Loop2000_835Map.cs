namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000_835Map :
        X12LayoutMap<Loop2000_835, X12Entity>
    {
        public Loop2000_835Map()
        {
            Id = "Loop_2000_835";
            Name = "Header Number";
            
            Segment(x => x.HeaderNumber, 0);
            Segment(x => x.ProviderSummaryInformation, 1);
            Segment(x => x.ProviderSupplementalSummaryInformation, 2);
            Layout(x => x.Loop2100, 3);
        }
    }
}