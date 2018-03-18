namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100A_271Map :
        X12LayoutMap<L2100A_271, X12Entity>
    {
        public L2100A_271Map()
        {
            Id = "2100A";
            Name = "Information Source Name";
            
            Segment(x => x.InformationSourceLevel, 0, x => x.IsRequired());
            Segment(x => x.ContactInformation, 1);
            Segment(x => x.RequestValidation, 2);
        }
    }
}