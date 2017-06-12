namespace Machete.HL7
{
    using System;

    public static class HL7ValueExtensions
    {
        // Need to be able to perform Get off of the segment as well as the value
        // Need to figure out how to do this for anonymous data structutes as well if possible
        public static Segment<TSegment> Get<TSchema, TCursor, TSegment>(this Result<Cursor<TSchema>, TCursor> source, Func<TCursor, Segment<TSegment>> getter)
            where TSegment : HL7Entity
        {
            try
            {
                if (source == null || !source.HasValue)
                    return Segment.Missing<TSegment>();

                return getter(source.Value);
            }
            catch
            {
                return Segment.Missing<TSegment>();
            }
        }

    }

    public static class Segment
    {
        public static Segment<T> Missing<T>()
            where T : HL7Entity
        {
            return SegmentCache<T>.MissingSegment;
        }

        static class SegmentCache<TSegment>
            where TSegment : HL7Entity
        {
            public static readonly Segment<TSegment> MissingSegment = GetMissingSegment();

            static Segment<TSegment> GetMissingSegment()
            {
                return new MissingSegment<TSegment>();
            }
        }
    }
    
    public class MissingSegment<TSegment> :
        Segment<TSegment>
        where TSegment : HL7Entity
    {
        public Type EntityType => typeof(TSegment);
        public bool IsPresent => false;
        public bool HasValue => false;
        public TSegment Value { get{throw new ValueMissingException("The value is missing.");} }
    }
}