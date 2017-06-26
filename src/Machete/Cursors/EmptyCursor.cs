namespace Machete.Cursors
{
    using System;


    public class EmptyCursor<T> :
        Cursor<T>
    {
        public bool HasValue => false;

        public T Value => default(T);

        public bool HasNext => false;

        public Cursor<T> Next()
        {
            throw new InvalidOperationException("There is no next cursor.");
        }

        public bool HasPayload(Type payloadType)
        {
            return false;
        }

        public bool TryGetPayload<TPayload>(out TPayload payload)
            where TPayload : class
        {
            payload = default(TPayload);
            return false;
        }

        public TPayload GetOrAddPayload<TPayload>(PayloadFactory<TPayload> payloadFactory)
            where TPayload : class
        {
            throw new PayloadNotFoundException();
        }

        public TPayload AddOrUpdatePayload<TPayload>(PayloadFactory<TPayload> addFactory, UpdatePayloadFactory<TPayload> updateFactory)
            where TPayload : class
        {
            throw new NotImplementedException();
        }
    }
}