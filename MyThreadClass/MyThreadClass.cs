using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyThreadClass
{
    class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loopCount = 0; loopCount < 6; loopCount++) 
            {
                Thread.Sleep(1500);
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process " + loopCount);

            }

        }
    }

}
