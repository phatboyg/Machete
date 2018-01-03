namespace Machete.HL7.Tests.TestSchema
{
    using System;
    using System.Runtime.Serialization;
    using Types;


    [Serializable]
    public class BaseHL7TextDataType :
        IComparable<string>,
        ISerializable,
        IEquatable<BaseHL7TextDataType>

    {
        protected readonly string Text;

        protected BaseHL7TextDataType()
        {
        }

        protected BaseHL7TextDataType(string text)
        {
            Text = text;
        }

        protected BaseHL7TextDataType(SerializationInfo info, StreamingContext context)
        {
            Text = info.GetString("Text");
        }

        public int CompareTo(string other)
        {
            return string.Compare(Text, other, StringComparison.Ordinal);
        }

        public bool Equals(BaseHL7TextDataType other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return Equals(other.Text, Text);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Text", Text);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(BaseHL7TextDataType))
                return false;
            return Equals((BaseHL7TextDataType) obj);
        }

        public override int GetHashCode()
        {
            return Text != null
                ? Text.GetHashCode()
                : 0;
        }

        public override string ToString()
        {
            return Text ?? "";
        }

        public static bool operator ==(BaseHL7TextDataType left, BaseHL7TextDataType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BaseHL7TextDataType left, BaseHL7TextDataType right)
        {
            return !Equals(left, right);
        }

        public static bool operator <(BaseHL7TextDataType left, BaseHL7TextDataType right)
        {
            return string.CompareOrdinal(left.Text, right.Text) < 0;
        }

        public static bool operator >(BaseHL7TextDataType left, BaseHL7TextDataType right)
        {
            return string.CompareOrdinal(left.Text, right.Text) > 0;
        }
    }
}