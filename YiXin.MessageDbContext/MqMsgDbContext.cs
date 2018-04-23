using System;
using Microsoft.EntityFrameworkCore;

namespace YiXin.MessageDbContext
{
    public class MqMsgDbContext : DbContext
    {
        public MqMsgDbContext(DbContextOptions<MqMsgDbContext> options) : base(options)
        {

        }
    }
}
