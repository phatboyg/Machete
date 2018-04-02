namespace Machete.Texts
{
    using System;
    using System.Diagnostics;
    using System.Text;
    using System.Threading.Tasks;


    public class StreamText :
        ParseText
    {
        readonly ParseText _text;
        readonly IStreamTextReader _reader;

        public StreamText(ParseText text, IStreamTextReader reader)
        {
            _text = text;
            _reader = reader;
        }

        public override void AppendTo(StringBuilder builder, TextSpan span)
        {
            _text.AppendTo(builder, span);
        }

        public override int Compare(string comparator, int index, TextSpan span, StringComparison comparison)
        {
            return _text.Compare(comparator, index, span, comparison);
        }

        public override ParseText GetSubText(TextSpan span)
        {
            return _text.GetSubText(span);
        }

        public override string ToString(TextSpan span)
        {
            return _text.ToString(span);
        }

        public override string ToString()
        {
            return _text.ToString();
        }

        public override int GetHashCode()
        {
            return _text.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return _text.Equals(obj);
        }

        public override char this[int position] => _text[position];

        public override int Length => _text.Length;

        public bool HasNext => _reader != null;

        public IStreamTextReader Reader => _reader;

        public Task<StreamText> GetNext(TextSpan left)
        {
            Debug.Assert(_reader != null);

            var parseText = GetSubText(left);

            return _reader.Next(parseText);
        }

        public override void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            _text.CopyTo(sourceIndex, destination, destinationIndex, count);
        }
    }
}