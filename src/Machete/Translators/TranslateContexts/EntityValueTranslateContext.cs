namespace Machete.Translators.TranslateContexts
{
    using System;
    using Contexts;


    public class EntityValueTranslateContext<T, TInput, TSchema> :
        TranslateValueContext<T, TInput, TSchema>
        where TSchema : Entity
    {
        readonly TranslateContext<TInput, TSchema> _context;
        readonly Value<T> _value;

        public EntityValueTranslateContext(TranslateContext<TInput, TSchema> context, Value<T> value)
        {
            _context = context;
            _value = value;
        }

        bool IReadOnlyContext.HasContext(Type contextType)
        {
            return _context.HasContext(contextType);
        }

        bool IReadOnlyContext.TryGetContext<T1>(out T1 context)
        {
            return _context.TryGetContext(out context);
        }

        T1 IContext.GetOrAddContext<T1>(ContextFactory<T1> contextFactory)
        {
            return _context.GetOrAddContext(contextFactory);
        }

        T1 IContext.AddOrUpdateContext<T1>(ContextFactory<T1> addFactory, UpdateContextFactory<T1> updateFactory)
        {
            return _context.AddOrUpdateContext(addFactory, updateFactory);
        }

        IReadOnlyContextCollection IContext.CurrentContext => _context.CurrentContext;

        EntityResult<TSchema> TranslateContext<TSchema>.Source => _context.Source;

        TranslateResult<TSchema> TranslateContext<TSchema>.Result<TResult>(TResult result)
        {
            return _context.Result(result);
        }

        TranslateResult<TSchema> TranslateContext<TSchema>.Result(TSchema result, Type resultType)
        {
            return _context.Result(result, resultType);
        }

        TranslateResult<TSchema> TranslateContext<TSchema>.Empty<TResult>()
        {
            return _context.Empty<TResult>();
        }

        TranslateResult<TSchema> TranslateContext<TSchema>.NotTranslated<TResult>(TResult result)
        {
            return _context.NotTranslated(result);
        }

        TranslateResult<TSchema> TranslateContext<TSchema>.NotTranslated<TResult>()
        {
            return _context.NotTranslated<TResult>();
        }

        TranslateResult<TSchema> TranslateContext<TSchema>.Empty()
        {
            return _context.Empty();
        }

        ITranslateResultCollection<TSchema> TranslateContext<TSchema>.CreateResultCollection()
        {
            return _context.CreateResultCollection();
        }

        TranslateContext<T1, TSchema> TranslateContext<TSchema>.CreateContext<T1>(T1 input, int? index)
        {
            return _context.CreateContext(input, index);
        }

        TranslateContext<T1, TSchema> TranslateContext<TSchema>.CreateContext<T1>(int? index)
        {
            return _context.CreateContext<T1>(index);
        }

        TInput TranslateContext<TInput, TSchema>.Input => _context.Input;

        bool TranslateContext<TInput, TSchema>.HasInput => _context.HasInput;

        int? TranslateContext<TInput, TSchema>.Index => _context.Index;

        bool TranslateContext<TInput, TSchema>.TryGetContext<T1>(out TranslateContext<T1, TSchema> context)
        {
            return _context.TryGetContext(out context);
        }

        TranslateContext<TInput, TSchema> TranslateContext<TInput, TSchema>.CreateScope()
        {
            return _context.CreateScope();
        }

        TranslateValueContext<T1, TInput, TSchema> TranslateContext<TInput, TSchema>.CreateValueContext<T1>(Value<T1> value)
        {
            return _context.CreateValueContext(value);
        }

        T TranslateValueContext<T, TInput, TSchema>.Value => _value.Value;

        bool TranslateValueContext<T, TInput, TSchema>.HasValue => _value.HasValue;
    }
}