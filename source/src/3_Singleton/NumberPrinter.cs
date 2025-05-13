using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._3_Singleton
{
    public class NumberPrinter : IPrintJob
    {
        private int _counter = 0;
        public NumberPrinter()
        {
            PrintSpooler.GetInstance().print(this);
        }
        public async Task DoSomethingAsync()
        {
            while (true)
            {
                Console.WriteLine(this._counter++);
                await Task.Delay(2000);
            }
        }
    }
}
