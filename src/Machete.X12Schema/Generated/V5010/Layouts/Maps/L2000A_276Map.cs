namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000A_276Map :
        X12LayoutMap<L2000A_276, X12Entity>
    {
        public L2000A_276Map()
        {
            Id = "2000A";
            Name = "Information Source Detail";
            
            Segment(x => x.InformationSourceLevel, 0, x => x.IsRequired());
            Layout(x => x.PayerName, 1);
        }
    }
}