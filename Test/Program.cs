using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> chisla = new List<int>();
            for (int i = 0; i < 10; i++) {

                chisla.Add(i);

                Console.WriteLine(chisla[i]);
            }
       
        }
    }
}
