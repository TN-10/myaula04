using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMethod
{
    class Program

    {
        /// <summary>
        /// count to 10
        /// </summary>
        static void CountTo10()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(i);

        }
        /// <summary>
        /// count to n
        /// </summary>
        /// <param name="n"></param>
        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);


        }

        /// <summary>
        /// This is my main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)

        {   
         
            CountTo10();
            CountTo10();
            CountToN(3);
            CountToN(4);


        }

    }

}


