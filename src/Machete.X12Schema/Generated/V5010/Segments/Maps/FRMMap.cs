namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class FRMMap :
        X12SegmentMap<FRM, X12Entity>
    {
        public FRMMap()
        {
            Id = "FRM";
            Name = "Supporting Documentation";
            
            Value(x => x.QuestionNumber, 1, x => x.MinLength(1).MaxLength(20).IsRequired());
            Value(x => x.ResponseCode, 2, x => x.FixedLength(1));
            Value(x => x.ResponseIdentification, 3, x => x.MinLength(1).MaxLength(50));
            Value(x => x.Date, 4, x => x.LongDate());
            Value(x => x.Percent, 5, x => x.MinLength(1).MaxLength(6));
        }
    }
}