namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class MPIMap :
        X12SegmentMap<MPI, X12Entity>
    {
        public MPIMap()
        {
            Id = "MPI";
        }
    }
}