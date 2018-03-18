namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2400_837PMap :
        X12LayoutMap<L2400_837P, X12Entity>
    {
        public L2400_837PMap()
        {
            Id = "2400";
            Name = "Service Line Number";
            
            Segment(x => x.ServiceLineNumber, 0, x => x.IsRequired());
            Segment(x => x.ProfessionalService, 1, x => x.IsRequired());
            Segment(x => x.DurableMedicalEquipmentService, 2);
            Segment(x => x.LineSupplementalInformation, 3);
            Segment(x => x.DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator, 4);
            Segment(x => x.AmbulanceTransportInformation, 5);
            Segment(x => x.DurableMedicalEqumentCertification, 6);
            Segment(x => x.AmbulanceCertification, 7);
            Segment(x => x.HospiceEmployeeIndicator, 8);
            Segment(x => x.ConditionIndicatorDurableMedicalEquipment, 9);
            Segment(x => x.ServiceDate, 10, x => x.IsRequired());
            Segment(x => x.PrescriptionDate, 11);
            Segment(x => x.CertificationRevisionDate, 12);
            Segment(x => x.BeginTherapyDate, 13);
            Segment(x => x.LastCertificationDate, 14);
            Segment(x => x.LastSeenDate, 15);
            Segment(x => x.TestDate, 16);
            Segment(x => x.ShippedDate, 17);
            Segment(x => x.LastXRayDate, 18);
            Segment(x => x.LastSeenDate, 19);
            Segment(x => x.InitialTreatmentDate, 20);
            Segment(x => x.AmbulancePatientCount, 21);
            Segment(x => x.ObstetricAnesthesiaAdditionalUnits, 22);
            Segment(x => x.TestResult, 23);
            Segment(x => x.ContractInformation, 24);
            Segment(x => x.RepricedLineItemReferenceNumber, 25);
            Segment(x => x.AdjustedRepricedLineItemReferenceNumber, 26);
            Segment(x => x.PriorAuthorization, 27);
            Segment(x => x.LineItemControlNumber, 28);
            Segment(x => x.MammographyCerficationNumber, 29);
            Segment(x => x.CLIANumber, 30);
            Segment(x => x.ReferringCLIAFacilityIdentification, 31);
            Segment(x => x.ImmunizationBatchNumber, 32);
            Segment(x => x.ReferralNumber, 33);
            Segment(x => x.SalesTaxAmount, 34);
            Segment(x => x.PostageClaimedAmount, 35);
            Segment(x => x.FileInformation, 36);
            Segment(x => x.LineNote, 37);
            Segment(x => x.ThirdPartyOrganizationNotes, 38);
            Segment(x => x.PurchasedServiceInformation, 39);
            Segment(x => x.LinePricingInformation, 40);
            Layout(x => x.DrugIdentification, 41);
            Layout(x => x.RenderingProvider, 42);
            Layout(x => x.PurchasedServiceProvider, 43);
            Layout(x => x.SerivceFacilityLocation, 44);
            Layout(x => x.SupervisingProvider, 45);
            Layout(x => x.OrderingProvider, 46);
            Layout(x => x.ReferringProvider, 47);
            Layout(x => x.AmbulancePickUpLocation, 48);
            Layout(x => x.AmbulanceDropOffLocation, 49);
            Layout(x => x.LineAdjudicationInformation, 50);
            Layout(x => x.FormIdentificationCode, 51);
        }
    }
}