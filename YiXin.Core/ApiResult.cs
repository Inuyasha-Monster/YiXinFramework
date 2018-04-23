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

        public ApiResult(bool successed = true, string msg = "操作成功")
        {
            this.Successed = successed;
            this.Message = msg;
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