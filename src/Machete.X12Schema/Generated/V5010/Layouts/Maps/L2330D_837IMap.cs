namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2330D_837IMap :
        X12LayoutMap<L2330D_837I, X12Entity>
    {
        public L2330D_837IMap()
        {
            Id = "2330D";
            Name = "Other Payer Operating Physician";
            
            Segment(x => x.OperatingPhysician, 0);
            Segment(x => x.SecondaryIdentification, 1, x => x.IsRequired());
        }
    }
}