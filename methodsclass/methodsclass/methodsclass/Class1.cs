﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsclass
{
    internal class mathclass
    {
        public void math(double num1, double num2)
        {
            double Total = num1 + 10;
            Console.WriteLine("\nyour number {0} + 10 = " + Total + ".", num1);
            Console.WriteLine("\nyour number {0} is not included in the operation", num2);
            return;
        }
    }
}

