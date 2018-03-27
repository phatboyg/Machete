namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2310D_837DMap :
        X12LayoutMap<L2310D_837D, X12Entity>
    {
        public L2310D_837DMap()
        {
            Id = "2310D";
            Name = "Assistant Surgeon Name";
            
            Segment(x => x.AssistantSurgeon, 0);
            Segment(x => x.SpecialtyInformation, 1, x => x.IsRequired());
            Segment(x => x.SecondaryIdentification, 2);
        }
    }
}