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

        protected MacheteException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public MacheteException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}