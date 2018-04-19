using System;

namespace YiXin.Quartz
{
    /// <summary>
    /// 排除Job标记
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class IgnoreJobAttribute : Attribute
    {

    }
}