using System;

namespace YiXin.Quartz
{
    /// <summary>
    /// Job描述类
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class JobDescriptionAttribute : Attribute
    {
        public string Key { get; set; }
        public string Group { get; set; }
        public string Description { get; set; }
    }
}