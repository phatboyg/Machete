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


    /// <summary>
    /// Supports the reading of the property cache
    /// </summary>
    public interface IReadOnlyContextCollection
    {
        /// <summary>
        /// Returns the current context collection
        /// </summary>
        IReadOnlyContextCollection CurrentContext { get; }

        /// <summary>
        /// Checks if the property exists in the cache
        /// </summary>
        /// <param name="contextType">The property type</param>
        /// <returns>True if the property exists in the cache, otherwise false</returns>
        bool HasContext(Type contextType);
        
        /// <summary>
        /// Returns the value of the property if it exists in the cache
        /// </summary>
        /// <typeparam name="T">The property type</typeparam>
        /// <param name="context">The property value</param>
        /// <returns>True if the value was returned, otherwise false</returns>
        bool TryGetContext<T>(out T context)
            where T : class;
    }
}