using System;
using AspectCore.DynamicProxy;
using Xunit;
using YiXin.Castle;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var proxyGenerator = new Castle.DynamicProxy.ProxyGenerator();
            var test = proxyGenerator.CreateClassProxy<Test>(new ConsoleInterceptor());
            test.Call();
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
