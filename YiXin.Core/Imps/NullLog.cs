using System;
using System.Collections.Generic;
using System.Text;
using YiXin.Core.Interfaces;

namespace YiXin.Core.Imps
{
    public class NullLog : ILog
    {
        public void Error(string message)
        {
        }

        public void Error(string message, Exception innerException)
        {
        }

        public void Fatal(string message)
        {
        }

        public void Fatal(string message, Exception innerException)
        {
        }

        public void Info(string message)
        {
        }

        public void Info(string message, Exception innerException)
        {
        }

        public void Warning(string message)
        {
        }

        public void Warning(string message, Exception innerException)
        {
        }
    }
}
