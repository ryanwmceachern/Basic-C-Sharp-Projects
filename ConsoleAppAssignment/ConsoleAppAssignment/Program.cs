using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
 {
        class Program
        {
            static void Main()
            {
            //pt 1
                string[] words = { "this", "is", "a", "word", "String", };

            Console.WriteLine("please input some text below");
            string input5 = Console.ReadLine();

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(words + input5);
                Console.ReadLine();

            }
            //pt2
            //// this is a infinite loop
            //for (int a = 0; a < 50; a--)
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine();

            ////fixed the loop
            //for (int a = 0; a < 50; a++)
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine();

            //pt 3
            //for (int i = 0; i < 10000; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int x = 0; x <= 500; x++)
            //{
            //    Console.WriteLine(x);
            //}

            //pt 4
            //List<string> things = new List<string>() { "cat", "truck", "fan", "book", "smart", "car", "rock" };
            //Console.WriteLine("Please choose a word in the list");


            //Console.WriteLine(string.Join(", ", things));
            //string input = Console.ReadLine().ToLower();

            //if (things.Contains(input))
            //{
            //    Console.WriteLine(input + " is on the list");
            //}

            //else
            //{
            //    Console.WriteLine("Sorry could not find on the list ! \n");

            //}
            //Console.ReadLine();



            //pt 5
            //List<string> things2 = new List<string>() { "fan", "feild", "motor", "wheel", "motor", "rim", "tire" };
            //Console.WriteLine(string.Join(",", things2));

            //Console.WriteLine("Select a word from the list");
            //string input1 = Console.ReadLine().ToLower();

            //if (things2.Contains(input1))

            //    Console.WriteLine(input1 + " is on the list");


            //else

            //    Console.WriteLine("that word isnt on the list ");

            //Console.ReadLine();




            //pt 6
            //List<string> things3 = new List<string>() { "tire", "motor", "couch", "wheel", "motor", "rim",
            //    "show", "fish", "woof", "loss", "cheese", "random", "house", "fin"  };

            //foreach (string thing in things3)
            //{
            //    if (thing == "mouse")

            //        Console.WriteLine(thing + "  this has a duplicate value in this list  ");

            //    else 

            //        Console.WriteLine(thing + " this is a unique value ");

            //}
            //Console.ReadLine();





        }
    }
}
