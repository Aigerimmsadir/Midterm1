using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.SetWindowSize(40,50);  Console.SetBufferSize(40,50);
            Train train = new Train();
            train.dx = 1;
            train.dy = 0;
            Thread t = new Thread(new ThreadStart(train.Move));
            t.Start();
        }
    }
}
