using System;
using AspectCore.DynamicProxy;
using Autofac;
using Xunit;
using YiXin.AspectCore;
using YiXin.Castle;
using Castle.DynamicProxy;
using Autofac.Extras.DynamicProxy;
using System.Diagnostics;

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

        [Fact]
        public void Test_AutofacWithCastleProxy()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleInterceptor>();
            builder.RegisterType<Call>().As<ICall>().EnableInterfaceInterceptors();

            var container = builder.Build();

            var call = container.Resolve<ICall>();
            call.SayHello();
        }
    }

    [Intercept(typeof(ConsoleInterceptor))]
    public interface ICall
    {
        void SayHello();
    }

    public class Call : ICall
    {
        public void SayHello()
        {
            Debug.WriteLine("hello");
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
