namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000A_276Map :
        X12LayoutMap<Loop2000A_276, X12Entity>
    {
        public Loop2000A_276Map()
        {
            Id = "Loop_2000A_276";
            Name = "Information Source Detail";
            
            Segment(x => x.InformationSourceLevel, 0, x => x.IsRequired());
            Layout(x => x.Loop2100A, 1);
        }
    }
}