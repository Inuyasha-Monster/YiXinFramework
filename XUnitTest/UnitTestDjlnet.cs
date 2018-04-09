using System;
using AspectCore.DynamicProxy;
using Xunit;
using YiXin.AspectCore;
using YiXin.Castle;

namespace XUnitTest
{
    public class UnitTestDjlnet
    {
        [Fact]
        public void Test_CastleDynamicProxy()
        {
            var proxy = new Castle.DynamicProxy.ProxyGenerator();
            var call = proxy.CreateClassProxy<Test>(new ConsoleInterceptor());
            call.Call();
        }
    }

    public class Test
    {
        public virtual void Call()
        {
            Console.WriteLine("calling");
        }
    }
}
