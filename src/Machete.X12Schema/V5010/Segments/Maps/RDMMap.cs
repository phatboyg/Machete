namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class RDMMap :
        X12SegmentMap<RDM, X12Entity>
    {
        public RDMMap()
        {
            Id = "RDM";
            Name = "Remittance Delivery Method";
            
            Value(x => x.ReportTransmissionCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.Name, 2, x => x.MinLength(1).MaxLength(60));
            Value(x => x.CommunicationNumber, 3, x => x.MinLength(1).MaxLength(256));
        }
    }
}