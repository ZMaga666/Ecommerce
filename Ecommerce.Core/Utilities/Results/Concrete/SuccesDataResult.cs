using Ecommerce.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Utilities.Results.Concrete
{
    public class SuccesDataResult<T> : DataResult<T>, IDataResult<T>
    {
        public SuccesDataResult(T data,  string message) : base(data, true, message)
        {
        }
        public SuccesDataResult(T data  ) : base(data, true)
        {

        }

    }
}
