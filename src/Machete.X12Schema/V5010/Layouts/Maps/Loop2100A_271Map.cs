namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2100A_271Map :
        X12LayoutMap<Loop2100A_271, X12Entity>
    {
        public Loop2100A_271Map()
        {
            Id = "Loop_2100A_271";
            Name = "Information Source Name";
            
            Segment(x => x.InformationSourceLevel, 0);
            Segment(x => x.ContactInformation, 1);
            Segment(x => x.RequestValidation, 2);
        }
    }
}