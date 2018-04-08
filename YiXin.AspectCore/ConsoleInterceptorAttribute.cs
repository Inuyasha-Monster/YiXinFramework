using System;
using System.Threading.Tasks;
using AspectCore.DynamicProxy;

namespace YiXin.AspectCore
{
    public class ConsoleInterceptorAttribute : BaseInterceptorAttribute
    {
        public override async Task Invoke(AspectContext context, AspectDelegate next)
        {
            Console.WriteLine("method call before");
            await next(context);
            Console.WriteLine("method call after");
        }
    }
}