namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000A_271Map :
        X12LayoutMap<Loop2000A_271, X12Entity>
    {
        public Loop2000A_271Map()
        {
            Id = "Loop_2000A_271";
            Name = "Information Source Level";
            
            Segment(x => x.InformationSourceLevel, 0);
            Segment(x => x.RequestValidation, 1);
            Layout(x => x.Loop2100A, 2);
        }
    }
}