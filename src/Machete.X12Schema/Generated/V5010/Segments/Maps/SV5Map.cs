namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class SV5Map : X12SegmentMap<SV5, X12Entity>
    {
        public SV5Map()
        {
            Id = "SV5";
            Name = "Durable Medical Equipment Service";
            Value(x => x.ProcedureIdentifier, 1, x => x.MinLength(1).IsRequired());
            Value(x => x.LengthOfMedicalNecessityQualifier, 2, x => x.FixedLength(2).IsRequired());
            // TODO qualifier 2
            Value(x => x.LengthOfMedicalNecessity, 3, x => x.MinLength(1).IsRequired());
            Value(x => x.DmeRentalPrice, 4, x => x.MinLength(1));
            Value(x => x.DmePurchasePrice, 5, x => x.MinLength(1));
            Value(x => x.RentalUnitPriceIndicator, 6, x => x.FixedLength(1));
        }
    }
}