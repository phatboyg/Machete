namespace Machete.HL7
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class SegmentEmptyException :
        MacheteException
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