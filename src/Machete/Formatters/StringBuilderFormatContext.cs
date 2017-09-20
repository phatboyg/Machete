namespace Machete.Formatters
{
    using System;
    using System.Globalization;
    using System.Text;
    using Contexts;
    using Texts;


    public class StringBuilderFormatContext :
        FormatContext
    {
        readonly BaseContext _baseContext;
        readonly StringBuilderText _text;
        readonly StringBuilder _builder;

        public StringBuilderFormatContext()
        {
            _builder = new StringBuilder();

            _text = new StringBuilderText(_builder);

            CurrentCulture = CultureInfo.InvariantCulture;

            _baseContext = new BaseContext();
        }

        public IFormatProvider CurrentCulture { get; }
        public int Position => _builder.Length;

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

        bool IReadOnlyContext.HasContext(Type contextType)
        {
            return _baseContext.HasContext(contextType);
        }

        bool IReadOnlyContext.TryGetContext<T>(out T context)
        {
            return _baseContext.TryGetContext(out context);
        }

        T IContext.GetOrAddContext<T>(ContextFactory<T> contextFactory)
        {
            return _baseContext.GetOrAddContext(contextFactory);
        }

        T IContext.AddOrUpdateContext<T>(ContextFactory<T> addFactory, UpdateContextFactory<T> updateFactory)
        {
            return _baseContext.AddOrUpdateContext(addFactory, updateFactory);
        }

        IReadOnlyContextCollection IContext.CurrentContext => _baseContext.CurrentContext;

        public override string ToString()
        {
            return _builder.ToString();
        }
    }
}