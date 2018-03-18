namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2330C_837DMap :
        X12LayoutMap<L2330C_837D, X12Entity>
    {
        public L2330C_837DMap()
        {
            Id = "2330C";
            Name = "Other Payer Referring Provider";
            
            Segment(x => x.ReferringProvider, 0);
            Segment(x => x.SecondaryIdentification, 1, x => x.IsRequired());
        }
    }
}