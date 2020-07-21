namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000E_276Map :
        X12LayoutMap<Loop2000E_276, X12Entity>
    {
        public Loop2000E_276Map()
        {
            Id = "Loop_2000E_276";
            Name = "Dependent Level";
            
            Segment(x => x.Level, 0);
            Segment(x => x.DemographicInformation, 1);
            Layout(x => x.Loop2100E, 2);
            Layout(x => x.Loop2200E, 3);
        }
    }
}