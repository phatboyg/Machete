namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class SliceMissingException :
        MacheteParserException
    {
        public SliceMissingException()
            : this("The slice is missing.")
        {
        }

        public SliceMissingException(string message)
            : base(message)
        {
        }

        #if !NETCORE
        protected SliceMissingException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        #endif
        
        public SliceMissingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}