﻿namespace Machete
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

        protected MacheteParserException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public MacheteParserException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}