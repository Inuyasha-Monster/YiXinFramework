using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Castle.DynamicProxy;

namespace YiXin.Castle
{
    public class ConsoleInterceptor : BaseInterceptor
    {
        public override void Intercept(IInvocation invocation)
        {
            Debug.WriteLine("before");
            base.Intercept(invocation);
            Debug.WriteLine("after");
        }
    }
}
