namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LEPMap :
        X12SegmentMap<LEP, X12Entity>
    {
        public LEPMap()
        {
            Id = "LEP";
            Name = "EPA Required Data";
            
            Value(x => x.EPAWasteStreamNumberCode, 1, x => x.MinLength(4).MaxLength(6));
            Value(x => x.WasteCharacteristicsCode, 2, x => x.MinLength(12).MaxLength(16));
            Value(x => x.StateOrProvinceCode, 3, x => x.FixedLength(2));
            Value(x => x.ReferenceIdentification, 4, x => x.MinLength(14).MaxLength(30));
        }
    }
}