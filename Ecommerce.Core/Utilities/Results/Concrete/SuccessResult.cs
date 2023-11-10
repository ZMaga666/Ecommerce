﻿using Ecommerce.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Utilities.Results.Concrete
{
    public class SuccessResult : Result, IResult
    {
        public SuccessResult(bool success, string message) : base(true, message)
        {
        }
        public SuccessResult() : base(true) { }

    }
}
