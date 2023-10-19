using AdminPanel.Entities.Abstract.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.Entities.Concrete
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Succes = success;
        }
        public bool Succes { get; }

        public string Message { get; }
    }
}
