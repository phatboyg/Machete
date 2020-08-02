namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0332_940Map :
        X12LayoutMap<Loop0332_940, X12Entity>
    {
        public Loop0332_940Map()
        {
            Id = "Loop_0332_940";
            Name = "Loop 0332";
            
            Segment(x => x.HazardousIdentificationInformation, 0);
            Segment(x => x.HazardousClassificationInformation, 1);
            Segment(x => x.HazardousMaterialShippingName, 2);
            Segment(x => x.FreeformHazardousMaterialInformation, 3);
            Segment(x => x.EPARequiredData, 4);
            Segment(x => x.CanadianDangerousRequirements, 5);
            Segment(x => x.TransborderDangerousRequirements, 6);
            Segment(x => x.HazardousMaterialIdentifyingReferenceNumbers, 7);
            Segment(x => x.AdministrativeCommunicationsContact, 8);
        }
    }
}