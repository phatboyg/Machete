namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000A_271Map :
        X12LayoutMap<L2000A_271, X12Entity>
    {
        public L2000A_271Map()
        {
            Id = "2000A";
            Name = "Information Source Level";
            
            Segment(x => x.InformationSourceLevel, 0, x => x.IsRequired());
            Segment(x => x.RequestValidation, 1);
            Layout(x => x.InformationSource, 2);
        }
    }
}