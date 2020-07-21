namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2100A_270Map :
        X12LayoutMap<Loop2100A_270, X12Entity>
    {
        public Loop2100A_270Map()
        {
            Id = "Loop_2100A_270";
            Name = "Information Source Name";
            
            Segment(x => x.InformationSource, 0);
        }
    }
}