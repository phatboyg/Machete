namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class QTYMap :
        X12SegmentMap<QTY, X12Entity>
    {
        public QTYMap()
        {
            Id = "QTY";
            Name = "Quantity";
            
            Value(x => x.QuantityQualifier, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.Quantity, 2, x => x.MinLength(1).MaxLength(15).IsRequired());
        }
    }
}