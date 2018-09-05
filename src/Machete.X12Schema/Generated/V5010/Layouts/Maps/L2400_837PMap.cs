namespace Machete.X12Schema.V5010.Maps
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
            Segment(x => x.LineSupplementalInformation, 3,
                x => x.Condition = parser => parser.Where(p => p.ReportTransmissionCode.IsEqualTo("AA") ||
                                                               p.ReportTransmissionCode.IsEqualTo("BM") ||
                                                               p.ReportTransmissionCode.IsEqualTo("EL") ||
                                                               p.ReportTransmissionCode.IsEqualTo("EM") ||
                                                               p.ReportTransmissionCode.IsEqualTo("FT") ||
                                                               p.ReportTransmissionCode.IsEqualTo("FX")));
            Segment(x => x.DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator, 4,
                x => x.Condition = parser => parser.Where(p => p.ReportTransmissionCode.IsEqualTo("AB") ||
                                                               p.ReportTransmissionCode.IsEqualTo("AD") ||
                                                               p.ReportTransmissionCode.IsEqualTo("AF") ||
                                                               p.ReportTransmissionCode.IsEqualTo("AG") ||
                                                               p.ReportTransmissionCode.IsEqualTo("NS")));
            Segment(x => x.AmbulanceTransportInformation, 5);
            Segment(x => x.DurableMedicalEquipmentCertification, 6);
            Segment(x => x.AmbulanceCertification, 7,
                x => x.Condition = parser => parser.Where(p => p.CodeCategory.IsEqualTo("07")));
            Segment(x => x.HospiceEmployeeIndicator, 8,
                x => x.Condition = parser => parser.Where(p => p.CodeCategory.IsEqualTo("70")));
            Segment(x => x.ConditionIndicatorDurableMedicalEquipment, 9,
                x => x.Condition = parser => parser.Where(p => p.CodeCategory.IsEqualTo("09")));
            Segment(x => x.ServiceDate, 10,
                x => x.IsRequired().Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("472")));
            Segment(x => x.PrescriptionDate, 11,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("471")));
            Segment(x => x.CertificationRevisionDate, 12, 
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("607")));
            Segment(x => x.BeginTherapyDate, 13,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("463")));
            Segment(x => x.LastCertificationDate, 14,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("461")));
            Segment(x => x.LastSeenDate, 15,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("304")));
            Segment(x => x.TestDate, 16,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("738") ||
                                                               p.DateTimeQualifier.IsEqualTo("739")));
            Segment(x => x.ShippedDate, 17,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("011")));
            Segment(x => x.LastXRayDate, 18,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("455")));
            Segment(x => x.InitialTreatmentDate, 19,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("454")));
            Segment(x => x.AmbulancePatientCount, 20,
                x => x.Condition = parser => parser.Where(p => p.QuantityQualifier.IsEqualTo("PT")));
            Segment(x => x.ObstetricAnesthesiaAdditionalUnits, 21,
                x => x.Condition = parser => parser.Where(p => p.QuantityQualifier.IsEqualTo("FL")));
            Segment(x => x.TestResult, 22);
            Segment(x => x.ContractInformation, 23);
            Segment(x => x.RepricedLineItemReferenceNumber, 24,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("9B")));
            Segment(x => x.AdjustedRepricedLineItemReferenceNumber, 25,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("9D")));
            Segment(x => x.PriorAuthorization, 26,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("G1")));
            Segment(x => x.LineItemControlNumber, 27,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("6R")));
            Segment(x => x.MammographyCertificationNumber, 28,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("EW")));
            Segment(x => x.CLIANumber, 29,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("X4")));
            Segment(x => x.ReferringCLIAFacilityIdentification, 30,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("F4")));
            Segment(x => x.ImmunizationBatchNumber, 31,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("BT")));
            Segment(x => x.ReferralNumber, 32,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("9F")));
            Segment(x => x.SalesTaxAmount, 33,
                x => x.Condition = parser => parser.Where(p => p.AmountQualifierCode.IsEqualTo("T")));
            Segment(x => x.PostageClaimedAmount, 34,
                x => x.Condition = parser => parser.Where(p => p.AmountQualifierCode.IsEqualTo("F4")));
            Segment(x => x.FileInformation, 35);
            Segment(x => x.LineNote, 36,
                x => x.Condition = parser => parser.Where(p => p.NoteReferenceCode.IsEqualTo("ADD") ||
                                                               p.NoteReferenceCode.IsEqualTo("DCP")));
            Segment(x => x.ThirdPartyOrganizationNotes, 37,
                x => x.Condition = parser => parser.Where(p => p.NoteReferenceCode.IsEqualTo("TPO")));
            Segment(x => x.PurchasedServiceInformation, 38);
            Segment(x => x.LinePricingInformation, 39);
            Layout(x => x.DrugIdentification, 40);
            Layout(x => x.RenderingProvider, 41);
            Layout(x => x.PurchasedServiceProvider, 42);
            Layout(x => x.ServiceFacilityLocation, 43);
            Layout(x => x.SupervisingProvider, 44);
            Layout(x => x.OrderingProvider, 45);
            Layout(x => x.ReferringProvider, 46);
            Layout(x => x.AmbulancePickUpLocation, 47);
            Layout(x => x.AmbulanceDropOffLocation, 48);
            Layout(x => x.LineAdjudicationInformation, 49);
            Layout(x => x.FormIdentificationCode, 50);
        }
    }
}