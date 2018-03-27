namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class SV3Map :
        X12SegmentMap<SV3, X12Entity>
    {
        public SV3Map()
        {
            Id = "SV3";
            Name = "Dental Service";

            Entity(x => x.MedicalProcedureIdentifier, 1, x => x.IsRequired());
            Value(x => x.LineItemChargeAmount, 2, x => x.MinLength(1).MaxLength(18).IsRequired());
            Value(x => x.PlaceOfServiceCode, 3, x => x.MinLength(1).MaxLength(2));
            Entity(x => x.OralCavityDesignation, 4);
            Value(x => x.ProsthesisCrownOrInlayCode, 5, x => x.FixedLength(1));
            Value(x => x.Quantity, 6, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Description, 7, x => x.MinLength(1).MaxLength(80));
            Value(x => x.CopayStatusCode, 8, x => x.FixedLength(1));
            Value(x => x.ProviderAgreementCode, 9, x => x.FixedLength(1));
            Entity(x => x.DiagnosisCodePointer, 10, x => x.FixedLength(1));
        }
    }
}