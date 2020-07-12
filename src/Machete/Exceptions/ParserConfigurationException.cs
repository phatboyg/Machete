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

        public ParserConfigurationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}