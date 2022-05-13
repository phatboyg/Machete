namespace Machete.Contexts
{
    using System;
    using Internals.Extensions;


    /// <summary>
    /// Stores a single scope data value.
    /// </summary>
    /// <typeparam name="TPayload"></typeparam>
    public class ContextValue<TPayload> :
        IContextValue<TPayload>
        where TPayload : class
    {
        readonly TPayload _value;

        public ContextValue(TPayload value)
        {
            _value = value ?? throw new ContextNotFoundException($"The payload was not found: {TypeCache<TPayload>.ShortName}");
        }

        Type IContextValue.ValueType => typeof(TPayload);
        TPayload IContextValue<TPayload>.Value => _value;

        bool IContextValue.TryGetValue<T>(out T value)
        {
            value = _value as T;

            return value != null;
        }
    }
}