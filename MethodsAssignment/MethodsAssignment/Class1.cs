using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    
    internal class Class1
    {
        
        public double math(double num1, [Optional] double num2)
        {
            double totalAmount = num1 + num2 + 25;
            return totalAmount;
        }


    }
}
