namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2420A_837IMap :
        X12LayoutMap<L2420A_837I, X12Entity>
    {
        public L2420A_837IMap()
        {
            Id = "2420A";
            Name = "Operating Physician Name";
            
            Segment(x => x.Physician, 0);
            Segment(x => x.SecondaryIdentification, 1);
        }
    }
}