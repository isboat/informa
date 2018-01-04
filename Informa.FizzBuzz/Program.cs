using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informa.FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Program usage:");
            }

            var range = args[0];
            var fizzBuzzService = new FizzBuzzService();
            fizzBuzzService.PrintOutput(range);
        }
    }
}
