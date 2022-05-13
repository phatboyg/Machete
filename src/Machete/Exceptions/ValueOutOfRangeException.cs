namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class ValueOutOfRangeException :
        MacheteParserException
    {
        public ValueOutOfRangeException()
        {
        }

        public ValueOutOfRangeException(string message)
            : base(message)
        {
        }

        protected ValueOutOfRangeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public ValueOutOfRangeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}