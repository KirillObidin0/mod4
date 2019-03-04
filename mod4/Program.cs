using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] c = new Car[5];
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = new Car();
            }
            Console.WriteLine(c[0].GetModel());
        }
    }
}
