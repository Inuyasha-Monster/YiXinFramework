using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;

namespace YiXin.Castle
{
    public class ConsoleInterceptor : BaseInterceptor
    {
        public override void Intercept(IInvocation invocation)
        {
            Console.WriteLine("before");
            base.Intercept(invocation);
            Console.WriteLine("after");
        }
    }
}
