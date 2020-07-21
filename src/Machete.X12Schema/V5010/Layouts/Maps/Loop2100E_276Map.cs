namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2100E_276Map :
        X12LayoutMap<Loop2100E_276, X12Entity>
    {
        public Loop2100E_276Map()
        {
            Id = "Loop_2100E_276";
            Name = "Dependent Name";
            
            Segment(x => x.Dependent, 0);
        }
    }
}