namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000A_270Map :
        X12LayoutMap<Loop2000A_270, X12Entity>
    {
        public Loop2000A_270Map()
        {
            Id = "Loop_2000A_270";
            Name = "Information Source Name";
            
            Segment(x => x.InformationSourceLevel, 0);
            Layout(x => x.Loop2100A, 1);
        }
    }
}