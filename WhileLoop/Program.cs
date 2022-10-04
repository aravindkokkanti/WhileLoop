using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = 1;//initialization
            while (T < 15 )//condition
            {
                if(T==13)
                {
                    T++;     //if we apply continue we get only until 13 number reach at that time increment or decrement is not execute so give T++; to upper of continue statement//
                    continue;//if we apply break we get only until 13 number reach not 13
                }
                Console.WriteLine(T);//in while loop increment or decrement is give after console line
                T++;
            }
            Console.ReadLine();
        }
    }
}
