namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2400_837IMap :
        X12LayoutMap<L2400_837I, X12Entity>
    {
        public L2400_837IMap()
        {
            Id = "2400";
            Name = "Service Line Number";
            
            Segment(x => x.ServiceLineNumber, 0, x => x.IsRequired());
            Segment(x => x.InstitutionalServiceLine, 1, x => x.IsRequired());
            Segment(x => x.LineSupplementalInformation, 2);
            Segment(x => x.ServiceDate, 3, x => x.IsRequired());
            Segment(x => x.LineItemControlNumber, 4);
            Segment(x => x.RepricedLineItemReferenceNumber, 5);
            Segment(x => x.AdjustedRepricedLineItemReferenceNumber, 6);
            Segment(x => x.ServiceTaxAmount, 7);
            Segment(x => x.FacilityTaxAmount, 8);
            Segment(x => x.ThirdPartyOrganizationNotes, 9);
            Segment(x => x.LinePricingOrRepricingInformation, 10);
            Layout(x => x.DrugIdentification, 11);
            Layout(x => x.OperatingPhysician, 12);
            Layout(x => x.OtherOperatingPhysician, 13);
            Layout(x => x.RenderingProvider, 14);
            Layout(x => x.ReferringProvider, 15);
            Layout(x => x.LineAdjudicationInformation, 16);
        }
    }
}