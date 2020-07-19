namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class TDSMap :
        X12SegmentMap<TDS, X12Entity>
    {
        public TDSMap()
        {
            Id = "TDS";
            Name = "Total Monetary Value Summary";
            
            Value(x => x.Amount1, 1, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.Amount2, 2, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Amount3, 3, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Amount4, 4, x => x.MinLength(1).MaxLength(15));
        }
    }
}