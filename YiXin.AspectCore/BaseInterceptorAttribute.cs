using System.Threading.Tasks;
using AspectCore.DynamicProxy;

namespace YiXin.AspectCore
{
    public class BaseInterceptorAttribute : AbstractInterceptorAttribute
    {
        public override async Task Invoke(AspectContext context, AspectDelegate next)
        {
            await context.Invoke(next);
        }
    }
}