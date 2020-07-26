namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G61Map :
        X12SegmentMap<G61, X12Entity>
    {
        public G61Map()
        {
            Id = "G61";
            Name = "Contact";
            
            Value(x => x.ContactFunctionCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.Name, 2, x => x.MinLength(1).MaxLength(60).IsRequired());
            Value(x => x.CommunicationNumberQualifier, 3, x => x.FixedLength(2));
            Value(x => x.CommunicationNumber, 4, x => x.MinLength(1).MaxLength(80));
            Value(x => x.ContactInquiryReference, 5, x => x.MinLength(1).MaxLength(20));
        }
    }
}