namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class MPIMap :
        X12SegmentMap<MPI, X12Entity>
    {
        public MPIMap()
        {
            Id = "MPI";
        }
    }
}