using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks_practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(() =>
            {
                int summ = 0;
                for (int i = 1; i < 100 + 1; i++)
                {
                    summ = summ + i;
                    
                }
                Console.WriteLine(summ);
            });
            t1.Start();
            Console.ReadLine();
        }
    }
}
