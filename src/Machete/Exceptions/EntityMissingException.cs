namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class EntityMissingException :
        Exception
    {
        public EntityMissingException()
        {
        }

        public EntityMissingException(string message)
            : base(message)
        {
        }

        #if !NETCORE
        public EntityMissingException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        #endif

        public EntityMissingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}