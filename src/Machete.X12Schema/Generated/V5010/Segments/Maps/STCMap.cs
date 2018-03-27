namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class STCMap :
        X12SegmentMap<STC, X12Entity>
    {
        public STCMap()
        {
            Id = "STC";
            Name = "Information Receiver Status Information";
            
            Entity(x => x.HealthcareClaimStatus, 1, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.StatusInformationEffectiveDate, 2, x =>
            {
                x.Converter = X12ValueConverters.VariableShortDateTime;
                x.FixedLength(8);
            });
            Value(x => x.ActionCode, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.TotalSubmittedChargesForUnitWork, 4, x => x.MinLength(1).MaxLength(18));
            Entity(x => x.HealthcareClaimStatus2, 10, x => x.MinLength(1).MaxLength(30));
            Entity(x => x.HealthcareClaimStatus3, 11, x => x.MinLength(1).MaxLength(30));
        }
    }
}