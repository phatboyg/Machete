namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100E_276Map :
        X12LayoutMap<L2100E_276, X12Entity>
    {
        public L2100E_276Map()
        {
            Id = "2100E";
            Name = "Dependent Name";
            
            Segment(x => x.DependentName, 0, x => x.IsRequired());
        }
    }
}