// Copyright 2007-2016 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Machete.Cursors.Payloads
{
    using System;
    using System.Threading;
    using Collections;
    using Internals.Extensions;


    public class PayloadCache :
        IPayloadCache
    {
        IPayloadCollection _collection;

        public PayloadCache()
        {
            _collection = EmptyPayloadCollection.Shared.Empty;
        }

        bool IReadOnlyPayloadCollection.HasPayload(Type payloadType)
        {
            return _collection.HasPayload(payloadType);
        }

        bool IReadOnlyPayloadCollection.TryGetPayload<T>(out T payload)
        {
            return _collection.TryGetPayload(out payload);
        }

        T IPayloadCache.GetOrAddPayload<T>(PayloadFactory<T> payloadFactory)
        {
            try
            {
                IPayloadValue<T> payload = null;

                IPayloadCollection currentCollection;
                do
                {
                    T existingValue;
                    if (_collection.TryGetPayload(out existingValue))
                        return existingValue;

                    IPayloadValue<T> contextProperty = payload ?? (payload = new PayloadValue<T>(payloadFactory()));

                    currentCollection = Volatile.Read(ref _collection);

                    Interlocked.CompareExchange(ref _collection, currentCollection.Add(contextProperty), currentCollection);
                } while (currentCollection == Volatile.Read(ref _collection));

                return payload.Value;
            }
            catch (Exception exception)
            {
                throw new PayloadFactoryException($"The payload factory faulted: {TypeCache<T>.ShortName}", exception);
            }
        }

        T IPayloadCache.AddOrUpdatePayload<T>(PayloadFactory<T> addFactory, UpdatePayloadFactory<T> updateFactory)
        {
            try
            {
                T previousValue = null;
                IPayloadValue<T> payload = null;

                IPayloadCollection currentCollection;
                do
                {
                    T existingValue;
                    if (_collection.TryGetPayload(out existingValue))
                    {
                        if (payload == null || previousValue != existingValue)

                            payload = new PayloadValue<T>(updateFactory(existingValue));

                        previousValue = existingValue;

                        currentCollection = Volatile.Read(ref _collection);

                        Interlocked.CompareExchange(ref _collection, currentCollection.Add(payload), currentCollection);
                    }
                    else
                    {
                        if (payload == null)
                            payload = new PayloadValue<T>(addFactory());

                        currentCollection = Volatile.Read(ref _collection);

                        Interlocked.CompareExchange(ref _collection, currentCollection.Add(payload), currentCollection);
                    }
                } while (currentCollection == Volatile.Read(ref _collection));

                return payload.Value;
            }
            catch (Exception exception)
            {
                throw new PayloadFactoryException($"The payload factory faulted: {TypeCache<T>.ShortName}", exception);
            }
        }
    }
}