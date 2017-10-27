namespace Machete.HL7.Types
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public abstract class BaseHL7Text :
        IComparable<string>,
        ISerializable,
        IEquatable<BaseHL7Text>
    {
        protected readonly string Text;

        protected BaseHL7Text()
        {
        }

        protected BaseHL7Text(string text)
        {
            Text = text;
        }

        protected BaseHL7Text(SerializationInfo info, StreamingContext context)
        {
            Text = info.GetString("Text");
        }

        public int CompareTo(string other)
        {
            return string.Compare(Text, other, StringComparison.Ordinal);
        }

        public bool Equals(BaseHL7Text other)
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
            if (obj.GetType() != typeof(BaseHL7Text))
                return false;
            return Equals((BaseHL7Text) obj);
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

        public static bool operator ==(BaseHL7Text left, BaseHL7Text right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BaseHL7Text left, BaseHL7Text right)
        {
            return !Equals(left, right);
        }

        public static bool operator <(BaseHL7Text left, BaseHL7Text right)
        {
            return string.CompareOrdinal(left.Text, right.Text) < 0;
        }

        public static bool operator >(BaseHL7Text left, BaseHL7Text right)
        {
            return string.CompareOrdinal(left.Text, right.Text) > 0;
        }
    }
}