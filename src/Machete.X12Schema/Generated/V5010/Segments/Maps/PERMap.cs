namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class PERMap :
        X12SegmentMap<PER, X12Entity>
    {
        public PERMap()
        {
            Id = "PER";
            Name = "Administrative Communications Contact";
            
            Value(x => x.ContactFunctionCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.Name, 2, x => x.MinLength(1).MaxLength(60));
            Value(x => x.CommunicationNumberQualifier1, 3, x => x.FixedLength(2));
            Value(x => x.CommunicationNumber1, 4, x => x.MinLength(1).MaxLength(80));
            Value(x => x.CommunicationNumberQualifier2, 5, x => x.FixedLength(2));
            Value(x => x.CommunicationNumber2, 6, x => x.MinLength(1).MaxLength(80));
            Value(x => x.CommunicationNumberQualifier3, 7, x => x.FixedLength(2));
            Value(x => x.CommunicationNumber3, 8, x => x.MinLength(1).MaxLength(80));
        }
    }
}