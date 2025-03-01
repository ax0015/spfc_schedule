﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedule
{
    internal delegate ScheduleCheckResult CheckScheduleDelegate(Table table);

    internal class ScheduleCheckResult
    {
        public ScheduleCheckResult(string errorName, string message)
        {
            _errorName = errorName;
            _message = message;
        }

        string _errorName;
        public string ErrorName => _errorName;

        string _message;
        public string Message => _message;
    }
}
