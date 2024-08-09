﻿using System.Diagnostics.CodeAnalysis;

namespace Sonaar.Domain.Models.Response
{
    public class ExecResult
    {
        public bool HasErrors { get; set; }

        public bool IsSystemError { get; set; }

        public string Message { get; set; }
    }

    public class ResponseResult<TDataType> : ExecResult
    {
        [AllowNull]
        public TDataType Data { get; set; }
    }
}

