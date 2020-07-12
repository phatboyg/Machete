namespace Machete.Translators.Results
{
    using System;
    using System.Reflection;
    using Contexts;


    public class CreateTranslateResult<TResult, TSchema> :
        TranslateResult<TSchema>
        where TResult : TSchema
        where TSchema : Entity
    {
        readonly TranslateContext<TSchema> _context;
        readonly TResult _result;
        readonly IReadOnlyContextCollection _contextSnapshot;
        readonly Type _resultType;

        public CreateTranslateResult(TranslateContext<TSchema> context, TResult result, bool isTranslated = true)
        {
            _context = context;
            _result = result;
            _contextSnapshot = context.CurrentContext;
            _resultType = typeof(TResult);

            HasResult = true;

            IsTranslated = isTranslated;
        }

        public CreateTranslateResult(TranslateContext<TSchema> context, bool isTranslated = true)
        {
            _context = context;
            _result = default;
            _contextSnapshot = context.CurrentContext;
            _resultType = typeof(TResult);

            HasResult = false;

            IsTranslated = isTranslated;
        }

        public bool TryGetEntity<T>(int index, out T entity)
            where T : TSchema
        {
            if (index == 0 && typeof(T).IsAssignableFrom(_resultType))
            {
                object obj = _result;
                entity = (T) obj;
                return true;
            }

            entity = default;
            return false;
        }

        public ISchema<TSchema> Schema { get; }
        public bool HasResult { get; }

        public bool HasContext(Type contextType)
        {
            return _contextSnapshot.HasContext(contextType);
        }

        public bool TryGetContext<T1>(out T1 context)
            where T1 : class => _contextSnapshot.TryGetContext(out context);

        public bool IsTranslated { get; }
        public EntityResult<TSchema> Source => _context.Source;
    }
}