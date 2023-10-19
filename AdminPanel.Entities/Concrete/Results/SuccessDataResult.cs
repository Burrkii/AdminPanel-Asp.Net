using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.Entities.Concrete.Results
{
    public class SuccessDataResult<T> : DataResult<T>

    {
        public SuccessDataResult(T data, bool success, string message) : base(data, true, message)
        {
        }

        public SuccessDataResult(T data) : base(data, true)
        {
        }
        


    }
}
