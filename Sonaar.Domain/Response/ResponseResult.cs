using System.Diagnostics.CodeAnalysis;

namespace Sonaar.Domain.Response
{
    public class ExecResult
    {
        public bool HasErrors { get; set; }//Server side error

        public bool IsSystemError { get; set; } //Client side error (UI)

        public string Message { get; set; } = "Sucess";
    }

    public class ResponseResult<TDataType> : ExecResult
    {
        [AllowNull]
        public TDataType Data { get; set; }
    }
}

