namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class PWKMap :
        X12SegmentMap<PWK, X12Entity>
    {
        public PWKMap()
        {
            Id = "PWK";
            Name = "Paperwork";
            
            Value(x => x.AttachmentReportType, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.AttachmentTransmissionCode, 2, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.IdentificationCodeQualifier, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.AttachmentControlNumber, 6, x => x.MinLength(2).MaxLength(80));
            Value(x => x.AttachmentDescription, 7, x => x.MinLength(1).MaxLength(80));
        }
    }
}