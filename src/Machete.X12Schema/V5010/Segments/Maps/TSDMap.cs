namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class TSDMap :
        X12SegmentMap<TSD, X12Entity>
    {
        public TSDMap()
        {
            Id = "TSD";
            Name = "Trailer Shipment Details";
            
            Value(x => x.AssignedIdentification, 1, x => x.MinLength(1).MaxLength(20));
            Value(x => x.Position, 2, x => x.MinLength(1).MaxLength(3));
        }
    }
}