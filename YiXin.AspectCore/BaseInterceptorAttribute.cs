using System.Threading.Tasks;
using AspectCore.DynamicProxy;

namespace YiXin.AspectCore
{
    public class BaseInterceptorAttribute : AbstractInterceptorAttribute
    {
        public override Task Invoke(AspectContext context, AspectDelegate next)
        {
            return context.Invoke(next);
        }
    }
}