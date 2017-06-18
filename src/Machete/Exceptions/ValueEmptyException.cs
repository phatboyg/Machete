namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class ValueEmptyException :
        MacheteParserException
    {
        public ValueEmptyException()
        {
        }

        public ValueEmptyException(string message)
            : base(message)
        {
        }

        #if !NETCORE
        protected ValueEmptyException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        #endif

        public ValueEmptyException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}