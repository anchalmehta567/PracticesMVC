﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDeginpatternExample2
{
    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeesArray);
    }
}
