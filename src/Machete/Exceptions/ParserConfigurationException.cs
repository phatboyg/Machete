namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class ParserConfigurationException :
        MacheteParserException
    {
        public ParserConfigurationException()
        {
        }

        public ParserConfigurationException(string message)
            : base(message)
        {
        }

        #if !NETCORE
        protected ParserConfigurationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        #endif

        public ParserConfigurationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}