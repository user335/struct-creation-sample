using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemonstrator
{
    class Program
    {
        public struct Number { public decimal amount { get; set; } };
        static void Main(string[] args)
        {
            Number myno = new Number();
            myno.amount = 5m;
            Console.WriteLine("Your precious decimal is " + myno.amount);
            Console.Read();
        }
    }
}
