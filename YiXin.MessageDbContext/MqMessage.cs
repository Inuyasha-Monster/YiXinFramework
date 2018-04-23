using System;
using YiXin.Core;

namespace YiXin.MessageDbContext
{
    public class MqMessage : IntegrationEvent
    {
        public MqMessage() : base()
        {
            this.IsPublished = false;
        }

        public bool IsPublished { get; set; }
        public DateTime? SeedTime { get; set; }
        public string MessageAssemblyName { get; set; }
        public string MessageClassFullName { get; set; }
        public string Body { get; set; }
        /// <summary>
        /// 发送失败记录错误到消息Row中
        /// </summary>
        public string SeedErrorMsg { get; set; }
    }
}