namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    
    
    public class TRNMap :
        X12SegmentMap<TRN, X12Entity>
    {
        public TRNMap()
        {
            Id = "TRN";
            Name = "Trace";
            
            Value(x => x.TraceTypeCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.ReferenceIdentification1, 2, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.OriginatingCompanyId, 3, x => x.FixedLength(10));
            Value(x => x.ReferenceIdentification2, 4, x => x.MinLength(1).MaxLength(30));
        }
    }
}