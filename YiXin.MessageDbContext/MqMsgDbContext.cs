using System;
using Microsoft.EntityFrameworkCore;
using YiXin.MessageDbContext.EntityMapConfig;

namespace YiXin.MessageDbContext
{
    public class MqMsgDbContext : DbContext
    {
        public MqMsgDbContext(DbContextOptions<MqMsgDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MqMessageMapConfig());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<MqMessage> MqMessages { get; set; }
    }
}
