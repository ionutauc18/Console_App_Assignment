using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this line is a do while loop
            int count = 1;
            do
            {
                Console.WriteLine(count);
                count++; // add one to count each time
            }
            while (count < 15); // continue to loop until count reaches 15

            // this line is a while loop
            int counting = 1;
            while (counting < 8) // continue to loop until count reaches 8
            {
                Console.WriteLine(counting);
                counting++; // add one to counting each time
            }
            Console.ReadLine();
        }
    }
}
