﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Exceptions
{
    public class ExectionException: Exception
    {
        public ExectionException(string message)
: base(message)
        {

        }
        public ExectionException(string message, Exception inner)
             : base(message, inner)
        {

        }
    }
}
