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
    using System.Reflection;


    public class SingleContextCollection :
        BaseContextCollection
    {
        readonly IReadOnlyContextCollection _parent;
        readonly IContextValue _context;

        public SingleContextCollection(IContextValue context, IReadOnlyContextCollection parent = null)
            : base(parent)
        {
            _context = context;
            _parent = parent;
        }

        public override bool HasContext(Type contextType)
        {
            if (contextType.GetTypeInfo().IsAssignableFrom(_context.ValueType))
                return true;

            return base.HasContext(contextType);
        }

        public override bool TryGetContext<TPayload>(out TPayload context)
        {
            TPayload payloadValue;
            if (_context.TryGetValue(out payloadValue))
            {
                context = payloadValue;
                return true;
            }

            return base.TryGetContext(out context);
        }

        public override IContextCollection Add(IContextValue context)
        {
            return new ArrayContextCollection(_parent, context, _context);
        }
    }
}