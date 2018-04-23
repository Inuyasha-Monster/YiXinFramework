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
        public string MessageAssemblyName { get; set; }
        public string MessageClassFullName { get; set; }
        public string Body { get; set; }
    }
}