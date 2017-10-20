namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class PS1Map : X12SegmentMap<PS1, X12Entity>
    {
        public PS1Map()
        {
            Id = "PS1";
            Name = "Purchase Service";
            Value(x => x.ProviderIdentifier, 1, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.ChargeAmount, 2, x => x.MinLength(1).MaxLength(18).IsRequired());
        }
    }
}