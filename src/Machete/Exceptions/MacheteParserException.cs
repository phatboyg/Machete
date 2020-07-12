namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class MacheteParserException :
        MacheteException
    {
        public MacheteParserException()
        {
        }

        public MacheteParserException(string message)
            : base(message)
        {
        }

        public MacheteParserException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}