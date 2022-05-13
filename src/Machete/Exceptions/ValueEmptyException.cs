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

        protected ValueEmptyException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public ValueEmptyException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}