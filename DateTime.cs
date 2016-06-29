using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4C1080DTL1
{
    class Program
    {
        static void Main(string[] args)
        {
            // get first number
            Console.Write("Enter the date:");

            DateTime submittedDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(submittedDate.ToString("D"));

            // pause
            Console.ReadLine();
        }
    }
}
