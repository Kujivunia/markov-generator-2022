using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markov_generator_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.Dictionary<int, int> d = new System.Collections.Generic.Dictionary<int, int>();
            d.Add(1, 10);
            d.Add(2, 12);
            d.Add(3, 13);

            Console.WriteLine(d);
            Console.WriteLine(d.Values);
            Console.WriteLine(d.Values.Sum());
        }
    }
}
