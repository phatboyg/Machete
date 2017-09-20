namespace Machete.Translators.Results
{
    using System;
    using Contexts;
    using Internals.Extensions;


    public class ResultTranslateResult<TResult, TSchema> :
        TranslateResult<TSchema>
        where TResult : TSchema
        where TSchema : Entity
    {
        readonly TResult _result;
        readonly TranslateContext<TSchema> _context;
        readonly IReadOnlyContextCollection _contextSnapshot;
        readonly Type _resultType;

        public ResultTranslateResult(TranslateContext<TSchema> context, TResult result, bool isTranslated = true)
        {
            _result = result;
            _resultType = typeof(TResult);

            IsTranslated = isTranslated;

            _context = context;
            _contextSnapshot = context.CurrentContext;
        }

        public ResultTranslateResult(TranslateContext<TSchema> context, bool isTranslated = true)
        {
            _result = default(TResult);
            _resultType = typeof(TResult);

            IsTranslated = isTranslated;

            _context = context;
            _contextSnapshot = context.CurrentContext;
        }

        public ResultTranslateResult(TranslateContext<TSchema> context, TResult result, Type resultType, bool isTranslated = true)
        {
            _result = result;
            _resultType = resultType;

            IsTranslated = isTranslated;

            _context = context;
            _contextSnapshot = context.CurrentContext;
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

            entity = default(T);
            return false;
        }

        public ISchema<TSchema> Schema => _context.Source.Schema;

        public bool HasContext(Type contextType)
        {
            return _contextSnapshot.HasContext(contextType);
        }

        public bool TryGetContext<T>(out T context)
            where T : class
        {
            return _contextSnapshot.TryGetContext(out context);
        }

        public bool IsTranslated { get; }
        public EntityResult<TSchema> Source => _context.Source;

        public override string ToString()
        {
            return $"{TypeCache<TResult>.ShortName}";
        }
    }
}