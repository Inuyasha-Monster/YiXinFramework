using System;
using System.Diagnostics;
using System.Threading.Tasks;
using AspectCore.DynamicProxy;

namespace YiXin.AspectCore
{
    public class ConsoleInterceptorAttribute : BaseInterceptorAttribute
    {
        public override async Task Invoke(AspectContext context, AspectDelegate next)
        {
            Debug.WriteLine("method call before");
            await next(context);
            Debug.WriteLine("method call after");
        }
    }
}