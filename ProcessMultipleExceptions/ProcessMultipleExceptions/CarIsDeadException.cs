﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    // This custom exception describes the details of the car-is-dead condition.
    // (Remember, you can also simply extend
    public class CarIsDeadException : ApplicationException
    {
         
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }

        // Feed message to parent constructor.
        public CarIsDeadException(string message, string cause, DateTime time)
        : base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
    }
}
