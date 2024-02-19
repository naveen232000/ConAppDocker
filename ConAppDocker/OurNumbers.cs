using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDocker
{
    public  class OurNumbers
    {
        public static void Tables(int num)
        {
            Console.WriteLine($"Table for {num}");
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine($"{num,-3} * {i,-3} = {(num*i),-3}");
                Thread.Sleep(500);
            }
          
        }
        public static void CountingNum(int lnum)
        {
            Console.WriteLine($"Counting from 1 to {lnum}");
            for (int i = 1;i <= lnum; i++)
            {
                Console.Write($"{i,-3}");
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }
    }
}
