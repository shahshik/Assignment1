using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class FizzBuzz
    {
        private String test(int i)
        {
            String output;


            if (i == 0)
            {
                output = "0";
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                output = "FizzBuzz";
            }
            else if (i % 5 == 0)
            {
                output = "Buzz";
            }
            else if (i % 3 == 0)
            {

                output = "Fizz";
            }
            else
            {
                output = i.ToString();
            }

            return output;
        }
        static void Main(String[] args)
        {

            String s1;
            Console.Write("Enter any integer: ");
            String input = Console.ReadLine();
            int i = Convert.ToInt32(input);
            FizzBuzz f = new FizzBuzz();
            s1 = f.test(i);
            Console.WriteLine("Output is: " + s1);


        }
    }
}
