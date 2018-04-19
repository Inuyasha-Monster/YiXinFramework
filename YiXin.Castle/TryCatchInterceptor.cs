using System;
using Castle.Core.Logging;
using Castle.DynamicProxy;
using Microsoft.Extensions.Logging;

namespace YiXin.Castle
{
    public class TryCatchInterceptor : BaseInterceptor
    {
        private readonly ILogger<TryCatchInterceptor> _log;

        public TryCatchInterceptor(ILogger<TryCatchInterceptor> log)
        {
            this._log = log;
        }

        public override void Intercept(IInvocation invocation)
        {
            try
            {
                base.Intercept(invocation);
            }
            catch (Exception ex)
            {
                _log.LogError(ex, $"{invocation.Method.Name} 执行出现未知异常");
            }
        }
    }
}
