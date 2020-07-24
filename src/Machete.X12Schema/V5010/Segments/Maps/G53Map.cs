namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G53Map :
        X12SegmentMap<G53, X12Entity>
    {
        public G53Map()
        {
            Id = "G53";
            Name = "Maintenance Type";
            
            Value(x => x.MaintenanceTypeCode, 1, x => x.FixedLength(3).IsRequired());
        }
    }
}