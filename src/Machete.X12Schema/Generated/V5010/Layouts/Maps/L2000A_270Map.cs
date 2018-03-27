namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000A_270Map :
        X12LayoutMap<L2000A_270, X12Entity>
    {
        public L2000A_270Map()
        {
            Id = "2000A";
            Name = "Information Source Name";
            
            Segment(x => x.InformationSourceLevel, 0, x => x.IsRequired());
            Layout(x => x.InformationSourceDetail, 1);
        }
    }
}