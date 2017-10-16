namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class SV1Map : X12SegmentMap<SV1, X12Entity>
    {
        public SV1Map()
        {
            Id = "SV1";
            Name = "Professional Service";
            Value(x => x.ProcedureIdentifier, 1, x => x.MinLength(1).IsRequired());
            Value(x => x.ChargeAmount, 2, x => x.MinLength(1).IsRequired());
            Value(x => x.UnitsQualifier, 3, x => x.FixedLength(2).IsRequired());
            // TODO qualifier 3
            Value(x => x.Units, 4, x => x.MinLength(1).IsRequired());
            Value(x => x.PlaceOfService, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.CompositeDiagCodePointer, 7, x => x.MinLength(1));
            Value(x => x.Emergency, 9, x => x.FixedLength(1));
            Value(x => x.Epsdt, 11, x => x.FixedLength(1));
            Value(x => x.FamilyPlanning, 12, x => x.FixedLength(1));
            Value(x => x.CoPayWaiver, 15, x => x.FixedLength(1));
        }
    }
}