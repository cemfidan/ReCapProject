using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool isSuccess, string message) : this(isSuccess)
        {
            this.IsSuccess = isSuccess;
            this.Message = message;
        }
        public Result(bool isSuccess)
        {
            this.IsSuccess = isSuccess;
        }
        public bool IsSuccess { get; }

        public string Message { get; }
    }
}
