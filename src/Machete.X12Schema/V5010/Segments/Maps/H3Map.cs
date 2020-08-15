namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class H3Map :
        X12SegmentMap<H3, X12Entity>
    {
        public H3Map()
        {
            Id = "H3";
            Name = "Special Handling Instructions";

            Value(x => x.SpecialHandlingCode, 1, x => x.MinLength(2).MaxLength(3));

            Value(x => x.SpecialHandlingDescription, 2, x => x.MinLength(2).MaxLength(30));

            Value(x => x.ProtectiveServiceCode, 3, x => x.MinLength(1).MaxLength(4));

            Value(x => x.VentInstructionCode, 4, x => x.MinLength(1).MaxLength(7));

            Value(x => x.TariffApplicationCode, 5, x => x.FixedLength(1));
        }
    }
}