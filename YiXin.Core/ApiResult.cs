using System;

namespace YiXin.Core
{
    [Serializable]
    public class ApiResult<T> where T : class, new()
    {
        public ApiResult()
        {
            this.Message = string.Empty;
            this.Successed = true;
            this.DevelopMessage = string.Empty;
        }

        public ApiResult(bool successed = true)
        {
            this.Successed = successed;
        }

        public bool Successed { get; set; }
        public T Data { get; set; }
        public object DevelopMessage { get; set; }
        public string Message { get; set; }
    }

    public class ApiResult : ApiResult<object>
    {
        public ApiResult()
        {
            this.Message = string.Empty;
            this.Successed = true;
            this.DevelopMessage = string.Empty;
        }

        public ApiResult(bool successed = true) : base(successed)
        {

        }
    }
}