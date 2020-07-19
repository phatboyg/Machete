namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class AK4Map :
        X12SegmentMap<AK4, X12Entity>
    {
        public AK4Map()
        {
            Id = "AK4";
            Name = "Data Element Note";

            Entity(x => x.PositionInSegment, 1, x => x.IsRequired());
            Value(x => x.DataElementReferenceNumber, 2, x => x.MinLength(1).MaxLength(4));
            Value(x => x.DataElementSyntaxErrorCode, 3, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.CopyOfDataElement, 4, x => x.MinLength(1).MaxLength(99));
        }
    }
}