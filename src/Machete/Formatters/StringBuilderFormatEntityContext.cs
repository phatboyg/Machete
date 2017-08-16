namespace Machete.Formatters
{
    using System;
    using Cursors.Contexts;


    public struct StringBuilderFormatEntityContext<TEntity> :
        FormatEntityContext<TEntity>
        where TEntity : Entity
    {
        readonly IContext _context;
        readonly StringBuilderFormatContext _formatContext;
        readonly int _position;

        public TEntity Entity { get; }

        public StringBuilderFormatEntityContext(StringBuilderFormatContext formatContext, TEntity entity)
        {
            Entity = entity;
            _context = new BaseContext(formatContext);
            _formatContext = formatContext;
            _position = formatContext.Position;
        }

        IFormatProvider FormatContext.CurrentCulture => _formatContext.CurrentCulture;
        int FormatContext.Position => _formatContext.Position;

        void FormatContext.Append(TextSlice slice)
        {
            _formatContext.Append(slice);
        }

        void FormatContext.Append(string text)
        {
            _formatContext.Append(text);
        }

        void FormatContext.Append(char c)
        {
            _formatContext.Append(c);
        }

        void FormatContext.Clear()
        {
            _formatContext.Builder.Length = _position;
        }

        FormatValueContext<T> FormatContext.CreateValueContext<T>(Value<T> value)
        {
            return _formatContext.CreateValueContext(value);
        }

        FormatEntityContext<T> FormatContext.CreateEntityContext<T>(T entity)
        {
            return _formatContext.CreateEntityContext(entity);
        }

        void FormatContext.Trim(int position)
        {
            _formatContext.Trim(position);
        }

        bool IReadOnlyContext.HasContext(Type contextType)
        {
            return _context.HasContext(contextType);
        }

        bool IReadOnlyContext.TryGetContext<T>(out T context)
        {
            return _context.TryGetContext(out context);
        }

        T IContext.GetOrAddContext<T>(ContextFactory<T> contextFactory)
        {
            return _context.GetOrAddContext(contextFactory);
        }

        T IContext.AddOrUpdateContext<T>(ContextFactory<T> addFactory, UpdateContextFactory<T> updateFactory)
        {
            return _context.AddOrUpdateContext(addFactory, updateFactory);
        }

        IReadOnlyContextCollection IContext.CurrentContext => _context.CurrentContext;
    }
}