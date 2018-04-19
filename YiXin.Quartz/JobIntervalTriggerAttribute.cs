using System;

namespace YiXin.Quartz
{
    /// <summary>
    /// Job循环执行触发器标记描述
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class JobIntervalTriggerAttribute : Attribute
    {
        public JobIntervalTriggerAttribute(bool startNow = true, bool isRepeatForever = true, int intervalInSeconds = 60)
        {
            StartNow = startNow;
            IsRepeatForever = isRepeatForever;
            IntervalInSeconds = intervalInSeconds;
        }
        public string Key { get; set; }
        public string Group { get; set; }
        public bool StartNow { get; set; }
        public int IntervalInSeconds { get; set; }
        public bool IsRepeatForever { get; set; }
        public int RepeatCount { get; set; }
    }
}