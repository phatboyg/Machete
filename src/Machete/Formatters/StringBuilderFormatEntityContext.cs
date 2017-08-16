namespace Machete.Formatters
{
    using System;


    public struct StringBuilderFormatEntityContext<TEntity> :
        FormatEntityContext<TEntity>
        where TEntity : Entity
    {
        public TEntity Entity { get; }
        readonly StringBuilderFormatContext _context;
        readonly int _position;

        public StringBuilderFormatEntityContext(StringBuilderFormatContext context, TEntity entity)
        {
            Entity = entity;
            _context = context;
            _position = context.Position;
        }

        IFormatProvider FormatContext.CurrentCulture => _context.CurrentCulture;
        int FormatContext.Position => _context.Position;

        void FormatContext.Append(TextSlice slice)
        {
            _context.Append(slice);
        }

        void FormatContext.Append(string text)
        {
            _context.Append(text);
        }

        void FormatContext.Append(char c)
        {
            _context.Append(c);
        }

        void FormatContext.Clear()
        {
            _context.Builder.Length = _position;
        }

        FormatValueContext<T> FormatContext.CreateValueContext<T>(Value<T> value)
        {
            return _context.CreateValueContext(value);
        }

        FormatEntityContext<T> FormatContext.CreateEntityContext<T>(T entity)
        {
            return _context.CreateEntityContext(entity);
        }

        void FormatContext.Trim(int position)
        {
            _context.Trim(position);
        }
    }
}