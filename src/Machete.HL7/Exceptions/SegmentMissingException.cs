namespace Machete.HL7
{
    using System;
    using System.Runtime.Serialization;


    public class SegmentMissingException :
        Exception
    {
        public SegmentMissingException()
        {
        }

        public SegmentMissingException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public SegmentMissingException(string message)
            : base(message)
        {
        }

        public SegmentMissingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}