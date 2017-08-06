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
    using Internals.Extensions;


    /// <summary>
    /// Stores a single scope data value
    /// </summary>
    /// <typeparam name="TPayload"></typeparam>
    public class ContextValue<TPayload> :
        IContextValue<TPayload>
        where TPayload : class
    {
        readonly TPayload _value;

        public ContextValue(TPayload value)
        {
            if (value == default(TPayload))
                throw new ContextNotFoundException($"The payload was not found: {TypeCache<TPayload>.ShortName}");

            _value = value;
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