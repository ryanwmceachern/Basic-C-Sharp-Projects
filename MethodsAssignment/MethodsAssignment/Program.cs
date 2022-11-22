using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asking the user to enter two integers one mandatory one optional.
            Console.WriteLine("Enter an integer.");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nYou now have the option to enter a second integer to the equation. (Note this integer is optional.)");
            string b = Console.ReadLine();
            Console.WriteLine("\nWe will now add your Integer(s).");
            

            
            
            Class1 method = new Class1();
            //A message for if the user only chooses one integer
            if (b == "")
            {
                double amount1 = a;
                double amount2 = method.math(amount1);
                Console.WriteLine("\nNo second integer found the result is:\n" +
                    a + " + " + 25 + " = " + amount2);
            }
            //If the user decides to enter two integers.
            else if (b != null)
            {
                double Amount3 = Double.Parse(b);
                double amount = method.math(a, Amount3);
                Console.WriteLine("\n" + a + " + " + Amount3 + " + " + 25 + " = " + amount);
            }



            Console.ReadLine();
        }
    }
}
