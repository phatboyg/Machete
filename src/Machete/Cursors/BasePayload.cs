namespace Machete.Cursors
{
    using System;
    using System.Threading;
    using Payloads;


    public abstract class BasePayload
    {
        IPayloadCache _payloadCache;

        protected BasePayload()
        {
        }

        protected BasePayload(IPayloadCache payloadCache)
        {
            _payloadCache = payloadCache;
        }

        public bool HasPayload(Type payloadType)
        {
            return PayloadCache.HasPayload(payloadType);
        }

        public bool TryGetPayload<TPayload>(out TPayload payload)
            where TPayload : class
        {
            return PayloadCache.TryGetPayload(out payload);
        }

        public TPayload GetOrAddPayload<TPayload>(PayloadFactory<TPayload> payloadFactory)
            where TPayload : class
        {
            return PayloadCache.GetOrAddPayload(payloadFactory);
        }

        public TPayload AddOrUpdatePayload<TPayload>(PayloadFactory<TPayload> addFactory, UpdatePayloadFactory<TPayload> updateFactory)
            where TPayload : class
        {
            return PayloadCache.AddOrUpdatePayload(addFactory, updateFactory);
        }

        protected IPayloadCache PayloadCache
        {
            get
            {
                if (_payloadCache == null)
                {
                    while (Volatile.Read(ref _payloadCache) == null)
                        Interlocked.CompareExchange(ref _payloadCache, new PayloadCache(), null);
                }

                return _payloadCache;
            }
        }
    }
}