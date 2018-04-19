using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Quartz;

namespace YiXin.Quartz
{
    /// <summary>
    /// Job基础类防并发以及持久化Job数据
    /// </summary>
    [DisallowConcurrentExecution]
    [PersistJobDataAfterExecution]
    public abstract class JobBase : IJob
    {
        protected abstract ILogger Logger { get; }

        public Task Execute(IJobExecutionContext context)
        {
            try
            {
                return ExecuteJob(context);
            }
            catch (Exception exception)
            {
                Logger.LogError(exception, $"当前任务key:{context.JobDetail.Key};当前任务描述desc:{context.JobDetail.Description}执行出现未知异常");
                JobExecutionException jobExecutionException = new JobExecutionException(exception, refireImmediately: true);
                throw jobExecutionException;
            }
        }

        protected abstract Task ExecuteJob(IJobExecutionContext context);
    }
}