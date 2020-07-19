namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100A_270Map :
        X12LayoutMap<L2100A_270, X12Entity>
    {
        public L2100A_270Map()
        {
            Id = "2100A";
            Name = "Information Source Name";
            
            Segment(x => x.InformationSource, 0, x => x.IsRequired());
        }
    }
}