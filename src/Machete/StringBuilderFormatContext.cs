namespace Machete
{
    using System;
    using System.Globalization;
    using System.Text;
    using Formatters;
    using Texts;


    public class StringBuilderFormatContext :
        FormatContext
    {
        readonly StringBuilderText _text;
        readonly StringBuilder _builder;

        public StringBuilderFormatContext()
        {
            _builder = new StringBuilder();

            _text = new StringBuilderText(_builder);

            CurrentCulture = CultureInfo.InvariantCulture;
        }

        public StringBuilder Builder => _builder;

        public void Append(TextSlice slice)
        {
            var sliceText = slice.Text;

            sliceText.AppendTo(_builder, new TextSpan(0, sliceText.Length));
        }

        public void Append(string text)
        {
            _builder.Append(text);
        }

        public void Append(char c)
        {
            _builder.Append(c);
        }

        public IFormatProvider CurrentCulture { get; }
        public int Position => _builder.Length;

        public void Clear()
        {
            _text.StringBuilder.Length = 0;
        }

        public FormatValueContext<T> CreateValueContext<T>(Value<T> value)
        {
            return new StringBuilderFormatValueContext<T>(this, value);
        }

        public FormatEntityContext<T> CreateEntityContext<T>(T entity)
            where T : Entity
        {
            return new StringBuilderFormatEntityContext<T>(this, entity);
        }

        public void Trim(int position)
        {
            _builder.Length = position;
        }

        public override string ToString()
        {
            return _builder.ToString();
        }
    }
}