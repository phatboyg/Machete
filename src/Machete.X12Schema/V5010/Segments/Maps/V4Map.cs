namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class V4Map :
        X12SegmentMap<V4, X12Entity>
    {
        public V4Map()
        {
            Id = "V4";
            Name = "Cargo LocationReference";

            Value( x=> x.VesselStowageLocation, 1, x=> x.MinLength(1).MaxLength(12).IsRequired());
        }
    }
}