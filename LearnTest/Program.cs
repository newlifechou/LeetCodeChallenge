using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 1000; i=i*2)
            {
                System.Diagnostics.Debug.Print(i.ToString());
                for (int j = 0; j < 1000; j++)
                {
                    sum++;

                }
            }

            Console.WriteLine(sum);
            Console.Read();

        }
    }
}
