namespace Machete
{
    using System;


    public interface IPayload
    {
        /// <summary>
        /// Checks if a payload is present in the context
        /// </summary>
        /// <param name="payloadType"></param>
        /// <returns></returns>
        bool HasPayload(Type payloadType);

        /// <summary>
        /// Retrieves a payload from the pipe context
        /// </summary>
        /// <typeparam name="TPayload">The payload type</typeparam>
        /// <param name="payload">The payload</param>
        /// <returns></returns>
        bool TryGetPayload<TPayload>(out TPayload payload)
            where TPayload : class;

        /// <summary>
        /// Returns an existing payload or creates the payload using the factory method provided
        /// </summary>
        /// <typeparam name="TPayload">The payload type</typeparam>
        /// <param name="payloadFactory">The payload factory is the payload is not present</param>
        /// <returns>The payload</returns>
        TPayload GetOrAddPayload<TPayload>(PayloadFactory<TPayload> payloadFactory)
            where TPayload : class;

        /// <summary>
        /// Add a new or update an existing payload
        /// </summary>
        /// <param name="addFactory"></param>
        /// <param name="updateFactory"></param>
        /// <typeparam name="TPayload"></typeparam>
        /// <returns></returns>
        TPayload AddOrUpdatePayload<TPayload>(PayloadFactory<TPayload> addFactory, UpdatePayloadFactory<TPayload> updateFactory)
            where TPayload : class;
    }
}