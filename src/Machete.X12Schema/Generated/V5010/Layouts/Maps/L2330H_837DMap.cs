namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2330H_837DMap :
        X12LayoutMap<L2330H_837D, X12Entity>
    {
        public L2330H_837DMap()
        {
            Id = "2330H";
            Name = "Other Payer Assistant Surgeon";
            
            Segment(x => x.AssistantSurgeon, 0);
            Segment(x => x.SecondaryIdentification, 1, x => x.IsRequired());
        }
    }
}