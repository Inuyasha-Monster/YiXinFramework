using System;
using AspectCore.DynamicProxy;
using Xunit;
using YiXin.AspectCore;
using YiXin.Castle;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test_CastleDynamicProxy()
        {

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
