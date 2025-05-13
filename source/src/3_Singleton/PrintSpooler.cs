using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._3_Singleton
{
    public class PrintSpooler
    {
        private static PrintSpooler? _instance;
        private PrintSpooler()
        {
            
        }
        public static PrintSpooler GetInstance()
        {
            return _instance ?? (_instance = new PrintSpooler());
        }
        public void print(IPrintJob job)
        {
            Task.Run(() => job.DoSomethingAsync());
        }
    }
    public interface IPrintJob
    {
        public Task DoSomethingAsync();
    }
}
