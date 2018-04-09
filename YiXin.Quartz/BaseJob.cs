using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YiXin.Core.Interfaces;

namespace YiXin.Quartz
{
    [DisallowConcurrentExecution]
    [PersistJobDataAfterExecution]
    public abstract class BaseJob : IJob
    {
        private readonly ILog _log;

        public BaseJob(ILog log)
        {
            this._log = log;
        }

        public abstract Task ExecuteJob(IJobExecutionContext context);

        public Task Execute(IJobExecutionContext context)
        {
            try
            {
                return ExecuteJob(context);
            }
            catch (Exception ex)
            {
                var jobName = context.JobDetail.Key;
                _log.Error($"{jobName}执行出现未知异常", ex);
                var jobEx = new JobExecutionException(ex, refireImmediately: true);
                throw jobEx;
            }
        }
    }
}
