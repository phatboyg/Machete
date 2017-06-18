namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class MacheteException :
        Exception
    {
        public MacheteException()
        {
        }

        public MacheteException(string message)
            : base(message)
        {
        }

        #if !NETCORE
        protected MacheteException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        #endif

        public MacheteException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}