using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using YiXin.Core.Interfaces;

namespace YiXin.Castle
{
    public class TryCatchInterceptor : BaseInterceptor
    {
        private readonly ILog _log;

        public TryCatchInterceptor(ILog log)
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
                _log.Error("出现未捕获的异常", ex);
            }
        }
    }
}
