using System;

namespace YiXin.Core.Interfaces
{
    public interface ILog
    {
        void Error(string message);
        void Error(string message, Exception innerException);

        void Info(string message);
        void Info(string message, Exception innerException);

        void Warning(string message);
        void Warning(string message, Exception innerException);

        void Fatal(string message);
        void Fatal(string message, Exception innerException);
    }
}