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
    using System.Linq;
    using System.Reflection;


    public class ArrayContextCollection :
        BaseContextCollection
    {
        readonly IReadOnlyContextCollection _parent;
        readonly IContextValue[] _contexts;

        public ArrayContextCollection(IReadOnlyContextCollection parent, params IContextValue[] contexts)
            : base(parent)
        {
            _contexts = contexts;
            _parent = parent;
        }

        ArrayContextCollection(IReadOnlyContextCollection parent, IContextValue context, IContextValue[] contexts)
            : base(parent)
        {
            _parent = parent;

            _contexts = new IContextValue[contexts.Length + 1];
            _contexts[0] = context;
            Array.Copy(contexts, 0, _contexts, 1, contexts.Length);
        }

        public override bool HasContext(Type contextType)
        {
            if (_contexts.Any(x => contextType.GetTypeInfo().IsAssignableFrom(x.ValueType)))
                return true;

            return base.HasContext(contextType);
        }

        public override bool TryGetContext<TPayload>(out TPayload context)
        {
            for (var i = 0; i < _contexts.Length; i++)
            {
                if (_contexts[i].TryGetValue(out context))
                {
                    return true;
                }
            }

            return base.TryGetContext(out context);
        }

        public override IContextCollection Add(IContextValue context)
        {
            return new ArrayContextCollection(_parent, context, _contexts);
        }
    }
}