namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class ResultNotPresentException :
        MacheteParserException
    {
        public ResultNotPresentException()
        {
        }

        public ResultNotPresentException(string message)
            : base(message)
        {
        }

#if !NETCORE
        protected ResultNotPresentException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
        
        public ResultNotPresentException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}