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

        public MacheteException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}