namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class MacheteStructureException :
        MacheteException
    {
        public MacheteStructureException()
        {
        }

        public MacheteStructureException(string message)
            : base(message)
        {
        }

        protected MacheteStructureException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public MacheteStructureException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}