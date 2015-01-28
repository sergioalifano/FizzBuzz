using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
        public static string FizzBuzz(int number)
        {
            //if number is dividible for 3
            if (number % 3 == 0 && number % 5 != 0)
            {
                return "Buzz";
            }

            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (number % 3 != 0 && number % 5 == 0)
            {
                return "Fizz";
            }

            if (number < 0)
            {
                return "";
            }

            return number.ToString();
        }
    }
}
