namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class MacheteSchemaException :
        MacheteException
    {
        public MacheteSchemaException()
        {
        }

        public MacheteSchemaException(string message)
            : base(message)
        {
        }

        #if !NETCORE
        protected MacheteSchemaException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        #endif

        public MacheteSchemaException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}