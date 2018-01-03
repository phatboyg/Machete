namespace Machete.HL7
{
    using System;
    using System.Runtime.Serialization;
    using Types;


    [Serializable]
    public class TX :
        BaseHL7Text,
        IComparable<TX>,
        IEquatable<TX>
    {
        public TX()
        {
        }

        public TX(string text)
            : base(text)
        {
        }

        protected TX(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }


        public int CompareTo(TX other)
        {
            return string.Compare(Text, other.Text, StringComparison.Ordinal);
        }

        public bool Equals(TX other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return Equals(other.Text, Text);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(TX))
                return false;

            return Equals((TX)obj);
        }

        public override int GetHashCode()
        {
            return (Text != null
                ? Text.GetHashCode()
                : 0);
        }

        public static implicit operator TX(string value)
        {
            return new TX(value);
        }

        public static implicit operator string(TX value)
        {
            return value == null ? null : value.Text;
        }
    }
}