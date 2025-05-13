using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._3_Singleton
{
    public class TextPrinter : IPrintJob
    {
        private string _text = "Text to Print";
        public TextPrinter()
        {
            PrintSpooler.GetInstance().print(this);
        }
        public async Task DoSomethingAsync()
        {
            while (true)
            {
                Console.WriteLine(this._text);
                await Task.Delay(3000);
            }
        }
    }
}
