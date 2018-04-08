using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;

namespace YiXin.Castle
{
    public class BaseInterceptor : IInterceptor
    {
        public virtual void Intercept(IInvocation invocation)
        {
            invocation.Proceed();
        }
    }
}
