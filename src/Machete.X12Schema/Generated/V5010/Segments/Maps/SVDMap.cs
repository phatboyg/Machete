namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class SVDMap :
        X12SegmentMap<SVD, X12Entity>
    {
        public SVDMap()
        {
            Id = "SVD";
            Name = "Service Line Adjudication";
            
            Value(x => x.IdentificationCode, 1, x => x.MinLength(2).MaxLength(80).IsRequired());
            Value(x => x.ServiceLinePaidAmount, 2, x => x.MinLength(1).MaxLength(18).IsRequired());
            Entity(x => x.ProcedureIdentifier, 3, x => x.IsRequired());
            Value(x => x.ProductIdentifier, 4, x => x.MinLength(1).MaxLength(48).IsRequired());
            Value(x => x.Quantity, 5, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.AssignedNumber, 6, x => x.MinLength(1).MaxLength(6));
        }
    }
}