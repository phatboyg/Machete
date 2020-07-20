namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2430_837DMap :
        X12LayoutMap<Loop2430_837D, X12Entity>
    {
        public Loop2430_837DMap()
        {
            Id = "2430";
            Name = "Line Adjudication Information";
                        
            Segment(x => x.LineAdjudicationInformation, 0);
            Segment(x => x.LineAdjustment, 1);
            Segment(x => x.LineCheckOrRemittanceDate, 2, x => x.IsRequired());
            Segment(x => x.RemainingPatientLiability, 3);
        }
    }
}