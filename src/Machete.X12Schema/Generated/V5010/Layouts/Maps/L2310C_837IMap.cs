namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2310C_837IMap :
        X12LayoutMap<L2310C_837I, X12Entity>
    {
        public L2310C_837IMap()
        {
            Id = "2310C";
            Name = "Other Operating Physician Name";
            
            Segment(x => x.OperatingPhysician, 0);
            Segment(x => x.SecondaryIdentification, 1);
        }
    }
}