namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LHEMap :
        X12SegmentMap<LHE, X12Entity>
    {
        public LHEMap()
        {
            Id = "LHE";
            Name = "Empty Equipment Hazardous Material Information";
            
            Value(x => x.HazardousMaterialShippingName, 1, x => x.MinLength(1).MaxLength(25).IsRequired());
            Value(x => x.HazardousPlacardNotation, 2, x => x.MinLength(14).MaxLength(40).IsRequired());
            Value(x => x.ReferenceIdentificationQualifier, 3, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.ReferenceIdentification, 4, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.ReportableQuantityCode, 5, x => x.FixedLength(2));
        }
    }
}