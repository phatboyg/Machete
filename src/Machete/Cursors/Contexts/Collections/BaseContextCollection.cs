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
namespace Machete.Cursors.Contexts.Collections
{
    using System;


    public abstract class BaseContextCollection :
        IContextCollection
    {
        readonly IReadOnlyContextCollection _parent;

        protected BaseContextCollection(IReadOnlyContextCollection parent)
        {
            _parent = parent;
        }

        protected IReadOnlyContextCollection Parent => _parent;

        public IReadOnlyContextCollection CurrentContext => this;

        public virtual bool HasContext(Type contextType)
        {
            return _parent?.HasContext(contextType) ?? false;
        }

        public virtual bool TryGetContext<TPayload>(out TPayload context)
            where TPayload : class
        {
            if (_parent != null)
                return _parent.TryGetContext(out context);

            context = null;
            return false;
        }

        public abstract IContextCollection Add(IContextValue context);
    }
}