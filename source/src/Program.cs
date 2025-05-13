using DesignPatterns._3_Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = new TextPrinter();
            var number = new NumberPrinter();
            Console.ReadLine();
        }
    }
}
