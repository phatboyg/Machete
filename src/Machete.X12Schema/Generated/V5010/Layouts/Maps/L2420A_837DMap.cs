namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2420A_837DMap :
        X12LayoutMap<L2420A_837D, X12Entity>
    {
        public L2420A_837DMap()
        {
            Id = "2420A";
            Name = "Rendering Provider Name";
            
            Segment(x => x.RenderingProvider, 0);
            Segment(x => x.SpecialtyInformation, 1, x => x.IsRequired());
            Segment(x => x.SecondaryIdentification, 2);
        }
    }
}