namespace Machete.X12.Exceptions
{
    using System;
    using System.Runtime.Serialization;


    public class SegmentEmptyException :
        Exception
    {
        public SegmentEmptyException()
        {
        }

        public SegmentEmptyException(string message)
            : base(message)
        {
        }

        #if !NETCORE
        public SegmentEmptyException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        #endif

        public SegmentEmptyException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}