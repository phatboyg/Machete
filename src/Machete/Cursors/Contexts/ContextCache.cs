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
namespace Machete.Cursors.Contexts
{
    using System;
    using System.Threading;
    using Collections;
    using Internals.Extensions;


    public class ContextCache :
        IContextCache
    {
        IContextCollection _collection;

        public ContextCache()
        {
            _collection = EmptyContextCollection.Shared.Empty;
        }

        public ContextCache(IReadOnlyContextCollection parent)
        {
            _collection = new EmptyContextCollection(parent);
        }

        public IReadOnlyContextCollection CurrentContext => Volatile.Read(ref _collection).CurrentContext;

        bool IReadOnlyContextCollection.HasContext(Type contextType)
        {
            return _collection.HasContext(contextType);
        }

        bool IReadOnlyContextCollection.TryGetContext<T>(out T context)
        {
            return _collection.TryGetContext(out context);
        }

        T IContextCache.GetOrAddContext<T>(ContextFactory<T> contextFactory)
        {
            try
            {
                IContextValue<T> context = null;

                IContextCollection currentCollection;
                do
                {
                    T existingValue;
                    if (_collection.TryGetContext(out existingValue))
                        return existingValue;

                    IContextValue<T> contextProperty = context ?? (context = new ContextValue<T>(contextFactory()));

                    currentCollection = Volatile.Read(ref _collection);

                    Interlocked.CompareExchange(ref _collection, currentCollection.Add(contextProperty), currentCollection);
                } while (currentCollection == Volatile.Read(ref _collection));

                return context.Value;
            }
            catch (Exception exception)
            {
                throw new ContextFactoryException($"The payload factory faulted: {TypeCache<T>.ShortName}", exception);
            }
        }

        T IContextCache.AddOrUpdateContext<T>(ContextFactory<T> addFactory, UpdateContextFactory<T> updateFactory)
        {
            try
            {
                T previousValue = null;
                IContextValue<T> context = null;

                IContextCollection currentCollection;
                do
                {
                    T existingValue;
                    if (_collection.TryGetContext(out existingValue))
                    {
                        if (context == null || previousValue != existingValue)

                            context = new ContextValue<T>(updateFactory(existingValue));

                        previousValue = existingValue;

                        currentCollection = Volatile.Read(ref _collection);

                        Interlocked.CompareExchange(ref _collection, currentCollection.Add(context), currentCollection);
                    }
                    else
                    {
                        if (context == null)
                            context = new ContextValue<T>(addFactory());

                        currentCollection = Volatile.Read(ref _collection);

                        Interlocked.CompareExchange(ref _collection, currentCollection.Add(context), currentCollection);
                    }
                } while (currentCollection == Volatile.Read(ref _collection));

                return context.Value;
            }
            catch (Exception exception)
            {
                throw new ContextFactoryException($"The payload factory faulted: {TypeCache<T>.ShortName}", exception);
            }
        }
    }
}